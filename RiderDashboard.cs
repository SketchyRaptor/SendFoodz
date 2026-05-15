using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace LogIn1
{
    public partial class RiderDashboard : Form
    {
        private string currentRider;

        public RiderDashboard()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            currentRider = Form1.CurrentUsername;
            // Subscribe to new orders event
            OrderStorage.OrderAdded += RefreshOrders;
            // Initial load
            RefreshOrders();
        }

        private void RefreshOrders()
        {
            // Clear all flow panels
            flowLayoutNewOrders.Controls.Clear();
            flowLayoutCurrentOrders.Controls.Clear();
            flowLayoutCompletedOrders.Controls.Clear();

            // Get ALL orders
            var allOrders = OrderStorage.AllOrders;

            int newCount = 0, inProgressCount = 0, completedCount = 0;
            decimal totalEarnings = 0;

            // 1. New Orders: Pending and unassigned (Rider == null)
            var unassignedPending = allOrders.Where(o => o.Stage == "Pending" && o.Rider == null).ToList();
            foreach (var order in unassignedPending)
            {
                newCount++;
                AddOrderToPanel(order, flowLayoutNewOrders, showAcceptReject: true);
            }

            // 2. Current Orders: Preparing/OnTheWay AND assigned to this rider
            var myCurrent = allOrders.Where(o => (o.Stage == "Preparing" || o.Stage == "On the Way") && o.Rider == currentRider).ToList();
            foreach (var order in myCurrent)
            {
                inProgressCount++;
                AddOrderToPanel(order, flowLayoutCurrentOrders, showAcceptReject: false);
            }

            // 3. Completed Orders: Delivered AND assigned to this rider
            var myCompleted = allOrders.Where(o => o.Stage == "Delivered" && o.Rider == currentRider).ToList();
            foreach (var order in myCompleted)
            {
                completedCount++;
                totalEarnings += order.Total;
                AddOrderToPanel(order, flowLayoutCompletedOrders, showAcceptReject: false);
            }

            // Update labels
            lblNewOrders.Text = newCount.ToString();
            lblInProgress.Text = inProgressCount.ToString();
            lblCompleted.Text = completedCount.ToString();
            lblEarnings.Text = totalEarnings.ToString("F2");
        }

        private void AddOrderToPanel(Order order, FlowLayoutPanel targetPanel, bool showAcceptReject)
        {
            Panel orderPanel = new Panel
            {
                Width = targetPanel.Width - 25,
                Height = 144,
                Margin = new Padding(3),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.WhiteSmoke
            };

            // Picture placeholder
            PictureBox pic = new PictureBox
            {
                Location = new Point(10, 10),
                Size = new Size(100, 100),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Properties.Resources.ChatGPT_Image_Apr_17__2026__02_55_18_PM
            };
            orderPanel.Controls.Add(pic);

            // Order ID
            Label lblCode = new Label
            {
                Text = $"Order #{order.OrderId}",
                Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold),
                Location = new Point(130, 10),
                AutoSize = true
            };
            orderPanel.Controls.Add(lblCode);

            // Customer name
            Label lblCustomer = new Label
            {
                Text = $"Customer: {order.CustomerName}",
                Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular),
                Location = new Point(130, 35),
                AutoSize = true
            };
            orderPanel.Controls.Add(lblCustomer);

            // Items summary
            string items = string.Join(", ", order.ItemsSummary);
            if (items.Length > 50) items = items.Substring(0, 47) + "...";
            Label lblItems = new Label
            {
                Text = items,
                Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular),
                Location = new Point(130, 60),
                AutoSize = true,
                MaximumSize = new Size(300, 0)
            };
            orderPanel.Controls.Add(lblItems);

            // Total price
            Label lblPrice = new Label
            {
                Text = $"₱ {order.Total:F2}",
                Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold),
                ForeColor = Color.DarkGreen,
                Location = new Point(130, 85),
                AutoSize = true
            };
            orderPanel.Controls.Add(lblPrice);

            if (showAcceptReject)
            {
                Button btnAccept = new Button
                {
                    Text = "Accept",
                    BackColor = Color.Lime,
                    FlatStyle = FlatStyle.Flat,
                    Location = new Point(800, 30),
                    Size = new Size(100, 40),
                    Tag = order
                };
                btnAccept.Click += BtnAccept_Click;
                orderPanel.Controls.Add(btnAccept);

                Button btnReject = new Button
                {
                    Text = "Reject",
                    BackColor = Color.Red,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Location = new Point(800, 80),
                    Size = new Size(100, 40),
                    Tag = order
                };
                btnReject.Click += BtnReject_Click;
                orderPanel.Controls.Add(btnReject);
            }
            else
            {
                Label lblStage = new Label
                {
                    Text = order.Stage,
                    Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold),
                    ForeColor = order.Stage == "Delivered" ? Color.Green : Color.Orange,
                    Location = new Point(800, 50),
                    AutoSize = true
                };
                orderPanel.Controls.Add(lblStage);
            }

            targetPanel.Controls.Add(orderPanel);
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Order order = btn.Tag as Order;
            if (order != null && order.Stage == "Pending" && order.Rider == null)
            {
                order.Rider = currentRider;      // assign to this rider
                order.Stage = "Preparing";
                order.HistoryLog.Add($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - Order accepted by rider {currentRider}");
                RefreshOrders();
            }
        }

        private void BtnReject_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            Order order = btn.Tag as Order;
            if (order != null)
            {
                if (MessageBox.Show($"Reject order #{order.OrderId}? This will remove the order.", "Confirm Reject",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    OrderStorage.AllOrders.Remove(order);
                    RefreshOrders();
                }
            }
        }

        // Resize adjustment
        /*
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            int maxWidth = 800; // Set your desired maximum width

            foreach (Control ctrl in flowLayoutNewOrders.Controls)
                if (ctrl is Panel p)
                    p.Width = Math.Min(flowLayoutNewOrders.Width - 30, maxWidth);

            foreach (Control ctrl in flowLayoutCurrentOrders.Controls)
                if (ctrl is Panel p)
                    p.Width = Math.Min(flowLayoutCurrentOrders.Width - 30, maxWidth);

            foreach (Control ctrl in flowLayoutCompletedOrders.Controls)
                if (ctrl is Panel p)
                    p.Width = Math.Min(flowLayoutCompletedOrders.Width - 30, maxWidth);
        }
        */
        // Existing empty handlers
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void RiderDashboard_Load(object sender, EventArgs e) { }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}