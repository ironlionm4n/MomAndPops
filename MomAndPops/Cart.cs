using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MomAndPops
{
    partial class Cart : Form
    {
        private static List<Order> cartCollection = new List<Order>();

        public List<Order> CartCollection
        {
            get { return cartCollection; }
        }

        public Cart()
        {
            InitializeComponent();
        }

        public void CartForm_OnShown(object sender, EventArgs e)
        {
            listViewCart.View = View.Details;
            listViewCart.GridLines = true;
            listViewCart.FullRowSelect = true;
            listViewCart.Columns.Add("Item Name: ", 120);
            ListViewItem item = new ListViewItem(cartCollection[0].MenuItemName);
            listViewCart.Items.Add(item);
            Console.WriteLine(listViewCart.Items[0].ToString());
        }

        public static void AddToCart(Order order)
        {
            cartCollection.Add(order);
        }

        public static void UpdateCartDisplay(List<Order> cartCollection)
        {
            foreach(Order order in cartCollection)
            {

            }
        }
    }
}
