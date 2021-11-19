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
 
        private void AddToCart_Click(object sender, EventArgs e)
        {
            if(BreadsticksQuantity.Value > 0)
            {
                bool hasBreadsticks = false;
                float price = float.Parse(BreadstickPrice.Text[1].ToString());
                MenuItem breadsticks = new MenuItem(Breadsticks.Text, price, int.Parse(BreadsticksQuantity.Value.ToString()));

                foreach (MenuItem m in currentOrder.currentOrder)
                {
                    if(m.ItemName.Equals(Breadsticks.Text))
                    {
                        m.ItemQuantity += breadsticks.ItemQuantity;
                        hasBreadsticks = true;
                    }
                }
                if(hasBreadsticks == false)
                {
                    currentOrder.AddToOrder(breadsticks);
                }
                BreadsticksQuantity.Value = 0;
            }
            if(BreadstickBitesQuantity.Value > 0)
            {
                bool hasBreadstickBites = false;
                float price = float.Parse(BreadstickBitesPrice.Text[1].ToString());
                MenuItem breadstickBites = new MenuItem(BreadstickBites.Text, price, int.Parse(BreadstickBitesQuantity.Value.ToString()));

                foreach (MenuItem m in currentOrder.currentOrder)
                {
                    if (m.ItemName.Equals(BreadstickBites.Text))
                    {
                        m.ItemQuantity += breadstickBites.ItemQuantity;
                        hasBreadstickBites = true;
                    }
                }
                if (hasBreadstickBites == false)
                {
                    currentOrder.AddToOrder(breadstickBites);
                }
                BreadstickBitesQuantity.Value = 0;
            }
            if(CookieQuantity.Value > 0)
            {
                bool hasCookie = false;
                float price = float.Parse(CookiePrice.Text[1].ToString());
                MenuItem cookie = new MenuItem(ChocChipCookie.Text, price, int.Parse(CookieQuantity.Value.ToString()));
                foreach (MenuItem m in currentOrder.currentOrder)
                {
                    if (m.ItemName.Equals(ChocChipCookie.Text))
                    {
                        m.ItemQuantity += cookie.ItemQuantity;
                        hasCookie = true;
                    }
                }
                if (hasCookie == false)
                {
                    currentOrder.AddToOrder(cookie);
                }
                CookieQuantity.Value = 0;
            }
            //Cart.AddToCart(currentOrder);
            PrintOrder();
          
        }

        /*string*/ void PrintOrder()
        {
            float totalPrice = 0f;
            TotalLabel.Text = string.Empty;
            CartTextBox.Text = string.Empty;
            foreach(MenuItem item in currentOrder.currentOrder)
            {
                totalPrice += (item.ItemQuantity * item.ItemPrice);
                CartTextBox.Text += item.ItemQuantity + " " + item.ItemName + " $" 
                    + item.ItemPrice + Environment.NewLine;
            }

            TotalLabel.Text = "$ " + totalPrice.ToString();
            //return order;
        }



        private void Checkout_Click(object sender, EventArgs e)
        {
            
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
            //PrintOrder();
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

        public Order GetOrder()
        {
            return currentOrder;
        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Payment payment = new Payment();
            payment.SetOrder(GetOrder());
            payment.Show();
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            currentOrder.currentOrder.Clear();
            PrintOrder();
        }
    }
}
