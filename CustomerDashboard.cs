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

        // Responsive layout constants
        private const float SidebarWidthPercent = 0.18f; // 18% of form width

        public CustomerDashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;


            // -------------------------------
            // 1. Apply responsive anchors & docks (programmatically)
            // -------------------------------

            // Sidebar panel (panel2) docks left, width set later
            panel2.Dock = DockStyle.Left;

            // Main content panel (panel1) fills the rest
            panel1.Dock = DockStyle.Fill;

            // Search panel: anchor top + left + right so it stretches
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Logout panel: anchor top + right
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // Main content area (panel3): anchor all sides
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Merchants FlowLayoutPanel: anchor all sides so it fills panel3
            flowMerchants.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Inner panels of sidebar: anchor left+right (so they stretch horizontally)
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Make search textbox fill its panel4
            searchBarTextBox.Dock = DockStyle.Fill;

            // Make welcome textbox only top+left anchored
            welcomeMessageTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // MerchantsLabel also top+left
            MerchantsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // -------------------------------
            // 2. Hook resize event and initial layout adjustment
            // -------------------------------
            this.Resize += CustomerDashboard_Resize;
            AdjustLayout();

            // -------------------------------
            // 3. Original data loading logic
            // -------------------------------
            LoadMerchantList();
            LoadMerchants("");
            searchBarTextBox.TextChanged += SearchBarTextBox_TextChanged;
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            txtUsername.Text = CurrentUsername;
            welcomeMessageTextBox.Text = $"Welcome back, {CurrentUsername}!";
        }

        // Adjust sidebar width and reposition inner elements on resize
        private void CustomerDashboard_Resize(object sender, EventArgs e)
        {
            AdjustLayout();
        }

        private void AdjustLayout()
        {
            // 1. Set sidebar width as percentage of form client width
            int newSidebarWidth = (int)(this.ClientSize.Width * SidebarWidthPercent);
            newSidebarWidth = Math.Max(200, Math.Min(400, newSidebarWidth)); // min 200, max 400
            panel2.Width = newSidebarWidth;

            // 2. Reposition inner panels of sidebar (center them with fixed margins)
            int innerMargin = 20;
            int innerWidth = panel2.Width - 2 * innerMargin;

            panel5.Width = innerWidth;
            panel5.Left = innerMargin;

            panel6.Width = innerWidth;
            panel6.Left = innerMargin;

            panel8.Width = innerWidth;
            panel8.Left = innerMargin;

            panel9.Width = innerWidth;
            panel9.Left = innerMargin;

            // 3. Adjust logout button panel position (top-right of panel1)
            if (panel7 != null && panel1 != null)
            {
                panel7.Left = panel1.Width - panel7.Width - 20;
            }

            // 4. Adjust search bar width to leave space for logout button
            if (panel4 != null && panel7 != null && panel1 != null)
            {
                int newSearchWidth = panel1.Width - panel7.Width - 40;
                if (newSearchWidth > 100) panel4.Width = newSearchWidth;
            }

            // 5. Refresh flow layout (optional)
            flowMerchants.PerformLayout();
        }

        // ---------- Original methods (unchanged) ----------
        private void LoadMerchantList()
        {
            allMerchantUsernames = accounts
                .Where(acc => acc.Role == "Merchant")
                .Select(acc => acc.Username)
                .ToList();
        }

        private void LoadMerchants(string searchText)
        {
            flowMerchants.Controls.Clear();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                foreach (string username in allMerchantUsernames)
                    AddMerchantButton(username);
                return;
            }

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

        private bool MerchantMatchesSearch(string merchantUsername, string searchText)
        {
            if (merchantUsername.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                return true;

            var products = MerchantProducts.GetProductsForMerchant(merchantUsername);
            return products.Any(p => p.Name.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0);
        }

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

            Image bgImage = MerchantSettingsStorage.GetBackgroundImage(username);
            if (bgImage != null)
            {
                merchantButton.BackgroundImage = bgImage;
                merchantButton.BackgroundImageLayout = ImageLayout.Stretch;
                merchantButton.FlatAppearance.BorderSize = 0;
                merchantButton.BackColor = Color.FromArgb(100, 0, 0, 0);
            }
            else
            {
                merchantButton.BackColor = Color.LightSteelBlue;
                merchantButton.ForeColor = Color.Black;
            }

            merchantButton.Click += MerchantButton_Click;
            flowMerchants.Controls.Add(merchantButton);
        }

        private void SearchBarTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadMerchants(searchBarTextBox.Text);
        }

        private void MerchantButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string merchantUsername = btn.Tag.ToString();

            OrderMenu orderMenu = new OrderMenu(merchantUsername);
            orderMenu.Show();
            this.Hide();
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            LoadMerchantList();
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