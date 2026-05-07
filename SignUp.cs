using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LogIn1.Form1;

namespace LogIn1
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string role = "";
            if (rbCustomer.Checked)
                role = "Customer";
            else if (rbMerchant.Checked)
                role = "Merchant";
            else if (rbRider.Checked)
                role = "Rider";


            if (username == "" || password == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            // check duplicate username
            foreach (var acc in Form1.accounts)
            {
                if (acc.Username == username)
                {
                    MessageBox.Show("Username already exists");
                    return;
                }
            }

            Form1.accounts.Add(new Account
            {
                Username = username,
                Password = password,
                Role = role
            });

            MessageBox.Show("account created succesfully");

            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool show = chkShowPassword.Checked;

            txtPassword.UseSystemPasswordChar = !show;
            txtConfirmPassword.UseSystemPasswordChar = !show;
        }



        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void SignUp_Load_1(object sender, EventArgs e)
        {

        }

        private void btnBackToLogin_Click_1(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }
    }
}
