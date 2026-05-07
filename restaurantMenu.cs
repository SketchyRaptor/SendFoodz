using LogIn1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first
{
    public partial class restaurantMenu : Form
    {
        public restaurantMenu()
        {
            InitializeComponent();
        }

        private void backButtonResMenu_Click(object sender, EventArgs e)
        {
            this.Close();

            CustomerDashboard cdb = new CustomerDashboard();
            cdb.Show();

            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void restaurantMenu_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            // Clear existing controls
            flowLayoutPanel1.Controls.Clear();

            // TODO: Get products from your data source (database, JSON file, etc.)
            // For now, this is a placeholder
            
            // Example of how to load products:
            // List<Product> products = GetProductsFromMerchantProducts();
            // foreach (Product product in products)
            // {
            //     Panel productCard = CreateProductCard(product);
            //     flowLayoutPanel1.Controls.Add(productCard);
            // }

            // Placeholder message if no products exist
            Label noProducts = new Label();
            noProducts.Text = "No products added yet. Add products from Merchant Products.";
            noProducts.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic);
            noProducts.ForeColor = Color.Gray;
            noProducts.AutoSize = true;
            noProducts.Padding = new Padding(20);
            flowLayoutPanel1.Controls.Add(noProducts);
        }

        // Helper method to create product card
        private Panel CreateProductCard(string productName, string description, List<string> foodOptions, string imagePath)
        {
            Panel card = new Panel();
            card.BackColor = Color.White;
            card.BorderStyle = BorderStyle.FixedSingle;
            card.Width = 250;
            card.Height = 400;
            card.Margin = new Padding(10);

            // Product Image
            PictureBox pictureBox = new PictureBox();
            pictureBox.Width = 230;
            pictureBox.Height = 150;
            pictureBox.Location = new Point(10, 10);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            
            try
            {
                if (!string.IsNullOrEmpty(imagePath) && System.IO.File.Exists(imagePath))
                    pictureBox.ImageLocation = imagePath;
                else
                    pictureBox.BackColor = Color.LightGray;
            }
            catch
            {
                pictureBox.BackColor = Color.LightGray;
            }

            // Product Name
            Label lblName = new Label();
            lblName.Text = productName;
            lblName.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            lblName.Location = new Point(10, 165);
            lblName.Width = 230;
            lblName.AutoSize = false;
            lblName.Height = 30;

            // Description
            Label lblDesc = new Label();
            lblDesc.Text = description;
            lblDesc.Font = new Font("Microsoft Sans Serif", 8F);
            lblDesc.Location = new Point(10, 195);
            lblDesc.Width = 230;
            lblDesc.Height = 50;
            lblDesc.AutoSize = false;

            // Food Options
            Label lblOptions = new Label();
            string optionsText = "Options:\n";
            foreach (var option in foodOptions)
            {
                optionsText += "• " + option + "\n";
            }
            lblOptions.Text = optionsText;
            lblOptions.Font = new Font("Microsoft Sans Serif", 7F);
            lblOptions.Location = new Point(10, 245);
            lblOptions.Width = 230;
            lblOptions.Height = 140;
            lblOptions.AutoSize = false;

            card.Controls.Add(pictureBox);
            card.Controls.Add(lblName);
            card.Controls.Add(lblDesc);
            card.Controls.Add(lblOptions);

            return card;
        }
    }
}
