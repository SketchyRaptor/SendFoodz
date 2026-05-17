using LogIn1.LogIn1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LogIn1
{
    public partial class OrderMenu : Form
    {
        private static List<CartItem> cart = new List<CartItem>();
        private string currentMerchant;

        public OrderMenu(string merchantUsername)
        {
            InitializeComponent();
            // Open in full screen
            this.WindowState = FormWindowState.Maximized;
            currentMerchant = merchantUsername;

            MerchantProducts.ProductAdded += OnProductAdded;
            LoadMerchantProducts();
            RefreshCartGrid();

            dgvMenu.CellClick += DgvMenu_CellClick;
            dgvCart.CellClick += DgvCart_CellClick;
            btnPlaceOrder.Click += BtnPlaceOrder_Click;

            // Responsive layout
            this.Resize += OrderMenu_Resize;
            AdjustDataGridViewHeights();
        }

        private void OrderMenu_Resize(object sender, EventArgs e)
        {
            AdjustDataGridViewHeights();
        }

        private void AdjustDataGridViewHeights()
        {
            if (dgvMenu == null || dgvCart == null) return;

            // Make DataGridViews fill most of their parent panels
            int topMargin = panel1.Height + 20;
            int bottomMargin = 20;
            dgvMenu.Height = pnlMenu.Height - topMargin - bottomMargin;
            dgvMenu.Width = pnlMenu.Width - 40;
            dgvMenu.Left = 20;

            dgvCart.Height = pnlCart.Height - panel2.Height - 100; // leave space for buttons
            dgvCart.Width = pnlCart.Width - 40;
            dgvCart.Left = 20;

            // Reposition buttons and total label
            int btnWidth = 180;
            int btnHeight = 42;
            int rightMargin = 30;
            btnPlaceOrder.Width = btnWidth;
            btnPlaceOrder.Height = btnHeight;
            btnPlaceOrder.Left = pnlCart.Width - btnWidth - rightMargin;
            btnPlaceOrder.Top = dgvCart.Bottom + 15;

            btnBack.Width = btnWidth;
            btnBack.Height = btnHeight;
            btnBack.Left = btnPlaceOrder.Left - btnWidth - 20;
            btnBack.Top = dgvCart.Bottom + 15;

            lblGrandTotal.Left = 20;
            lblGrandTotal.Top = dgvCart.Bottom + 25;
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e) { }

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
                    AddToCart(productName, price, qtyDialog.Quantity);
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

            // Show address dialog
            AddressDialog addressDialog = new AddressDialog();
            if (addressDialog.ShowDialog() != DialogResult.OK)
            {
                return; // User cancelled address input
            }

            decimal total = cart.Sum(i => i.Total);

            Order newOrder = new Order
            {
                CustomerName = Form1.CurrentUsername,
                MerchantName = currentMerchant,
                Address = addressDialog.DeliveryAddress, // Add the address
                Total = total,
                Status = "Active",
                Stage = "Pending",
                Rider = null // Initially no rider assigned
            };

            foreach (var item in cart)
            {
                newOrder.ItemsSummary.Add($"{item.Name} x{item.Quantity}");
            }

            newOrder.HistoryLog.Add($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - Order placed. Stage: Pending");
            newOrder.HistoryLog.Add($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - Delivery Address: {addressDialog.DeliveryAddress}");

            OrderStorage.AddOrder(newOrder);

            MessageBox.Show($"Order placed successfully!\nOrder ID: {newOrder.OrderId}\nTotal: ₱{total:F2}\nDelivery Address: {addressDialog.DeliveryAddress}\n\nThank you for your order!",
                "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cart.Clear();
            RefreshCartGrid();
        }

        private string AssignRider() => null;

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