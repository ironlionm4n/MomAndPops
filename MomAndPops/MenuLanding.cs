using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MomAndPops.Resources
{
    public partial class MenuLanding : Form
    {
        readonly Order currentOrder = new Order();

        public MenuLanding()
        {
            InitializeComponent();
        }
        #region
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void BreadstickPrice_Click(object sender, EventArgs e)
        {
            
        }
        #endregion
        private void AddToOrder_Click(object sender, EventArgs e)
        {
            if(BreadsticksQuantity.Value > 0)
            {
                for(int i = 0; i < BreadsticksQuantity.Value; i++)
                {
                    float price = float.Parse(BreadstickPrice.Text[1].ToString());
                    MenuItem breadsticks = new MenuItem(Breadsticks.Text, price);
                    currentOrder.AddToOrder(breadsticks);
                }
       
            }
            if(BreadstickBitesQuantity.Value > 0)
            {
                for(int i = 0; i < BreadsticksQuantity.Value; i++)
                {
                    float price = float.Parse(BreadstickBitesPrice.Text[1].ToString());
                    MenuItem breadStickBites = new MenuItem(BreadstickBites.Text, price);
                    currentOrder.AddToOrder(breadStickBites);
                }
     
            }
            if(CookieQuantity.Value > 0)
            {
                for(int i = 0; i < CookieQuantity.Value; i++)
                {
                    float price = float.Parse(CookiePrice.Text[1].ToString());
                    MenuItem cookie = new MenuItem(ChocChipCookie.Text, price);
                    currentOrder.AddToOrder(cookie);
                }
            }
            PrintOrder();
            Cart.AddToCart(currentOrder);
        }

        void PrintOrder()
        {
            foreach(MenuItem item in currentOrder)
            {
                Console.WriteLine($"Item Name: {item.ItemName}\tItem Price: ${item.ItemPrice}");
            }
        }

        private void Checkout_Click(object sender, EventArgs e)
        {
            var cartForm = new Cart();
            cartForm.Show();
            this.Visible = false;
        }
    }
}
