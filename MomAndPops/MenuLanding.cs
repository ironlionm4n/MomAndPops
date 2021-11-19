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
                MenuItem breadsticks = new MenuItem(Breadsticks.Text, price, int.Parse(BreadsticksQuantity.Value.ToString()));
                foreach(MenuItem m in currentOrder.currentOrder)
                {
                    if(m.ItemName != Breadsticks.Text)
                    {
                        currentOrder.AddToOrder(breadsticks);
                    }
                    else
                    {
                        m.ItemQuantity += breadsticks.ItemQuantity;
                    }
                }
                BreadsticksQuantity.Value = 0;
            }
            if(BreadstickBitesQuantity.Value > 0)
            {
                for(int i = 0; i < BreadstickBitesQuantity.Value; i++)
                {
                    float price = float.Parse(BreadstickBitesPrice.Text[1].ToString());
                    MenuItem breadStickBites = new MenuItem(BreadstickBites.Text, price, int.Parse(BreadstickBitesQuantity.Value.ToString()));
                    currentOrder.AddToOrder(breadStickBites);
                  //  CurrentOrderLabel.Text = PrintOrder();
                }
            }
            if(CookieQuantity.Value > 0)
            {
                for(int i = 0; i < CookieQuantity.Value; i++)
                {
                    float price = float.Parse(CookiePrice.Text[1].ToString());
                    MenuItem cookie = new MenuItem(ChocChipCookie.Text, price, int.Parse(CookieQuantity.Value.ToString()));
                    currentOrder.AddToOrder(cookie);
                  //  CurrentOrderLabel.Text = PrintOrder();
                }
            }
            Cart.AddToCart(currentOrder);
            //PrintOrder();
          
        }

        /*string*/ void PrintOrder()
        {
            float totalPrice = 0f;
            //Location = new Point(45, 135);
            //string order = String.Empty;
            foreach(MenuItem item in currentOrder)
            {
                totalPrice += (item.ItemQuantity * item.ItemPrice);

/*                Label cartLabel = new Label
                {
                    Location = Location,
                    Size = new Size(189, 48)
                };
                CartPanel.
                Location = new Point(45, 135 + cartLabel.Location.Y);
                cartLabel.Text = item.ItemQuantity + " " + item.ItemName + " $" + item.ItemPrice;
            //    order += item.ItemQuantity + " " + item.ItemName + " $" + item.ItemPrice + "\n";*/
            }
            for(int i = 0; i < currentOrder.currentOrder.Count; i++)
            {
                CartTextBox.Text += currentOrder.currentOrder[i].ItemQuantity + " " + currentOrder.currentOrder[i].ItemName + " $" + currentOrder.currentOrder[i].ItemPrice + Environment.NewLine;
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
            PrintOrder();
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

      
    }
}
