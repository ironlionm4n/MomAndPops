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
        Order currentOrder = new Order();
        
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
            ///
            /// Pepsi Drink Check
            ///
            if (PepsiQuantity.Value > 0)
            {
                bool hasDrink = false;
                string drinkName;
                if(PepsiSmall.Checked)
                {
                    drinkName = "Small " + PepsiLabel.Text;
                    UncheckDrinkSelections(PepsiSmall);
                }
                else if(PepsiMedium.Checked)
                {
                    drinkName = "Medium " + PepsiLabel.Text;
                    UncheckDrinkSelections(PepsiMedium);
                }
                else
                {
                    drinkName = "Large " + PepsiLabel.Text;
                    UncheckDrinkSelections(PepsiLarge);
                }
                MenuItem drink = new MenuItem(drinkName, MenuItem.drinkPrice, int.Parse(PepsiQuantity.Value.ToString()));
                foreach(MenuItem m in currentOrder.currentOrder)
                {
                    if(m.ItemName.Contains(PepsiLabel.Text))
                    {
                        m.ItemQuantity += drink.ItemQuantity;
                        hasDrink = true;
                    }
                }
                if(hasDrink == false)
                {
                    currentOrder.AddToOrder(drink);
                }
                PepsiQuantity.Value = 0;
                
            }
            ///
            /// Diet Pepsi Drink Check
            ///
            if (DietPepsiQuantity.Value > 0)
            {
                string drinkName;
                bool hasDrink = false;
                if(DietPepsiSmall.Checked)
                {
                    drinkName = "Small " + DietPepsiLabel.Text;
                    UncheckDrinkSelections(DietPepsiSmall);
                }
                else if(DietPepsiMedium.Checked)
                {
                    drinkName = "Medium " + DietPepsiLabel.Text;
                    UncheckDrinkSelections(DietPepsiMedium);
                }
                else
                {
                    drinkName = "Large " + DietPepsiLabel.Text;
                    UncheckDrinkSelections(DietPepsiLarge);
                }
                MenuItem drink = new MenuItem(drinkName, MenuItem.drinkPrice, int.Parse(DietPepsiQuantity.Value.ToString()));
                foreach (MenuItem m in currentOrder.currentOrder)
                {
                    if (m.ItemName.Contains(DietPepsiLabel.Text))
                    {
                        m.ItemQuantity += drink.ItemQuantity;
                        hasDrink = true;
                    }
                }
                if (hasDrink == false)
                {
                    currentOrder.AddToOrder(drink);
                }
                DietPepsiQuantity.Value = 0;
            }
            ///
            /// Orange Drink Check
            ///
            if (OrangeQuantity.Value > 0)
            {
                bool hasDrink = false;
                string drinkName;
                if (OrangeSmall.Checked)
                {
                    drinkName = "Small " + OrangeLabel.Text;
                    UncheckDrinkSelections(OrangeSmall);
                }
                else if (OrangeMedium.Checked)
                {
                    drinkName = "Medium " + OrangeLabel.Text;
                    UncheckDrinkSelections(OrangeMedium);
                }
                else
                {
                    drinkName = "Large " + OrangeLabel.Text;
                    UncheckDrinkSelections(OrangeLarge);
                }
                MenuItem drink = new MenuItem(drinkName, MenuItem.drinkPrice, int.Parse(OrangeQuantity.Value.ToString()));
                foreach (MenuItem m in currentOrder.currentOrder)
                {
                    if (m.ItemName.Contains(OrangeLabel.Text))
                    {
                        m.ItemQuantity += drink.ItemQuantity;
                        hasDrink = true;
                    }
                }
                if (hasDrink == false)
                {
                    currentOrder.AddToOrder(drink);
                }
                OrangeQuantity.Value = 0;
            }
            ///
            /// Diet Orange Drink Check
            ///
            if (DietOrangeQuantity.Value > 0)
            {
                bool hasDrink = false;
                string drinkName;
                if (DietOrangeSmall.Checked)
                {
                    drinkName = "Small " + DietOrangeLabel.Text;
                    UncheckDrinkSelections(DietOrangeSmall);
                }
                else if (DietOrangeMedium.Checked)
                {
                    drinkName = "Medium " + DietOrangeLabel.Text;
                    UncheckDrinkSelections(DietOrangeMedium);
                }
                else
                {
                    drinkName = "Large " + DietOrangeLabel.Text;
                    UncheckDrinkSelections(DietOrangeLarge);
                }
                MenuItem drink = new MenuItem(drinkName, MenuItem.drinkPrice, int.Parse(DietOrangeQuantity.Value.ToString()));
                foreach (MenuItem m in currentOrder.currentOrder)
                {
                    if (m.ItemName.Contains(DietOrangeLabel.Text))
                    {
                        m.ItemQuantity += drink.ItemQuantity;
                        hasDrink = true;
                    }
                }
                if (hasDrink == false)
                {
                    currentOrder.AddToOrder(drink);
                }
                DietOrangeQuantity.Value = 0;
            }
            ///
            /// Root Beer Drink Check
            ///
            if (RootBeerQuantity.Value > 0)
            {
                bool hasDrink = false;
                string drinkName;
                if (RootBeerSmall.Checked)
                {
                    drinkName = "Small " + RootBeerLabel.Text;
                    UncheckDrinkSelections(RootBeerSmall);
                }
                else if (RootBeerMedium.Checked)
                {
                    drinkName = "Medium " + RootBeerLabel.Text;
                    UncheckDrinkSelections(RootBeerMedium);
                }
                else
                {
                    drinkName = "Large " + RootBeerLabel.Text;
                    UncheckDrinkSelections(RootbeerLarge);
                }
                MenuItem drink = new MenuItem(drinkName, MenuItem.drinkPrice, int.Parse(RootBeerQuantity.Value.ToString()));
                foreach (MenuItem m in currentOrder.currentOrder)
                {
                    if (m.ItemName.Contains(RootBeerLabel.Text))
                    {
                        m.ItemQuantity += drink.ItemQuantity;
                        hasDrink = true;
                    }
                }
                if (hasDrink == false)
                {
                    currentOrder.AddToOrder(drink);
                }
                RootBeerQuantity.Value = 0;
            }
            ///
            /// Diet Root Beer Drink Check
            ///
            if (DietRootBeerQuantity.Value > 0)
            {
                bool hasDrink = false;
                string drinkName;
                if (DietRootBeerSmall.Checked)
                {
                    drinkName = "Small " + DietRootBeerLabel.Text;
                    UncheckDrinkSelections(DietRootBeerSmall);
                }
                else if (DietRootBeerMedium.Checked)
                {
                    drinkName = "Medium " + DietRootBeerLabel.Text;
                    UncheckDrinkSelections(DietRootBeerMedium);
                }
                else
                {
                    drinkName = "Large " + DietRootBeerLabel.Text;
                    UncheckDrinkSelections(DietRootBeerLarge);
                }
                MenuItem drink = new MenuItem(drinkName, MenuItem.drinkPrice, int.Parse(DietRootBeerQuantity.Value.ToString()));
                foreach (MenuItem m in currentOrder.currentOrder)
                {
                    if (m.ItemName.Contains(DietRootBeerLabel.Text))
                    {
                        m.ItemQuantity += drink.ItemQuantity;
                        hasDrink = true;
                    }
                }
                if (hasDrink == false)
                {
                    currentOrder.AddToOrder(drink);
                }
                DietRootBeerQuantity.Value = 0;
            }
            ///
            /// Sierra Mist Drink Check
            ///
            if (SierraMistQuantity.Value > 0)
            {
                bool hasDrink = false;
                string drinkName;
                if (SierraMistSmall.Checked)
                {
                    drinkName = "Small " + SierraMistLabel.Text;
                    UncheckDrinkSelections(SierraMistSmall);
                }
                else if (SierraMistMedium.Checked)
                {
                    drinkName = "Medium " + SierraMistLabel.Text;
                    UncheckDrinkSelections(SierraMistMedium);
                }
                else
                {
                    drinkName = "Large " + SierraMistLabel.Text;
                    UncheckDrinkSelections(SierraMistLarge);
                }
                MenuItem drink = new MenuItem(drinkName, MenuItem.drinkPrice, int.Parse(SierraMistQuantity.Value.ToString()));
                foreach (MenuItem m in currentOrder.currentOrder)
                {
                    if (m.ItemName.Contains(SierraMistLabel.Text))
                    {
                        m.ItemQuantity += drink.ItemQuantity;
                        hasDrink = true;
                    }
                }
                if (hasDrink == false)
                {
                    currentOrder.AddToOrder(drink);
                }
                SierraMistQuantity.Value = 0;
            }
            ///
            /// Lemonade Drink Check
            ///
            if (LemonadeQuantity.Value > 0)
            {
                bool hasDrink = false;
                string drinkName;
                if (LemonadeSmall.Checked)
                {
                    drinkName = "Small " + LemonadeLabel.Text;
                    UncheckDrinkSelections(LemonadeSmall);

                }
                else if (SierraMistMedium.Checked)
                {
                    drinkName = "Medium " + LemonadeLabel.Text;
                    UncheckDrinkSelections(LemonadeMedium);
                }
                else
                {
                    drinkName = "Large " + LemonadeLabel.Text;
                    UncheckDrinkSelections(LemonadeLarge);
                }
                MenuItem drink = new MenuItem(drinkName, MenuItem.drinkPrice, int.Parse(LemonadeQuantity.Value.ToString()));
                foreach (MenuItem m in currentOrder.currentOrder)
                {
                    if (m.ItemName.Contains(LemonadeLabel.Text))
                    {
                        m.ItemQuantity += drink.ItemQuantity;
                        hasDrink = true;
                    }
                }
                if (hasDrink == false)
                {
                    currentOrder.AddToOrder(drink);
                }
                LemonadeQuantity.Value = 0;
            }
            //Cart.AddToCart(currentOrder);
       
            PrintOrder();
        }

        void UncheckDrinkSelections(RadioButton radioButton)
        {
            radioButton.Checked = false;
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

        public void SetOrder(Order newOrder)
        {
            currentOrder = newOrder;
            PrintOrder();
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
