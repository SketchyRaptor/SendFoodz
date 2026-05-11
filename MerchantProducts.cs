using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LogIn1
{
    public partial class MerchantProducts : Form
    {
        // Per-merchant product catalog (private, but accessible via method)
        private static Dictionary<string, List<ProductItem>> merchantProducts = new Dictionary<string, List<ProductItem>>();

        // Event includes merchant username and the product added
        public static event Action<string, ProductItem> ProductAdded;

        private string loggedInMerchant;

        // Public method to get a merchant's product list (safe copy or reference)
        public static List<ProductItem> GetProductsForMerchant(string merchantUsername)
        {
            if (!merchantProducts.ContainsKey(merchantUsername))
                merchantProducts[merchantUsername] = new List<ProductItem>();
            return merchantProducts[merchantUsername];
        }

        public MerchantProducts(string merchantUsername)
        {
            InitializeComponent();
            loggedInMerchant = merchantUsername;

            // Ensure the merchant has an entry
            if (!merchantProducts.ContainsKey(loggedInMerchant))
                merchantProducts[loggedInMerchant] = new List<ProductItem>();

            // Add image column to DataGridView
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
            {
                Name = "colImage",
                HeaderText = "Image",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 80
            };
            dataGridView1.Columns.Insert(0, imageColumn);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btnSelectImage.Click += BtnSelectImage_Click;

            // Load existing products for this merchant
            LoadProductsForCurrentMerchant();
        }

        private void LoadProductsForCurrentMerchant()
        {
            dataGridView1.Rows.Clear();
            var productList = merchantProducts[loggedInMerchant];
            foreach (var product in productList)
            {
                dataGridView1.Rows.Add(product.Image, product.Name, product.Price, product.Quantity, product.Total);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Validation...
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please enter a product name.", "Validation Error");
                txtProductName.Focus();
                return;
            }
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid price.", "Validation Error");
                txtPrice.Focus();
                return;
            }
            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Please enter a valid quantity.", "Validation Error");
                txtQuantity.Focus();
                return;
            }

            decimal total = price * quantity;
            Image productImage = pictureBox1.Image;

            // Add to grid
            dataGridView1.Rows.Add(productImage, txtProductName.Text, price, quantity, total);

            ProductItem newProduct = new ProductItem
            {
                Name = txtProductName.Text,
                Price = price,
                Quantity = quantity,
                Image = productImage,
                Total = total
            };
            merchantProducts[loggedInMerchant].Add(newProduct);
            ProductAdded?.Invoke(loggedInMerchant, newProduct);

            // Clear inputs
            txtProductName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            pictureBox1.Image = null;
            lblImageName.Text = "No image selected";

            if (dataGridView1.Rows.Count > 0)
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;

            MessageBox.Show("Product saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSelectImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    lblImageName.Text = Path.GetFileName(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not load image: " + ex.Message, "Error");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpProductInfo_Enter(object sender, EventArgs e)
        {

        }
    }

    public class ProductItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public Image Image { get; set; }
    }
}