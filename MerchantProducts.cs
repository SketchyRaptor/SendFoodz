using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn1
{
    public partial class MerchantProducts : Form
    {
        private List<Product> products = new List<Product>();
        private string selectedProductImagePath = string.Empty;
        private int editingProductIndex = -1;

        public MerchantProducts()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeUI()
        {
            // Main Panel
            Panel mainPanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = Color.WhiteSmoke
            };

            // Top Panel for Product Management
            Panel topPanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 350,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Product Name
            Label nameLabel = new Label { Text = "Product Name:", Location = new Point(10, 10), AutoSize = true };
            TextBox nameTextBox = new TextBox { Name = "productNameTextBox", Location = new Point(150, 10), Width = 250 };
            topPanel.Controls.Add(nameLabel);
            topPanel.Controls.Add(nameTextBox);

            // Product Description
            Label descLabel = new Label { Text = "Description:", Location = new Point(10, 45), AutoSize = true };
            TextBox descTextBox = new TextBox { Name = "productDescTextBox", Location = new Point(150, 45), Width = 250, Height = 60, Multiline = true };
            topPanel.Controls.Add(descLabel);
            topPanel.Controls.Add(descTextBox);

            // Product Image Upload
            Label imageLabel = new Label { Text = "Product Image:", Location = new Point(10, 115), AutoSize = true };
            Button uploadImageButton = new Button { Text = "Upload Image", Location = new Point(150, 110), Width = 120, Name = "uploadImageBtn" };
            Label imagePath = new Label { Name = "imagePathLabel", Location = new Point(280, 115), AutoSize = true, Text = "No image selected" };
            uploadImageButton.Click += UploadImageButton_Click;
            topPanel.Controls.Add(imageLabel);
            topPanel.Controls.Add(uploadImageButton);
            topPanel.Controls.Add(imagePath);

            // Food Options Section
            Label foodOptionsLabel = new Label { Text = "Food Options:", Location = new Point(10, 150), Font = new Font("Arial", 10, FontStyle.Bold), AutoSize = true };
            topPanel.Controls.Add(foodOptionsLabel);

            // Food Option Item (Name & Price)
            Label foodNameLabel = new Label { Text = "Food Name:", Location = new Point(10, 180), AutoSize = true };
            TextBox foodNameTextBox = new TextBox { Name = "foodNameTextBox", Location = new Point(150, 180), Width = 250 };
            topPanel.Controls.Add(foodNameLabel);
            topPanel.Controls.Add(foodNameTextBox);

            Label priceLabel = new Label { Text = "Price:", Location = new Point(10, 215), AutoSize = true };
            TextBox priceTextBox = new TextBox { Name = "priceTextBox", Location = new Point(150, 215), Width = 250 };
            topPanel.Controls.Add(priceLabel);
            topPanel.Controls.Add(priceTextBox);

            // Add Food Option Button
            Button addFoodOptionButton = new Button { Text = "Add Food Option", Location = new Point(150, 250), Width = 130, Name = "addFoodOptionBtn" };
            addFoodOptionButton.Click += AddFoodOption_Click;
            topPanel.Controls.Add(addFoodOptionButton);

            // Add/Update Product Button
            Button addProductButton = new Button { Text = "Add Product", Location = new Point(150, 290), Width = 130, Name = "addProductBtn", BackColor = Color.LimeGreen, ForeColor = Color.White };
            addProductButton.Click += AddProduct_Click;
            topPanel.Controls.Add(addProductButton);

            // Clear Form Button
            Button clearButton = new Button { Text = "Clear Form", Location = new Point(290, 290), Width = 110, Name = "clearBtn" };
            clearButton.Click += ClearForm_Click;
            topPanel.Controls.Add(clearButton);

            mainPanel.Controls.Add(topPanel);

            // Products List Panel
            Panel listPanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = Color.WhiteSmoke
            };

            // DataGridView for Products
            DataGridView productsGrid = new DataGridView
            {
                Name = "productsGrid",
                Dock = DockStyle.Fill,
                AutoGenerateColumns = false,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = false
            };

            productsGrid.Columns.Add("ProductName", "Product Name");
            productsGrid.Columns.Add("Description", "Description");
            productsGrid.Columns.Add("FoodOptions", "Food Options");
            productsGrid.Columns.Add("ImagePath", "Image");

            DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn
            {
                Name = "EditColumn",
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };
            productsGrid.Columns.Add(editButtonColumn);

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
            {
                Name = "DeleteColumn",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };
            productsGrid.Columns.Add(deleteButtonColumn);

            productsGrid.CellClick += ProductsGrid_CellClick;

            listPanel.Controls.Add(productsGrid);
            mainPanel.Controls.Add(listPanel);

            this.Controls.Add(mainPanel);
        }

        private void UploadImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*",
                Title = "Select Product Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedProductImagePath = openFileDialog.FileName;
                Label imagePathLabel = this.Controls.Find("imagePathLabel", true).FirstOrDefault() as Label;
                if (imagePathLabel != null)
                {
                    imagePathLabel.Text = Path.GetFileName(selectedProductImagePath);
                }
            }
        }

        private void AddFoodOption_Click(object sender, EventArgs e)
        {
            TextBox foodNameTextBox = this.Controls.Find("foodNameTextBox", true).FirstOrDefault() as TextBox;
            TextBox priceTextBox = this.Controls.Find("priceTextBox", true).FirstOrDefault() as TextBox;

            if (string.IsNullOrWhiteSpace(foodNameTextBox?.Text))
            {
                MessageBox.Show("Please enter a food name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(priceTextBox?.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Create a new food option entry (you can display these in a separate list or directly in product)
            MessageBox.Show($"Food Option Added: {foodNameTextBox.Text} - ${price:F2}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear food option fields
            foodNameTextBox.Clear();
            priceTextBox.Clear();
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            TextBox nameTextBox = this.Controls.Find("productNameTextBox", true).FirstOrDefault() as TextBox;
            TextBox descTextBox = this.Controls.Find("productDescTextBox", true).FirstOrDefault() as TextBox;

            if (string.IsNullOrWhiteSpace(nameTextBox?.Text))
            {
                MessageBox.Show("Please enter a product name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var product = new Product
            {
                Name = nameTextBox.Text,
                Description = descTextBox?.Text ?? string.Empty,
                ImagePath = selectedProductImagePath,
                FoodOptions = new List<FoodOption> { /* Add collected food options */ }
            };

            if (editingProductIndex >= 0)
            {
                products[editingProductIndex] = product;
                editingProductIndex = -1;
            }
            else
            {
                products.Add(product);
            }

            RefreshProductsList();
            ClearForm_Click(null, null);
            MessageBox.Show("Product added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ProductsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 4) // Edit column
            {
                editingProductIndex = e.RowIndex;
                var product = products[e.RowIndex];

                TextBox nameTextBox = this.Controls.Find("productNameTextBox", true).FirstOrDefault() as TextBox;
                TextBox descTextBox = this.Controls.Find("productDescTextBox", true).FirstOrDefault() as TextBox;

                nameTextBox.Text = product.Name;
                descTextBox.Text = product.Description;
                selectedProductImagePath = product.ImagePath;

                Label imagePathLabel = this.Controls.Find("imagePathLabel", true).FirstOrDefault() as Label;
                imagePathLabel.Text = string.IsNullOrEmpty(product.ImagePath) ? "No image selected" : Path.GetFileName(product.ImagePath);
            }
            else if (e.ColumnIndex == 5) // Delete column
            {
                if (MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    products.RemoveAt(e.RowIndex);
                    RefreshProductsList();
                }
            }
        }

        private void RefreshProductsList()
        {
            DataGridView productsGrid = this.Controls.Find("productsGrid", true).FirstOrDefault() as DataGridView;
            if (productsGrid != null)
            {
                productsGrid.Rows.Clear();
                foreach (var product in products)
                {
                    productsGrid.Rows.Add(
                        product.Name,
                        product.Description,
                        string.Join(", ", product.FoodOptions.Select(f => $"{f.Name} (${f.Price:F2})")),
                        string.IsNullOrEmpty(product.ImagePath) ? "No Image" : "✓ Image",
                        "Edit",
                        "Delete"
                    );
                }
            }
        }

        private void ClearForm_Click(object sender, EventArgs e)
        {
            TextBox nameTextBox = this.Controls.Find("productNameTextBox", true).FirstOrDefault() as TextBox;
            TextBox descTextBox = this.Controls.Find("productDescTextBox", true).FirstOrDefault() as TextBox;
            TextBox foodNameTextBox = this.Controls.Find("foodNameTextBox", true).FirstOrDefault() as TextBox;
            TextBox priceTextBox = this.Controls.Find("priceTextBox", true).FirstOrDefault() as TextBox;
            Label imagePathLabel = this.Controls.Find("imagePathLabel", true).FirstOrDefault() as Label;

            nameTextBox.Clear();
            descTextBox.Clear();
            foodNameTextBox.Clear();
            priceTextBox.Clear();
            imagePathLabel.Text = "No image selected";
            selectedProductImagePath = string.Empty;
            editingProductIndex = -1;
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public List<FoodOption> FoodOptions { get; set; } = new List<FoodOption>();
    }

    public class FoodOption
    {
        public string Name { get; set; }
        public decimal Price { get; set; }


    }
}
