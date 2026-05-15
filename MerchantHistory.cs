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
            currentMerchant = Form1.CurrentUsername;
        }

        private void MerchantHistory_Load(object sender, EventArgs e)
        {
            LoadCompletedOrders();
        }

        private void LoadCompletedOrders()
        {
            dgvOrders.Rows.Clear();

            // Get all delivered orders that belong to this merchant
            var completedOrders = OrderStorage.AllOrders
                .Where(o => o.MerchantName == currentMerchant && o.Stage == "Delivered")
                .OrderByDescending(o => o.OrderId)   // newest first
                .ToList();

            foreach (var order in completedOrders)
            {
                // Find the date when the order was marked as Delivered (from history log)
                string deliveredDate = "N/A";
                var deliveredLog = order.HistoryLog.LastOrDefault(log => log.Contains("Order delivered"));
                if (deliveredLog != null && deliveredLog.Length >= 19)
                {
                    deliveredDate = deliveredLog.Substring(0, 19); // extract timestamp
                }

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
            {
                dgvOrders.Rows.Add("No orders found", "", "", "", "", "");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MerchantDashBoard dashboard = new MerchantDashBoard();
            dashboard.Show();
            this.Close();
        }
    }
}