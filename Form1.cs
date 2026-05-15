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
    public partial class Form1 : Form
    {
        public static List<Account> accounts = new List<Account>()
        {
            new Account { Username = "User123", Password = "123", Role = "Customer" }
        };

        // NEW: store the currently logged-in username (for any role)
        public static string CurrentUsername { get; private set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "admin123")
            {
                MessageBox.Show("Admin login succesfull");
                CurrentUsername = username;  // optional for admin
                AdminDashboard admin = new AdminDashboard();
                admin.Show();
                this.Hide();
                return;
            }

            foreach (var acc in accounts)
            {
                if (acc.Username == username && acc.Password == password)
                {
                    MessageBox.Show("login succesfull");
                    CurrentUsername = username;  // Store the logged in usernames
                    // Check user role and navigate to appropriate dashboard
                    if (acc.Role == "Merchant")
                    {
                       MerchantDashBoard merchantDashBoard = new MerchantDashBoard();
                        merchantDashBoard.Show();
                    }
                    else if (acc.Role == "Rider")
                    {
                        RiderDashboard riderDashboard = new RiderDashboard();
                        riderDashboard.Show();
                    }
                    else // Customer
                    {
                        CustomerDashboard customerDashboard = new CustomerDashboard();
                        customerDashboard.Show();
                    }

                    this.Hide();
                    return;
                }
            }

            MessageBox.Show("Invalid username or password");
        }

        public class Account
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Role { get; set; } // "Customer", "Merchant", or "Rider"
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signupForm = new SignUp();
            signupForm.Show();

            this.Hide();
        }

        //load riders
        public static List<string> riders = new List<string>()
        {
            "Rider001",
            "Rider002",
            "Rider003"
        };

        //load orders
        public static List<string> pendingOrders = new List<string>()
        {
            "Order #1001",
            "Order #1002",
            "Order #1003"
        };

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
