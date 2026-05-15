using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static LogIn1.Form1;

namespace LogIn1
{
    public partial class CustomerDashboard : Form
    {
        // Store all merchant usernames for filtering
        private List<string> allMerchantUsernames;

        public CustomerDashboard()
        {
            InitializeComponent();
            LoadMerchantList();
            LoadMerchants(""); // load all initially
            searchBarTextBox.TextChanged += SearchBarTextBox_TextChanged;
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            txtUsername.Text = CurrentUsername;
            welcomeMessageTextBox.Text = $"Welcome back, {CurrentUsername}!";
        }

        // Load all merchant usernames from the global accounts list
        private void LoadMerchantList()
        {
            allMerchantUsernames = accounts
                .Where(acc => acc.Role == "Merchant")
                .Select(acc => acc.Username)
                .ToList();
        }

        // Display merchants whose username or product names contain the search text
        private void LoadMerchants(string searchText)
        {
            flowMerchants.Controls.Clear();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                // Show all merchants
                foreach (string username in allMerchantUsernames)
                    AddMerchantButton(username);
                return;
            }

            // Filter merchants
            var filtered = allMerchantUsernames
                .Where(username => MerchantMatchesSearch(username, searchText))
                .ToList();

            if (filtered.Count == 0)
            {
                Label noResult = new Label
                {
                    Text = "No matching merchants or products found.",
                    AutoSize = true,
                    Font = new Font("Segoe UI", 12F),
                    ForeColor = Color.Gray
                };
                flowMerchants.Controls.Add(noResult);
                return;
            }

            foreach (string username in filtered)
                AddMerchantButton(username);
        }

        // Check if a merchant matches the search text (username or any product name)
        private bool MerchantMatchesSearch(string merchantUsername, string searchText)
        {
            // Case-insensitive check
            if (merchantUsername.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                return true;

            // Get merchant's products
            var products = MerchantProducts.GetProductsForMerchant(merchantUsername);
            return products.Any(p => p.Name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        // Helper to create a merchant button
        private void AddMerchantButton(string username)
        {
            Button merchantButton = new Button
            {
                Text = username,
                Tag = username,
                Width = 200,
                Height = 80,
                BackColor = Color.LightSteelBlue,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Margin = new Padding(10),
                 ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter
            };
            // Try to get merchant's background image
            Image bgImage = MerchantSettingsStorage.GetBackgroundImage(username);
            if (bgImage != null)
            {
                merchantButton.BackgroundImage = bgImage;
                merchantButton.BackgroundImageLayout = ImageLayout.Stretch;
                // Make text readable by adding a semi-transparent overlay
                merchantButton.FlatAppearance.BorderSize = 0;
                // Optional: darken text background
                merchantButton.BackColor = Color.FromArgb(100, 0, 0, 0);  // semi-transparent black
            }
            else
            {
                merchantButton.BackColor = Color.LightSteelBlue;
                merchantButton.ForeColor = Color.Black;
            }

            merchantButton.Click += MerchantButton_Click;
            flowMerchants.Controls.Add(merchantButton);
        }

        // Handle search text changes
        private void SearchBarTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadMerchants(searchBarTextBox.Text);
        }

        // When a merchant button is clicked, open OrderMenu for that merchant
        private void MerchantButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string merchantUsername = btn.Tag.ToString();

            OrderMenu orderMenu = new OrderMenu(merchantUsername);
            orderMenu.Show();
            this.Hide();
        }

        // Refresh merchant list when form is activated (e.g., after new signup)
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            LoadMerchantList();       // reload in case new merchant added
            LoadMerchants(searchBarTextBox.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewOrder viewOrder = new ViewOrder();
            viewOrder.Show();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Close();

        }
    }
}