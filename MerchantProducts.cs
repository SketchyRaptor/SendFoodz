using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LogIn1
{
    public partial class MerchantProducts : Form
    {
        public MerchantProducts()
        {
            InitializeComponent();

            // Add an image column to the DataGridView
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
            {
                Name = "colImage",
                HeaderText = "Image",
                ImageLayout = DataGridViewImageCellLayout.Zoom,  // Fit image in cell
                Width = 80                                      // Fixed width for image column
            };
            dataGridView1.Columns.Insert(0, imageColumn);       // Insert as first column (optional)

            // Auto-size other columns to fill remaining space
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Wire up the Select Image button click event
            btnSelectImage.Click += BtnSelectImage_Click;
        }

        // ==================== SAVE PRODUCT ====================
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Validate Product Name
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please enter a product name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductName.Focus();
                return;
            }

            // Validate Price
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid price (e.g., 19.99).", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

            // Validate Quantity
            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Please enter a valid quantity (positive integer).", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return;
            }

            // Calculate Total
            decimal total = price * quantity;

            // Get the product image (nullable)
            Image productImage = pictureBox1.Image;

            // Add a new row to DataGridView
            // Columns order: colImage (index 0), colName, colPrice, colQty, colTotal
            dataGridView1.Rows.Add(productImage,          // Image column
                                   txtProductName.Text,  // Name
                                   price,                // Price
                                   quantity,             // Quantity
                                   total);               // Total

            // Clear input fields for next product
            txtProductName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            pictureBox1.Image = null;
            lblImageName.Text = "No image selected";

            // Optional: scroll to the newly added row
            if (dataGridView1.Rows.Count > 0)
                dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.Rows.Count - 1;

            // Notify user
            MessageBox.Show("Product saved successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ==================== SELECT IMAGE ====================
        private void BtnSelectImage_Click(object sender, EventArgs e)
        {
            // openFileDialog is already defined in the designer
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the full-size image into the PictureBox
                    Image originalImage = Image.FromFile(openFileDialog.FileName);
                    pictureBox1.Image = originalImage;
                    // Display file name in the label
                    lblImageName.Text = Path.GetFileName(openFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not load image: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // ==================== (Optional) Your existing Product & FoodOption classes ====================
        // (Keep these if needed elsewhere in your project)
        public class Product
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public string ImagePath { get; set; }
            public System.Collections.Generic.List<FoodOption> FoodOptions { get; set; } = new System.Collections.Generic.List<FoodOption>();
        }

        public class FoodOption
        {
            public string Name { get; set; }
            public decimal Price { get; set; }
        }
    }
}