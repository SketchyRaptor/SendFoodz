using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LogIn1
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Price { get; set; }

        public string Quantity { get; set; }
        public Image Picture { get; set; }
    }

    public class Restaurant
    {
        public string Name { get; set; }
        public Image Logo { get; set; }
        public List<MenuItem> MenuItems { get; set; }

        public Restaurant()
        {
            MenuItems = new List<MenuItem>();
        }
    }
}
