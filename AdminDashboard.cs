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
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadRiders();
            LoadOrders();
        }
        private void LoadUsers()
        {
            dgvUsers.Columns.Clear();
            dgvUsers.Rows.Clear();

            dgvUsers.Columns.Add("Username", "Username");

            foreach (var acc in Form1.accounts)
            {
                if (acc.Role == "Customer")
                {
                    dgvUsers.Rows.Add(acc.Username);
                }
            }
        }
        private void LoadRiders()
        {
            dgvRiders.Columns.Clear();
            dgvRiders.Rows.Clear();

            dgvRiders.Columns.Add("Rider", "Rider Name");

            foreach (var acc in Form1.accounts)
            {
                if (acc.Role == "Rider")
                {
                    dgvRiders.Rows.Add(acc.Username);
                }
            }
        }
        private void LoadOrders()
        {
            dgvOrders.Columns.Clear();
            dgvOrders.Rows.Clear();

            dgvOrders.Columns.Add("OrderID", "Order ID");

            foreach (string order in Form1.pendingOrders)
            {
                dgvOrders.Rows.Add(order);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUsers();
            LoadRiders();
            LoadOrders();

            MessageBox.Show("Dashboard updated");
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
    }
}
