using first;
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
    public partial class MenuOne : Form
    {
        public MenuOne()
        {
            InitializeComponent();
        }

        private void ChowkingMenu_Load(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            restaurantMenu rm = new restaurantMenu();
            rm.Show();
            this.Hide();
        }
    }
}
