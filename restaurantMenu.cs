using LogIn1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first
{
    public partial class restaurantMenu : Form
    {
        public restaurantMenu()
        {
            InitializeComponent();
        }

        private void backButtonResMenu_Click(object sender, EventArgs e)
        {
            this.Close();

           CustomerDashboard cdb = new CustomerDashboard();
           cdb.Show();

            this.Hide();
        }

        private void jViewButton_Click(object sender, EventArgs e)
        {
            MenuThree jm = new MenuThree();
            jm.Show();

            this.Hide();
        }

        private void mViewButton_Click(object sender, EventArgs e)
        {
           MenuTwo mm = new MenuTwo();
            mm.Show();
            this.Hide();
        }

        private void cViewButton_Click(object sender, EventArgs e)
        {
            MenuOne cm = new MenuOne();
            cm.Show();
            this.Hide();
        }

        private void restaurantMenu_Load(object sender, EventArgs e)
        {

        }
    }
}