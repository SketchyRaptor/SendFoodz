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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
          
            this.WindowState = FormWindowState.Maximized;

            OrderStorage.OrderAdded += OnOrderChanged;
            OrderStorage.OrderUpdated += OnOrderChanged;
        }
        private void LoadPendingOrders()
        {
            if (dgvOrders == null) return;

            dgvOrders.Columns.Clear();
            dgvOrders.Rows.Clear();

            // Add columns - MUST match the columns you add rows to
            dgvOrders.Columns.Add("OrderID", "Order ID");
            dgvOrders.Columns.Add("Customer", "Customer Name");
            dgvOrders.Columns.Add("Merchant", "Merchant Name");
            dgvOrders.Columns.Add("Total", "Total Amount");
            dgvOrders.Columns.Add("Stage", "Order Stage");  // ← This creates the "Stage" column
            dgvOrders.Columns.Add("Rider", "Assigned Rider");
            dgvOrders.Columns.Add("Address", "Delivery Address");

            // FIXED: Filter orders that are NOT Delivered (using Stage, not StockId)
            var pendingOrders = OrderStorage.AllOrders
                .Where(o => o.Stage != "Delivered")  // ← Changed from StockId to Stage, and != instead of ==
                .OrderByDescending(o => o.OrderId)
                .ToList();

            if (pendingOrders.Count > 0)
            {
                foreach (var order in pendingOrders)
                {
                    dgvOrders.Rows.Add(
                        $"#{order.OrderId}",
                        order.CustomerName,
                        order.MerchantName,
                        $"₱{order.Total:F2}",  // ← Fixed: removed # symbol, added ₱
                        order.Stage,            // ← Fixed: changed from order.Store to order.Stage
                        order.Rider ?? "Not Assigned",
                        order.Address ?? "No address"
                    );
                }

                // Color code rows based on stage - ONLY after rows are added
                foreach (DataGridViewRow row in dgvOrders.Rows)
                {
                    if (row.Cells["Stage"].Value != null)  // ← Add null check
                    {
                        string stage = row.Cells["Stage"].Value.ToString();
                        switch (stage)
                        {
                            case "Pending":
                                row.DefaultCellStyle.BackColor = Color.LightYellow;
                                break;
                            case "Preparing":
                                row.DefaultCellStyle.BackColor = Color.LightBlue;
                                break;
                            case "On the Way":
                                row.DefaultCellStyle.BackColor = Color.LightGreen;
                                break;
                            case "Delivered":
                                row.DefaultCellStyle.BackColor = Color.LightGray;
                                break;
                        }
                    }
                }
            }
            else
            {
                dgvOrders.Rows.Add("No pending orders", "", "", "", "", "", "");
                dgvOrders.Enabled = false;
            }


        }

        private void OnOrderChanged()
        {
            // Refresh when orders change (delivered, new orders, etc.)
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(LoadPendingOrders));
            }
            else
            {
                LoadPendingOrders();
            }
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadAllData();
        }

        private void LoadAllData()
        {
            LoadUsers();
            LoadRiders();
            LoadMerchants();
            LoadOrders();
            LoadPendingOrders();
        }
        private void LoadUsers()
        {
            if (dgvUsers == null) return;

            dgvUsers.Columns.Clear();
            dgvUsers.Rows.Clear();

            // Add columns
            dgvUsers.Columns.Add("Username", "Username");
            dgvUsers.Columns.Add("Role", "Role");

            foreach (var acc in Form1.accounts)
            {
                if (acc.Role == "Customer")
                {
                    dgvUsers.Rows.Add(acc.Username, acc.Role);
                }
            }
        }

        private void LoadMerchants()
        {
            if (dgvMerchant == null) return;

            dgvMerchant.Columns.Clear();
            dgvMerchant.Rows.Clear();

            dgvMerchant.Columns.Add("Username", "Merchant Name");
            dgvMerchant.Columns.Add("Role", "Role");
            dgvMerchant.Columns.Add("Status", "Status");

            foreach (var acc in Form1.accounts)
            {
                if (acc.Role == "Merchant")
                {
                    dgvMerchant.Rows.Add(acc.Username, acc.Role, "Active");
                }
            }
        }
        private void LoadRiders()
        {
            if (dgvRiders == null) return;

            dgvRiders.Columns.Clear();
            dgvRiders.Rows.Clear();

            dgvRiders.Columns.Add("Username", "Rider Name");
            dgvRiders.Columns.Add("Role", "Role");

            foreach (var acc in Form1.accounts)
            {
                if (acc.Role == "Rider")
                {
                    dgvRiders.Rows.Add(acc.Username, acc.Role);
                }
            }
        }

       
        private void LoadOrders()
        {
            if (dgvOrders == null) return;

            dgvOrders.Columns.Clear();
            dgvOrders.Rows.Clear();

            // Add meaningful columns
            dgvOrders.Columns.Add("OrderID", "Order ID");
            dgvOrders.Columns.Add("Customer", "Customer Name");
            dgvOrders.Columns.Add("Merchant", "Merchant Name");
            dgvOrders.Columns.Add("Total", "Total Amount");
            dgvOrders.Columns.Add("Stage", "Order Stage");
            dgvOrders.Columns.Add("Rider", "Assigned Rider");
            dgvOrders.Columns.Add("Date", "Order Date");

            // Load REAL orders from OrderStorage
            if (OrderStorage.AllOrders != null && OrderStorage.AllOrders.Count > 0)
            {
                foreach (var order in OrderStorage.AllOrders)
                {
                    dgvOrders.Rows.Add(
                        $"#{order.OrderId}",           // Order ID
                        order.CustomerName,             // Customer name
                        order.MerchantName,             // Merchant name
                        $"₱{order.Total:F2}",          // Total amount
                        order.Stage,                    // Pending/Preparing/On the Way/Delivered
                        order.Rider ?? "Not Assigned",  // Rider (or "Not Assigned" if null)
                        DateTime.Now.ToString("MM/dd/yyyy") // You may need to add Date property to Order class
                    );
                }
            }
            else
            {
                // Show message when no orders exist
                dgvOrders.Rows.Add("No orders found", "", "", "", "", "");
                dgvOrders.Enabled = false;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllData();
            MessageBox.Show("Dashboard updated successfully!", "Refresh",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AdminDashboard_Load_1(object sender, EventArgs e)
        {

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblUsers_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvMerchant_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 lala = new Form1();
            lala.Show();
            this.Hide();
        }
    }
}
