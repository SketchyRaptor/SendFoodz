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