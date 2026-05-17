using System;
using System.Windows.Forms;
using static LogIn1.Form1;

namespace LogIn1
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.Resize += SignUp_Resize;
            CenterPanel(); // initial centering

            txtUsername.KeyPress += TxtUsername_KeyPress;
        }

        private void SignUp_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void TxtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow letters (A-Z, a-z), backspace, and space
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true; // This prevents the character from being entered
            }
        }

        private void CenterPanel()
        {
            if (panel1 == null) return;
            // Keep panel1 at its original fixed size (set in designer)
            panel1.Left = (this.ClientSize.Width - panel1.Width) / 2;
            panel1.Top = (this.ClientSize.Height - panel1.Height) / 2;
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

            if (!System.Text.RegularExpressions.Regex.IsMatch(username, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Username can only contain letters and spaces", "Invalid Username",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

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

            MessageBox.Show("Account created successfully");

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

        private void btnBackToLogin_Click_1(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Hide();
        }

        private void SignUp_Load_1(object sender, EventArgs e) { }
    }
}