using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LogIn1
{
    public partial class MerchantProducts : Form
    {
        private static Dictionary<string, List<ProductItem>> merchantProducts = new Dictionary<string, List<ProductItem>>();
        public static event Action<string, ProductItem> ProductAdded;
        private string loggedInMerchant;

        public static List<ProductItem> GetProductsForMerchant(string merchantUsername)
        {
            if (!merchantProducts.ContainsKey(merchantUsername))
                merchantProducts[merchantUsername] = new List<ProductItem>();
            return merchantProducts[merchantUsername];
        }

        public MerchantProducts(string merchantUsername)
        {
            InitializeComponent();
            // Open in full screen
            this.WindowState = FormWindowState.Maximized;
            loggedInMerchant = merchantUsername;

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

            // Make input controls stretch horizontally inside the group box
            this.Resize += MerchantProducts_Resize;
            AdjustInputControls();

            LoadProductsForCurrentMerchant();
        }

        private void MerchantProducts_Resize(object sender, EventArgs e)
        {
            AdjustInputControls();
        }

        private void AdjustInputControls()
        {
            if (grpProductInfo == null || txtProductName == null) return;

            int padding = 20;
            int width = grpProductInfo.ClientSize.Width - 2 * padding;
            if (width < 100) width = 100;

            // Make textboxes and picturebox stretch horizontally
            txtProductName.Width = width;
            txtPrice.Width = width;
            txtQuantity.Width = width;
            pictureBox1.Width = width / 2;
            btnSelectImage.Left = pictureBox1.Right + 10;
            btnSelectImage.Width = width - pictureBox1.Width - 20;
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
            MerchantDashBoard dashboard = new MerchantDashBoard();
            dashboard.Show();
            this.Close();
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

    public static class MerchantSettingsStorage
    {
        private static Dictionary<string, string> merchantBackgrounds = new Dictionary<string, string>();
        private static string backgroundsFolder = Path.Combine(Application.StartupPath, "MerchantBackgrounds");

        static MerchantSettingsStorage()
        {
            if (!Directory.Exists(backgroundsFolder))
                Directory.CreateDirectory(backgroundsFolder);
        }

        public static void SetBackgroundImage(string merchantUsername, Image image)
        {
            if (image == null)
            {
                if (merchantBackgrounds.ContainsKey(merchantUsername))
                    merchantBackgrounds.Remove(merchantUsername);
                string filePath = Path.Combine(backgroundsFolder, merchantUsername + ".jpg");
                if (File.Exists(filePath))
                    File.Delete(filePath);
                return;
            }

            string savePath = Path.Combine(backgroundsFolder, merchantUsername + ".jpg");
            image.Save(savePath, System.Drawing.Imaging.ImageFormat.Jpeg);
            merchantBackgrounds[merchantUsername] = savePath;
        }

        public static Image GetBackgroundImage(string merchantUsername)
        {
            if (merchantBackgrounds.ContainsKey(merchantUsername))
            {
                try
                {
                    return Image.FromFile(merchantBackgrounds[merchantUsername]);
                }
                catch { }
            }
            string filePath = Path.Combine(backgroundsFolder, merchantUsername + ".jpg");
            if (File.Exists(filePath))
            {
                try
                {
                    Image img = Image.FromFile(filePath);
                    merchantBackgrounds[merchantUsername] = filePath;
                    return img;
                }
                catch { }
            }
            return null;
        }
    }
}