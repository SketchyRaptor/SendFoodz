using System;
using System.Linq;
using System.Windows.Forms;

namespace LogIn1
{
    public partial class ViewOrder : Form
    {
        public ViewOrder()
        {
            InitializeComponent();
            lblCustomerName.Text = $"Welcome, {Form1.CurrentUsername}";
            LoadOrders();
        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void LoadOrders()
        {
            var myOrders = OrderStorage.AllOrders
                .Where(o => o.CustomerName == Form1.CurrentUsername)
                .OrderByDescending(o => o.OrderId)
                .ToList();

            dgvOrders.Rows.Clear();
            foreach (var order in myOrders)
            {
                dgvOrders.Rows.Add(
                    order.OrderId,
                    order.MerchantName,
                    string.Join(", ", order.ItemsSummary),
                    order.Total,
                    order.Status,
                    order.Stage,
                    order.Rider
                );
            }
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(dgvOrders.SelectedRows[0].Cells["colOrderId"].Value);
                var order = OrderStorage.AllOrders.FirstOrDefault(o => o.OrderId == orderId);
                if (order != null)
                {
                    lstHistory.Items.Clear();
                    foreach (var log in order.HistoryLog)
                        lstHistory.Items.Add(log);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerDashboard dashboard = new CustomerDashboard();
            dashboard.Show();
            this.Close();
        }
    }
}