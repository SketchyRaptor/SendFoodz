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
    public partial class MenuTrial : Form
    {
        public MenuTrial(string[] names, string[] prices, string[] quantity, Image[] images)
        {
            InitializeComponent();

            // DEBUG: Check if data was received
            MessageBox.Show($"Received in Menu: Name={names[0]}, Price={prices[0]}, Quantity={quantity[0]}");

            lblName1.Text = names[0];
            lblPrice1.Text = prices[0];
            lblQty1.Text = quantity[0];    
            FoodOne.Image = images[0];
        }

        public MenuTrial(Restaurant restaurant)
        {
            InitializeComponent();

            // Display restaurant name at the top (if you have a label for it)
            // lblRestaurantName.Text = restaurant.Name;

            // Display menu items from the restaurant
            DisplayAllMenuItems(restaurant);
        }

        private void DisplayAllMenuItems(Restaurant restaurant)
        {
            // Loop through all menu items (up to 6 items)
            for (int i = 0; i < restaurant.MenuItems.Count && i < 6; i++)
            {
                int number = i + 1;  // 1, 2, 3, 4, 5, 6
                MenuItem item = restaurant.MenuItems[i];

                // Find the controls by name
                Label lblName = this.Controls.Find($"lblName{number}", true).FirstOrDefault() as Label;
                Label lblPrice = this.Controls.Find($"lblPrice{number}", true).FirstOrDefault() as Label;
                Label lblQuantity = this.Controls.Find($"lblQty{number}", true).FirstOrDefault() as Label;
                PictureBox picBox = this.Controls.Find($"Food{GetWordNumber(number)}", true).FirstOrDefault() as PictureBox;

                if (lblName != null) lblName.Text = item.Name;
                if (lblPrice != null) lblPrice.Text = item.Price;
                if(lblQuantity != null) lblQuantity.Text = item.Quantity;
                if (picBox != null && item.Picture != null) picBox.Image = item.Picture;
            }
        }

        private string GetWordNumber(int number)
        {
            switch (number)
            {
                case 1: return "One";
                case 2: return "Two";
                case 3: return "Three";
                case 4: return "Four";
                case 5: return "Five";
                case 6: return "Six";
                default: return "";
            }
        }
        private Image CopyImage(Image original)
        {
            if (original == null) return null;
            return new Bitmap(original);
        }

        private void DisplayProduct(int number, string name, string price, string quantity,Image image)
        {
            // Find controls by name pattern
            Label lblName = this.Controls.Find($"lblName{number}", true).FirstOrDefault() as Label;
            Label lblPrice = this.Controls.Find($"lblPrice{number}", true).FirstOrDefault() as Label;
            Label lblQuantity = this.Controls.Find($"lblQuantity{number}", true).FirstOrDefault() as Label;
            PictureBox picBox = this.Controls.Find($"pictureBox{number}", true).FirstOrDefault() as PictureBox;

            if (lblName != null) lblName.Text = name;
            if (lblPrice != null) lblPrice.Text = price;
            if (lblQuantity != null) lblQuantity.Text = quantity;
            if (picBox != null && image != null) picBox.Image = image;
        }



        private void MenuTrial_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblPrice1_Click(object sender, EventArgs e)
        {

        }
    }
}
