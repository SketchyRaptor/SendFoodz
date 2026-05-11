using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LogIn1
{
    public partial class OrderMenu : Form
    {
        // Static cart – persists across different merchant selections
        private static List<CartItem> cart = new List<CartItem>();
        private string currentMerchant;

        public OrderMenu(string merchantUsername)
        {
            InitializeComponent();
            currentMerchant = merchantUsername;

            // Subscribe to product additions from MerchantProducts
            MerchantProducts.ProductAdded += OnProductAdded;

            // Load existing products for this merchant
            LoadMerchantProducts();

            // Load the shared cart into the grid
            RefreshCartGrid();

            // Handle events
            dgvMenu.CellClick += DgvMenu_CellClick;
            dgvCart.CellClick += DgvCart_CellClick;
            btnPlaceOrder.Click += BtnPlaceOrder_Click;
            btnBack.Click += btnBack_Click;   // already wired in designer, but safe to reassign
        }

        // ===== FIX: missing event handler for pnlMenu.Paint =====
        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {
            // Optional: custom drawing if needed – leave empty for now
        }

        private void LoadMerchantProducts()
        {
            dgvMenu.Rows.Clear();
            var products = MerchantProducts.GetProductsForMerchant(currentMerchant);
            foreach (var product in products)
            {
                dgvMenu.Rows.Add(product.Image, product.Name, product.Price, "Add to Cart");
            }
        }

        private void OnProductAdded(string merchantUsername, ProductItem product)
        {
            if (merchantUsername == currentMerchant)
            {
                dgvMenu.Rows.Add(product.Image, product.Name, product.Price, "Add to Cart");
            }
        }

        private void DgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvMenu.Columns["colMenuAdd"].Index)
            {
                string productName = dgvMenu.Rows[e.RowIndex].Cells["colMenuName"].Value.ToString();
                decimal price = Convert.ToDecimal(dgvMenu.Rows[e.RowIndex].Cells["colMenuPrice"].Value);

                QuantityDialog qtyDialog = new QuantityDialog();
                if (qtyDialog.ShowDialog() == DialogResult.OK)
                {
                    int quantity = qtyDialog.Quantity;
                    AddToCart(productName, price, quantity);
                }
            }
        }

        private void AddToCart(string name, decimal price, int quantity)
        {
            var existing = cart.FirstOrDefault(c => c.Name == name);
            if (existing != null)
            {
                existing.Quantity += quantity;
                existing.Total = existing.Quantity * existing.Price;
            }
            else
            {
                cart.Add(new CartItem
                {
                    Name = name,
                    Price = price,
                    Quantity = quantity,
                    Total = price * quantity
                });
            }
            RefreshCartGrid();
        }

        private void RefreshCartGrid()
        {
            dgvCart.Rows.Clear();
            decimal grandTotal = 0;
            foreach (var item in cart)
            {
                dgvCart.Rows.Add(item.Name, item.Quantity, item.Price, item.Total);
                grandTotal += item.Total;
            }
            lblGrandTotal.Text = $"Grand Total: ₱{grandTotal:F2}";
        }

        private void DgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (MessageBox.Show("Remove this item from order?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cart.RemoveAt(e.RowIndex);
                    RefreshCartGrid();
                }
            }
        }

        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Add some items first.", "Order",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal total = cart.Sum(i => i.Total);
            MessageBox.Show($"Order placed successfully!\nTotal amount: ₱{total:F2}\nThank you!",
                "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cart.Clear();
            RefreshCartGrid();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerDashboard back = new CustomerDashboard();
            back.Show();
            this.Close();
        }
    }

    public class CartItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
    }

    public class QuantityDialog : Form
    {
        private NumericUpDown numQty;
        private Button btnOk;
        private Button btnCancel;
        public int Quantity { get; private set; }

        public QuantityDialog()
        {
            this.Text = "Enter Quantity";
            this.Size = new System.Drawing.Size(200, 120);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;

            numQty = new NumericUpDown { Minimum = 1, Maximum = 999, Value = 1, Location = new System.Drawing.Point(12, 12), Width = 150 };
            btnOk = new Button { Text = "OK", DialogResult = DialogResult.OK, Location = new System.Drawing.Point(12, 45), Width = 70 };
            btnOk.Click += (s, e) => { Quantity = (int)numQty.Value; };
            btnCancel = new Button { Text = "Cancel", DialogResult = DialogResult.Cancel, Location = new System.Drawing.Point(90, 45), Width = 70 };

            Controls.Add(numQty);
            Controls.Add(btnOk);
            Controls.Add(btnCancel);
        }
    }
}