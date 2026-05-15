using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LogIn1
{
    public partial class Form1 : Form
    {
        public static List<Account> accounts = new List<Account>()
        {
            new Account { Username = "User123", Password = "123", Role = "Customer" }
        };

        public static string CurrentUsername { get; private set; }

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            this.Resize += Form1_Resize;
            CenterLoginPanel();  // initial centering
            this.MinimumSize = new Size(800, 600);  // prevent extreme shrinking
        }

        // Center the white panel inside the form on resize
        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterLoginPanel();
        }

        private void CenterLoginPanel()
        {
            if (panel1 == null) return;
            int x = (this.ClientSize.Width - panel1.Width) / 2;
            int y = (this.ClientSize.Height - panel1.Height) / 2;
            panel1.Location = new Point(Math.Max(0, x), Math.Max(0, y));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "admin" && password == "admin123")
            {
                MessageBox.Show("Admin login successful");
                CurrentUsername = username;
                AdminDashboard admin = new AdminDashboard();
                admin.Show();
                this.Hide();
                return;
            }

            foreach (var acc in accounts)
            {
                if (acc.Username == username && acc.Password == password)
                {
                    MessageBox.Show("Login successful");
                    CurrentUsername = username;
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
                    else
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
            public string Role { get; set; }
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

        public static List<string> riders = new List<string>()
        {
            "Rider001", "Rider002", "Rider003"
        };

        public static List<string> pendingOrders = new List<string>()
        {
            "Order #1001", "Order #1002", "Order #1003"
        };

        private void Form1_Load(object sender, EventArgs e) { }
    }
}