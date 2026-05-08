using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogIn1
{
    public partial class MerchantEditSale : Form
    {
        public MerchantEditSale()
        {
            InitializeComponent();
        }

        public static List<Restaurant> AllRestaurants = new List<Restaurant>();

        private void MerchantEditSale_Load(object sender, EventArgs e)
        {

        }

        private Image CopyImage(Image original)
        {
            if (original == null) return null;
            return new Bitmap(original);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Restaurant newRestaurant = new Restaurant();
            newRestaurant.Name = txtResoName.Text;
            newRestaurant.Logo = CopyImage(PhotoLogo.Image);
            newRestaurant.MenuItems = new List<MenuItem>();



            AddMenuItem(newRestaurant, txtName1.Text, txtPrice1.Text,txtQty1.Text, FoodOne);

            AllRestaurants.Add(newRestaurant);

            MessageBox.Show($"Restaurant '{newRestaurant.Name}' added successfully!",
                      "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MerchantTrial mtrial  = new MerchantTrial();
            mtrial.Show();
            this.Hide();
        }

        private void AddMenuItem(Restaurant restaurant, string name, string price, string qty,PictureBox pictureBox)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(price))
            {
                restaurant.MenuItems.Add(new MenuItem
                {
                    Name = name,
                    Price = price,
                    Quantity = qty,
                    Picture = CopyImage(pictureBox.Image)
                });
            }
        }

        private void ClearForm()
        {
            txtName1.Clear();
            PhotoLogo.Image = null;

            txtName1.Clear(); txtPrice1.Clear(); txtQty1.Clear();  FoodOne.Image = null;

        }

        private void btnLogo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load and copy the image immediately
                    using (Image tempImage = Image.FromFile(openFileDialog.FileName))
                    {
                        PhotoLogo.Image = CopyImage(tempImage);
                    }
                }
            }
        }

        private void btnPhoto1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Load and copy the image immediately
                    using (Image tempImage = Image.FromFile(openFileDialog.FileName))
                    {
                        FoodOne.Image = CopyImage(tempImage);
                    }
                }
            }
        }
    }
}
