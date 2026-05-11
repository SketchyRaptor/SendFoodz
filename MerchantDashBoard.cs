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
    public partial class MerchantDashBoard : Form
    {
        public MerchantDashBoard()
        {
            InitializeComponent();
            LoadCurrentBackground();
        }
        private void LoadCurrentBackground()
        {
            // Load existing background image if any
            Image bg = MerchantSettingsStorage.GetBackgroundImage(Form1.CurrentUsername);
            if (bg != null)
                picBackgroundPreview.Image = bg;
        }

        private void btnUploadBackground_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Select Background Image for Your Shop";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image newImage = Image.FromFile(ofd.FileName);
                        MerchantSettingsStorage.SetBackgroundImage(Form1.CurrentUsername, newImage);
                        picBackgroundPreview.Image = newImage;
                        MessageBox.Show("Background image updated successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message, "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnEditMenu_Click(object sender, EventArgs e)
        {
            // Navigate to MerchantProducts form
            MerchantProducts merchantProducts = new MerchantProducts(Form1.CurrentUsername);
            merchantProducts.Show();

            this.Hide();
        }

        private void btnSalesHistory_Click(object sender, EventArgs e)
        {
            // Show sales history form
            // You can create a new form called "SalesHistory" for this
            MessageBox.Show("Sales History feature coming soon!\n\nHere you will be able to view all sales data for your products.",
                "Sales History", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Uncomment below when you create the SalesHistory form
            // SalesHistory salesHistory = new SalesHistory();
            // salesHistory.Show();
            // this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Return to login form
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Close();
        }
    }
}