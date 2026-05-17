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
                Height = 220, // Increased height to accommodate buttons better
                Margin = new Padding(3),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.WhiteSmoke
            };

            // Add hover effect
            orderPanel.MouseEnter += (s, e) => orderPanel.BackColor = Color.FromArgb(240, 240, 240);
            orderPanel.MouseLeave += (s, e) => orderPanel.BackColor = Color.WhiteSmoke;

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
                Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold),
                Location = new Point(130, 10),
                AutoSize = true
            };
            orderPanel.Controls.Add(lblCode);

            // Customer name
            Label lblCustomer = new Label
            {
                Text = $"Customer: {order.CustomerName}",
                Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular),
                Location = new Point(130, 35),
                AutoSize = true
            };
            orderPanel.Controls.Add(lblCustomer);

            Label lblAddress = new Label
            {
                Text = $"📍 {order.Address}",
                Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular),
                Location = new Point(130, 55),
                AutoSize = true,
                MaximumSize = new Size(350, 45),
                ForeColor = Color.FromArgb(100, 100, 100)
            };
            orderPanel.Controls.Add(lblAddress);

            // Items summary
            string items = string.Join(", ", order.ItemsSummary);
            if (items.Length > 50) items = items.Substring(0, 47) + "...";
            Label lblItems = new Label
            {
                Text = items,
                Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular),
                Location = new Point(130, 110),
                AutoSize = true,
                MaximumSize = new Size(300, 0)
            };
            orderPanel.Controls.Add(lblItems);

            // Total price
            Label lblPrice = new Label
            {
                Text = $"₱ {order.Total:F2}",
                Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold),
                ForeColor = Color.DarkGreen,
                Location = new Point(130, 135),
                AutoSize = true
            };
            orderPanel.Controls.Add(lblPrice);

            if (showAcceptReject)
            {
                // Accept button with hover effects
                Button btnAccept = new Button
                {
                    Text = "ACCEPT",
                    BackColor = Color.FromArgb(76, 175, 80),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold),
                    Location = new Point(orderPanel.Width - 130, 30),
                    Size = new Size(110, 40),
                    Tag = order,
                    Cursor = Cursors.Hand
                };
                btnAccept.FlatAppearance.BorderSize = 0;
                btnAccept.MouseEnter += (s, e) => btnAccept.BackColor = Color.FromArgb(56, 142, 60);
                btnAccept.MouseLeave += (s, e) => btnAccept.BackColor = Color.FromArgb(76, 175, 80);
                btnAccept.Click += BtnAccept_Click;
                orderPanel.Controls.Add(btnAccept);

                // Reject button with hover effects
                Button btnReject = new Button
                {
                    Text = "REJECT",
                    BackColor = Color.FromArgb(244, 67, 54),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold),
                    Location = new Point(orderPanel.Width - 130, 80),
                    Size = new Size(110, 40),
                    Tag = order,
                    Cursor = Cursors.Hand
                };
                btnReject.FlatAppearance.BorderSize = 0;
                btnReject.MouseEnter += (s, e) => btnReject.BackColor = Color.FromArgb(211, 47, 47);
                btnReject.MouseLeave += (s, e) => btnReject.BackColor = Color.FromArgb(244, 67, 54);
                btnReject.Click += BtnReject_Click;
                orderPanel.Controls.Add(btnReject);
            }
            else
            {
                // Show status with colored badge
                Panel statusBadge = new Panel
                {
                    Location = new Point(orderPanel.Width - 130, 15),
                    Size = new Size(110, 30),
                    BackColor = order.Stage == "Preparing" ? Color.FromArgb(255, 152, 0) :
                               order.Stage == "On the Way" ? Color.FromArgb(33, 150, 243) :
                               Color.FromArgb(76, 175, 80)
                };

                Label lblStage = new Label
                {
                    Text = order.Stage.ToUpper(),
                    Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold),
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    AutoSize = false
                };
                statusBadge.Controls.Add(lblStage);
                orderPanel.Controls.Add(statusBadge);

                // Add action buttons based on stage
                if (order.Stage == "Preparing")
                {
                    Button btnOnWay = new Button
                    {
                        Text = "START DELIVERY",
                        BackColor = Color.FromArgb(33, 150, 243),
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold),
                        Location = new Point(orderPanel.Width - 130, 55),
                        Size = new Size(110, 40),
                        Tag = order,
                        Cursor = Cursors.Hand
                    };
                    btnOnWay.FlatAppearance.BorderSize = 0;
                    btnOnWay.MouseEnter += (s, e) => btnOnWay.BackColor = Color.FromArgb(25, 118, 210);
                    btnOnWay.MouseLeave += (s, e) => btnOnWay.BackColor = Color.FromArgb(33, 150, 243);
                    btnOnWay.Click += (s, e) =>
                    {
                        if (MessageBox.Show($"Mark order #{order.OrderId} as 'On the Way'?", "Confirm",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            order.Stage = "On the Way";
                            order.HistoryLog.Add($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - Order is on the way by rider {currentRider}");
                            RefreshOrders();
                            OrderStorage.UpdateOrder(); // Add this line
                        }
                    };
                    orderPanel.Controls.Add(btnOnWay);
                }
                else if (order.Stage == "On the Way")
                {
                    Button btnDelivered = new Button
                    {
                        Text = "COMPLETE ORDER",
                        BackColor = Color.FromArgb(76, 175, 80),
                        ForeColor = Color.White,
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold),
                        Location = new Point(orderPanel.Width - 130, 55),
                        Size = new Size(110, 40),
                        Tag = order,
                        Cursor = Cursors.Hand
                    };
                    btnDelivered.FlatAppearance.BorderSize = 0;
                    btnDelivered.MouseEnter += (s, e) => btnDelivered.BackColor = Color.FromArgb(56, 142, 60);
                    btnDelivered.MouseLeave += (s, e) => btnDelivered.BackColor = Color.FromArgb(76, 175, 80);
                    btnDelivered.Click += (s, e) =>
                    {
                        if (MessageBox.Show($"Mark order #{order.OrderId} as Delivered?", "Confirm Completion",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            order.Stage = "Delivered";
                            order.HistoryLog.Add($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - Order delivered by rider {currentRider}");
                            RefreshOrders();
                            OrderStorage.UpdateOrder(); // Add this line
                        }
                    };
                    orderPanel.Controls.Add(btnDelivered);
                }
                else if (order.Stage == "Delivered")
                {
                    // Add a checkmark icon or completed badge
                    Label lblCompleted = new Label
                    {
                        Text = "COMPLETED",
                        Font = new Font("Microsoft Sans Serif", 9, FontStyle.Bold),
                        ForeColor = Color.FromArgb(76, 175, 80),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Location = new Point(orderPanel.Width - 130, 60),
                        Size = new Size(110, 30),
                        AutoSize = false
                    };
                    orderPanel.Controls.Add(lblCompleted);
                }
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
                OrderStorage.UpdateOrder(); // Add this line
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

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}