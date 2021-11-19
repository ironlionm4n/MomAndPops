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
        private void AddToCart_Click(object sender, EventArgs e)
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
                for(int i = 0; i < BreadstickBitesQuantity.Value; i++)
                {
                    float price = float.Parse(BreadstickBitesPrice.Text[1].ToString());
                    MenuItem breadStickBites = new MenuItem(BreadstickBites.Text, price);
                    currentOrder.AddToOrder(breadStickBites);
                    CurrentOrderLabel.Text = PrintOrder();
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

        string PrintOrder()
        {
            string order ="";
            foreach(MenuItem item in currentOrder)
            {
                order += item.ItemName;
            }
            return order;
        }

        private void Checkout_Click(object sender, EventArgs e)
        {
            var cartForm = new Cart();
            cartForm.Show();
            this.Visible = false;
        }

        private void DietSmallMedium_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Form login = new LoginPage();
            login.ShowDialog();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CartXBackground_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            PizzaPanel.AutoScroll = true;
        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            CartPanel.Visible = true;
            CartPanel.Enabled = true;
        }

        private void CartXButton_Click(object sender, EventArgs e)
        {
            CartPanel.Visible = false;
            CartPanel.Enabled = false;
        }

        private void PreviousOrdersButton_Click(object sender, EventArgs e)
        {
            PreviousOrders.Visible = true;
            PreviousOrders.Enabled = true;
        }

        private void PreviousOrderXButton_Click(object sender, EventArgs e)
        {
            PreviousOrders.Visible = false;
            PreviousOrders.Enabled = false;
        }

        private void SmallMushroom_CheckedChanged(object sender, EventArgs e)
        {
            
        }

    }
}
