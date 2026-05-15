using System;
using System.Linq;
using System.Windows.Forms;

namespace LogIn1
{
    public partial class MerchantHistory : Form
    {
        private string currentMerchant;

        public MerchantHistory()
        {
            InitializeComponent();
            // Make form open maximized (full screen)
            this.WindowState = FormWindowState.Maximized;
            currentMerchant = Form1.CurrentUsername;
            this.Resize += MerchantHistory_Resize;
            AdjustLayout(); // initial sizing
        }

        private void MerchantHistory_Load(object sender, EventArgs e)
        {
            LoadCompletedOrders();
        }

        private void MerchantHistory_Resize(object sender, EventArgs e)
        {
            AdjustLayout();
        }

        private void AdjustLayout()
        {
            if (dgvOrders == null) return;

            // Make DataGridView fill all space below the top panel
            int topMargin = panelTop.Height + 20;
            dgvOrders.Top = topMargin;
            dgvOrders.Left = 20;
            dgvOrders.Width = this.ClientSize.Width - 40;
            dgvOrders.Height = this.ClientSize.Height - topMargin - 20;
        }

        private void LoadCompletedOrders()
        {
            dgvOrders.Rows.Clear();

            var completedOrders = OrderStorage.AllOrders
                .Where(o => o.MerchantName == currentMerchant && o.Stage == "Delivered")
                .OrderByDescending(o => o.OrderId)
                .ToList();

            foreach (var order in completedOrders)
            {
                string deliveredDate = "N/A";
                var deliveredLog = order.HistoryLog.LastOrDefault(log => log.Contains("Order delivered"));
                if (deliveredLog != null && deliveredLog.Length >= 19)
                    deliveredDate = deliveredLog.Substring(0, 19);

                dgvOrders.Rows.Add(
                    order.OrderId,
                    order.CustomerName,
                    string.Join(", ", order.ItemsSummary),
                    order.Total.ToString("F2"),
                    deliveredDate,
                    order.Rider
                );
            }

            if (completedOrders.Count == 0)
                dgvOrders.Rows.Add("No orders found", "", "", "", "", "");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MerchantDashBoard dashboard = new MerchantDashBoard();
            dashboard.Show();
            this.Close();
        }
    }
}