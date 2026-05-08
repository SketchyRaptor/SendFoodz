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
    public partial class restaurantMenuTrial : Form
    {
        public restaurantMenuTrial()
        {
            InitializeComponent();
            LoadRestaurantLogos();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (MerchantEditSale.AllRestaurants.Count >= 1)
            {
                MenuTrial mo = new MenuTrial(MerchantEditSale.AllRestaurants[0]);
                mo.Show();
                this.Hide();
            }
        }

        private void restaurantMenuTrial_Load(object sender, EventArgs e)
        {

        }

        private void LoadRestaurantLogos()
        {
            // Assuming you have 3 restaurant cards (based on your screenshot)
            // And you have PictureBox controls named: pictureBox1, pictureBox2, pictureBox3
            MessageBox.Show($"Number of restaurants: {MerchantEditSale.AllRestaurants.Count}");
            if (MerchantEditSale.AllRestaurants.Count >= 1)
            {
                MessageBox.Show($"Logo found for {MerchantEditSale.AllRestaurants[0].Name}");
                pictureLogo.Image = MerchantEditSale.AllRestaurants[0].Logo;
                lblRestoName.Text = MerchantEditSale.AllRestaurants[0].Name;
            }

           
        }
    }
}
