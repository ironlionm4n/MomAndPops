using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MomAndPops.Resources
{
    public partial class MenuLanding : Form
    {
        Order currentOrder = new Order();
        Customer customer;

        List<ComboBox> activeSmallComboBoxes = new List<ComboBox>();
        List<ComboBox> activeMediumComboBoxes = new List<ComboBox>();
        List<ComboBox> activeLargeComboBoxes = new List<ComboBox>();
        List<ComboBox> activeExtraLargeComboBoxes = new List<ComboBox>();

        

        int lastSmallCheeseSelection = 0;
        int lastSmallPepSelection = 0;
        int lastSmallSausageSelection = 0;
        int lastSmallHamSelection = 0;
        int lastSmallOnionSelection = 0;
        int lastSmallGPSelection = 0;
        int lastSmallTomatoSelection = 0;
        int lastSmallMushroomSelection = 0;
        int lastSmallPineappleSelection = 0;

        int lastMedCheeseSelection = 0;
        int lastMedPepSelection = 0;
        int lastMedSausageSelection = 0;
        int lastMedHamSelection = 0;
        int lastMedOnionSelection = 0;
        int lastMedGPSelection = 0;
        int lastMedTomatoSelection = 0;
        int lastMedMushroomSelection = 0;
        int lastMedPineappleSelection = 0;

        int lastLargeCheeseSelection = 0;
        int lastLargePepSelection = 0;
        int lastLargeSausageSelection = 0;
        int lastLargeHamSelection = 0;
        int lastLargeOnionSelection = 0;
        int lastLargeGPSelection = 0;
        int lastLargeTomatoSelection = 0;
        int lastLargeMushroomSelection = 0;
        int lastLargePineappleSelection = 0;

        int lastXLCheeseSelection = 0;
        int lastXLPepSelection = 0;
        int lastXLSausageSelection = 0;
        int lastXLHamSelection = 0;
        int lastXLOnionSelection = 0;
        int lastXLGPSelection = 0;
        int lastXLTomatoSelection = 0;
        int lastXLMushroomSelection = 0;
        int lastXLPineappleSelection = 0;

        public MenuLanding()
        {
            InitializeComponent();

        }

        /// <summary>
        /// AddToCart_Click is called whenever the user clicks AddToCart to add their selection to their cart. It then goes through and checks each menu item to see which
        /// ones have had their order amounts updated. Once it finds one that has its order quantity above 0, it gathers the necesary information for it to add it to the cart
        /// based on the item.
        /// For appetizers and deserts it gathers the item name, quantity, and price
        /// For entrees it gathers the item name, quantity, price, and all the toppings
        /// For drinks it gathers the item name, quanity, size, and price
        /// After it collects all the necesary data it attempts to add the item to the cart list but checks if there is already an identical item added
        /// If there is, the program updates the quantity of that item ordered
        /// If not, the item is added to the list and is displayed for the customer on their cart tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToCart_Click(object sender, EventArgs e)
        {
            float totalPrice = 0f;
            TotalLabel.Text = string.Empty;
            CartTextBox.Text = string.Empty;
            if (BreadsticksQuantity.Value > 0)
            {
                BreadsticksItem();
            }
            if (BreadstickBitesQuantity.Value > 0)
            {
                BreadstickBitesItem();
            }
            if (CookieQuantity.Value > 0)
            {
                Cookie();
            }
            ///
            /// Pepsi Drink Check
            ///
            if (PepsiQuantity.Value > 0 && (PepsiSmall.Checked || PepsiMedium.Checked || PepsiLarge.Checked))
            {
                Pepsi();

            }
            ///
            /// Diet Pepsi Drink Check
            ///
            if (DietPepsiQuantity.Value > 0 && (DietPepsiSmall.Checked || DietPepsiMedium.Checked || DietPepsiLarge.Checked))
            {
                DietPepsi();
            }
            ///
            /// Orange Drink Check
            ///
            if (OrangeQuantity.Value > 0 && (OrangeSmall.Checked || OrangeMedium.Checked || OrangeLarge.Checked))
            {
                Orange();
            }
            ///
            /// Diet Orange Drink Check
            ///
            if (DietOrangeQuantity.Value > 0 && (DietOrangeSmall.Checked || DietOrangeMedium.Checked || DietOrangeLarge.Checked))
            {
                DietOrange();
            }
            ///
            /// Root Beer Drink Check
            ///
            if (RootBeerQuantity.Value > 0 && (RootBeerSmall.Checked || RootBeerMedium.Checked || RootBeerLarge.Checked))
            {
                RootBeer();
            }
            ///
            /// Diet Root Beer Drink Check
            ///
            if (DietRootBeerQuantity.Value > 0 && (DietRootBeerSmall.Checked || DietRootBeerMedium.Checked || DietRootBeerLarge.Checked))
            {
                DietRootBeer();
            }
            ///
            /// Sierra Mist Drink Check
            ///
            if (SierraMistQuantity.Value > 0 && (SierraMistSmall.Checked || SierraMistMedium.Checked || SierraMistLarge.Checked))
            {
                SierraMist();
            }
            ///
            /// Lemonade Drink Check
            ///
            if (LemonadeQuantity.Value > 0 && (LemonadeSmall.Checked || LemonadeMedium.Checked || LemonadeLarge.Checked))
            {
                Lemonade();
            }

            foreach (MenuItem item in currentOrder.currentOrder)
            {
                totalPrice += (item.ItemQuantity * item.ItemPrice);
                CartTextBox.Text += item.ItemQuantity + " " + item.ItemName + " $"
                    + item.ItemPrice + Environment.NewLine;
            }
            ///
            ///Small Pizza Check
            ///
            if (SmallPizzaQuantity.Value > 0 && (SmallThinCrust.Checked || SmallRegularCrust.Checked || SmallPanCrust.Checked))
            {
                SmallPizza();
            }
            ///
            ///Medium Pizza Check
            ///
            if (MediumPizzaQuantity.Value > 0 && (MediumThinCrust.Checked || MediumRegularCrust.Checked || MediumPanCrust.Checked))
            {
                MediumPizza();
            }
            ///
            ///Large Pizza Check
            ///
            if (LargePizzaQuantity.Value > 0 && (LargeThinCrust.Checked || LargeRegularCrust.Checked || LargePanCrust.Checked))
            {
                LargePizza();
            }
            ///
            ///Extra Large Pizza Check
            ///
            if (ExtraLargePizzaQuantity.Value > 0 && (ExtraLargeThinCrust.Checked || ExtraLargeRegularCrust.Checked || ExtraLargePanCrust.Checked))
            {
                ExtraLargePizza();
            }


            PrintOrder();
        }

        private void BreadsticksItem()
        {
            bool hasBreadsticks = false;
            float price = float.Parse(BreadstickPrice.Text.Substring(1));
            MenuItem breadsticks = new MenuItem(Breadsticks.Text, price, int.Parse(BreadsticksQuantity.Value.ToString()));

            foreach (MenuItem m in currentOrder.currentOrder)
            {
                if (m.ItemName.Equals(Breadsticks.Text))
                {
                    m.ItemQuantity += breadsticks.ItemQuantity;
                    hasBreadsticks = true;
                }
            }
            if (hasBreadsticks == false)
            {
                currentOrder.AddToOrder(breadsticks);
            }
            BreadsticksQuantity.Value = 0;
        }

        private void BreadstickBitesItem()
        {
            bool hasBreadstickBites = false;
            float price = float.Parse(BreadstickBitesPrice.Text.Substring(1));
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

        private void Cookie()
        {
            bool hasCookie = false;
            float price = float.Parse(CookiePrice.Text.Substring(1));
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

        private void Pepsi()
        {
            bool hasDrink = false;
            string drinkName;
            if (PepsiSmall.Checked)
            {
                drinkName = "Small " + PepsiLabel.Text;
                UncheckDrinkSelections(PepsiSmall);
            }
            else if (PepsiMedium.Checked)
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
            foreach (MenuItem m in currentOrder.currentOrder)
            {
                if (m.ItemName.Contains(PepsiLabel.Text))
                {
                    m.ItemQuantity += drink.ItemQuantity;
                    hasDrink = true;
                }
            }
            if (hasDrink == false)
            {
                currentOrder.AddToOrder(drink);
            }
            PepsiQuantity.Value = 0;
        }

        private void DietPepsi()
        {
            string drinkName;
            bool hasDrink = false;
            if (DietPepsiSmall.Checked)
            {
                drinkName = "Small " + DietPepsiLabel.Text;
                UncheckDrinkSelections(DietPepsiSmall);
            }
            else if (DietPepsiMedium.Checked)
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

        private void Orange()
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

        private void DietOrange()
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

        private void RootBeer()
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
                UncheckDrinkSelections(RootBeerLarge);
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

        private void DietRootBeer()
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

        private void SierraMist()
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

        private void Lemonade()
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

        private void SmallPizza()
        {
            bool hasThisPizza = false;
            List<string> topping = new List<string>();
            string crust = "";
            float price = float.Parse(SmallPizzaPrice.Text.Substring(1));

            if (SmallThinCrust.Checked)
            {
                crust = "Thin Crust";
                SmallThinCrust.Checked = false;
            }
            else if (SmallPanCrust.Checked)
            {
                crust = "Pan Crust";
                SmallPanCrust.Checked = false;
            }
            else if (SmallRegularCrust.Checked)
            {
                crust = "Regular Crust";
                SmallRegularCrust.Checked = false;
            }

            if (SmallCheese.SelectedIndex != SmallCheese.FindString("None"))
            {
                topping.Add(SmallCheese.Text + " " + SmallCheeseLabel.Text);
                SmallCheese.SelectedIndex = 0;
            }

            if (SmallPepperoni.SelectedIndex != SmallPepperoni.FindString("None"))
            {
                topping.Add(SmallPepperoni.Text + " " + SmallPepperoniLabel.Text);
                SmallPepperoni.SelectedIndex = 0;
            }

            if (SmallSausage.SelectedIndex != SmallSausage.FindString("None"))
            {
                topping.Add(SmallSausage.Text + " " + SmallSausageLabel.Text);
                SmallSausage.SelectedIndex = 0;
            }

            if (SmallHam.SelectedIndex != SmallHam.FindString("None"))
            {
                topping.Add(SmallHam.Text + " " + SmallHamLabel.Text);
                SmallHam.SelectedIndex = 0;
            }

            if (SmallOnion.SelectedIndex != SmallOnion.FindString("None"))
            {
                topping.Add(SmallOnion.Text + " " + SmallOnionLabel.Text);
                SmallOnion.SelectedIndex = 0;
            }

            if (SmallGreenPepper.SelectedIndex != SmallGreenPepper.FindString("None"))
            {
                topping.Add(SmallGreenPepper.Text + " " + SmallGreenPepperLabel.Text);
                SmallGreenPepper.SelectedIndex = 0;
            }

            if (SmallTomato.SelectedIndex != SmallTomato.FindString("None"))
            {
                topping.Add(SmallTomato.Text + " " + SmallTomatoLabel.Text);
                SmallTomato.SelectedIndex = 0;
            }

            if (SmallMushroom.SelectedIndex != SmallMushroom.FindString("None"))
            {
                topping.Add(SmallMushroom.Text + " " + SmallMushroomLabel.Text);
                SmallMushroom.SelectedIndex = 0;
            }

            if (SmallPineapple.SelectedIndex != SmallPineapple.FindString("None"))
            {
                topping.Add(SmallPineapple.Text + " " + SmallPineappleLabel.Text);
                SmallPineapple.SelectedIndex = 0;
            }

            MenuItem pizza = new MenuItem(SmallPizzaText.Text, price, int.Parse(SmallPizzaQuantity.Value.ToString()), "Small", topping, crust);
            foreach (MenuItem m in currentOrder.currentOrder)
            {
                int numberSameToppings = 0;
                if (m.ItemName.Equals(SmallPizzaText.Text) && m.Toppings.Count == pizza.Toppings.Count && m.CrustOption == pizza.CrustOption)
                {

                    for (int i = 0; i < pizza.Toppings.Count; i++)
                    {
                        if (m.Toppings[i] == pizza.Toppings[i])
                        {
                            numberSameToppings++;
                        }
                    }
                    if (numberSameToppings == pizza.Toppings.Count)
                    {
                        m.ItemQuantity += pizza.ItemQuantity;
                        hasThisPizza = true;
                    }
                    else
                    {
                        currentOrder.AddToOrder(pizza);
                    }
                }
            }
            if (hasThisPizza == false)
            {
                currentOrder.AddToOrder(pizza);
            }
            SmallPizzaQuantity.Value = 0;
        }

        private void MediumPizza()
        {
            bool hasThisPizza = false;
            List<string> topping = new List<string>();
            string crust = "";
            float price = float.Parse(MediumPizzaPrice.Text.Substring(1));

            if (MediumThinCrust.Checked)
            {
                crust = "Thin Crust";
                MediumThinCrust.Checked = false;
            }
            else if (MediumPanCrust.Checked)
            {
                crust = "Pan Crust";
                MediumPanCrust.Checked = false;
            }
            else if (MediumRegularCrust.Checked)
            {
                crust = "Regular Crust";
                MediumRegularCrust.Checked = false;
            }

            if (MediumCheese.SelectedIndex != MediumCheese.FindString("None"))
            {
                topping.Add(MediumCheese.Text + " " + MediumCheeseLabel.Text);
                MediumCheese.SelectedIndex = 0;
            }

            if (MediumPepperoni.SelectedIndex != MediumPepperoni.FindString("None"))
            {
                topping.Add(MediumPepperoni.Text + " " + MediumPepperoniLabel.Text);
                MediumPepperoni.SelectedIndex = 0;
            }

            if (MediumSausage.SelectedIndex != MediumSausage.FindString("None"))
            {
                topping.Add(MediumSausage.Text + " " + MediumSausageLabel.Text);
                MediumSausage.SelectedIndex = 0;
            }

            if (MediumHam.SelectedIndex != MediumHam.FindString("None"))
            {
                topping.Add(MediumHam.Text + " " + MediumHamLabel.Text);
                MediumHam.SelectedIndex = 0;
            }

            if (MediumOnion.SelectedIndex != MediumOnion.FindString("None"))
            {
                topping.Add(MediumOnion.Text + " " + MediumOnionLabel.Text);
                MediumOnion.SelectedIndex = 0;
            }

            if (MediumGreenPepper.SelectedIndex != MediumGreenPepper.FindString("None"))
            {
                topping.Add(MediumGreenPepper.Text + " " + MediumGreenPepperLabel.Text);
                MediumGreenPepper.SelectedIndex = 0;
            }

            if (MediumTomato.SelectedIndex != MediumTomato.FindString("None"))
            {
                topping.Add(MediumTomato.Text + " " + MediumTomatoLabel.Text);
                MediumTomato.SelectedIndex = 0;
            }

            if (MediumMushroom.SelectedIndex != MediumMushroom.FindString("None"))
            {
                topping.Add(MediumMushroom.Text + " " + MediumMushroomLabel.Text);
                MediumMushroom.SelectedIndex = 0;
            }

            if (MediumPineapple.SelectedIndex != MediumPineapple.FindString("None"))
            {
                topping.Add(MediumPineapple.Text + " " + MediumPineappleLabel.Text);
                MediumPineapple.SelectedIndex = 0;
            }

            MenuItem pizza = new MenuItem(MediumPizzaText.Text, price, int.Parse(MediumPizzaQuantity.Value.ToString()), "Medium", topping, crust);
            foreach (MenuItem m in currentOrder.currentOrder)
            {
                int numberSameToppings = 0;
                if (m.ItemName.Equals(MediumPizzaText.Text) && m.Toppings.Count == pizza.Toppings.Count && m.CrustOption == pizza.CrustOption)
                {

                    for (int i = 0; i < pizza.Toppings.Count; i++)
                    {
                        if (m.Toppings[i] == pizza.Toppings[i])
                        {
                            numberSameToppings++;
                        }
                    }
                    if (numberSameToppings == pizza.Toppings.Count)
                    {
                        m.ItemQuantity += pizza.ItemQuantity;
                        hasThisPizza = true;
                    }
                    else
                    {
                        currentOrder.AddToOrder(pizza);
                    }
                }
            }
            if (hasThisPizza == false)
            {
                currentOrder.AddToOrder(pizza);
            }
            MediumPizzaQuantity.Value = 0;
        }

        private void LargePizza()
        {
            bool hasThisPizza = false;
            List<string> topping = new List<string>();
            string crust = "";
            float price = float.Parse(LargePizzaPrice.Text.Substring(1));

            if (LargeThinCrust.Checked)
            {
                crust = "Thin Crust";
                LargeThinCrust.Checked = false;
            }
            else if (LargePanCrust.Checked)
            {
                crust = "Pan Crust";
                LargePanCrust.Checked = false;
            }
            else if (LargeRegularCrust.Checked)
            {
                crust = "Regular Crust";
                LargeRegularCrust.Checked = false;
            }

            if (LargeCheese.SelectedIndex != LargeCheese.FindString("None"))
            {
                topping.Add(LargeCheese.Text + " " + LargeCheeseLabel.Text);
                LargeCheese.SelectedIndex = 0;
            }

            if (LargePepperoni.SelectedIndex != LargePepperoni.FindString("None"))
            {
                topping.Add(LargePepperoni.Text + " " + LargePepperoniLabel.Text);
                LargePepperoni.SelectedIndex = 0;
            }

            if (LargeSausage.SelectedIndex != LargeSausage.FindString("None"))
            {
                topping.Add(LargeSausage.Text + " " + LargeSausageLabel.Text);
                LargeSausage.SelectedIndex = 0;
            }

            if (LargeHam.SelectedIndex != LargeHam.FindString("None"))
            {
                topping.Add(LargeHam.Text + " " + LargeHamLabel.Text);
                LargeHam.SelectedIndex = 0;
            }

            if (LargeOnion.SelectedIndex != LargeOnion.FindString("None"))
            {
                topping.Add(LargeOnion.Text + " " + LargeOnionLabel.Text);
                LargeOnion.SelectedIndex = 0;
            }

            if (LargeGreenPepper.SelectedIndex != LargeGreenPepper.FindString("None"))
            {
                topping.Add(LargeGreenPepper.Text + " " + LargeGreenPepperLabel.Text);
                LargeGreenPepper.SelectedIndex = 0;
            }

            if (LargeTomato.SelectedIndex != LargeTomato.FindString("None"))
            {
                topping.Add(LargeTomato.Text + " " + LargeTomatoLabel.Text);
                LargeTomato.SelectedIndex = 0;
            }

            if (LargeMushroom.SelectedIndex != LargeMushroom.FindString("None"))
            {
                topping.Add(LargeMushroom.Text + " " + LargeMushroomLabel.Text);
                LargeMushroom.SelectedIndex = 0;
            }

            if (LargePineapple.SelectedIndex != LargePineapple.FindString("None"))
            {
                topping.Add(LargePineapple.Text + " " + LargePineappleLabel.Text);
                LargePineapple.SelectedIndex = 0;
            }

            MenuItem pizza = new MenuItem(LargePizzaText.Text, price, int.Parse(LargePizzaQuantity.Value.ToString()), "Large", topping, crust);
            foreach (MenuItem m in currentOrder.currentOrder)
            {
                int numberSameToppings = 0;
                if (m.ItemName.Equals(LargePizzaText.Text) && m.Toppings.Count == pizza.Toppings.Count && m.CrustOption == pizza.CrustOption)
                {

                    for (int i = 0; i < pizza.Toppings.Count; i++)
                    {
                        if (m.Toppings[i] == pizza.Toppings[i])
                        {
                            numberSameToppings++;
                        }
                    }
                    if (numberSameToppings == pizza.Toppings.Count)
                    {
                        m.ItemQuantity += pizza.ItemQuantity;
                        hasThisPizza = true;
                    }
                    else
                    {
                        currentOrder.AddToOrder(pizza);
                    }
                }
            }
            if (hasThisPizza == false)
            {
                currentOrder.AddToOrder(pizza);
            }
            LargePizzaQuantity.Value = 0;
        }

        private void ExtraLargePizza()
        {
            bool hasThisPizza = false;
            List<string> topping = new List<string>();
            string crust = "";
            float price = float.Parse(ExtraLargePizzaPrice.Text.Substring(1));

            if (ExtraLargeThinCrust.Checked)
            {
                crust = "Thin Crust";
                ExtraLargeThinCrust.Checked = false;
            }
            else if (ExtraLargePanCrust.Checked)
            {
                crust = "Pan Crust";
                ExtraLargePanCrust.Checked = false;
            }
            else if (ExtraLargeRegularCrust.Checked)
            {
                crust = "Regular Crust";
                ExtraLargeRegularCrust.Checked = false;
            }

            if (ExtraLargeCheese.SelectedIndex != ExtraLargeCheese.FindString("None"))
            {
                topping.Add(ExtraLargeCheese.Text + " " + ExtraLargeCheeseLabel.Text);
                ExtraLargeCheese.SelectedIndex = 0;
            }

            if (ExtraLargePepperoni.SelectedIndex != ExtraLargePepperoni.FindString("None"))
            {
                topping.Add(ExtraLargePepperoni.Text + " " + ExtraLargePepperoniLabel.Text);
                ExtraLargePepperoni.SelectedIndex = 0;
            }

            if (ExtraLargeSausage.SelectedIndex != ExtraLargeSausage.FindString("None"))
            {
                topping.Add(ExtraLargeSausage.Text + " " + ExtraLargeSausageLabel.Text);
                ExtraLargeSausage.SelectedIndex = 0;
            }

            if (ExtraLargeHam.SelectedIndex != ExtraLargeHam.FindString("None"))
            {
                topping.Add(ExtraLargeHam.Text + " " + ExtraLargeHamLabel.Text);
                ExtraLargeHam.SelectedIndex = 0;
            }

            if (ExtraLargeOnion.SelectedIndex != ExtraLargeOnion.FindString("None"))
            {
                topping.Add(ExtraLargeOnion.Text + " " + ExtraLargeOnionLabel.Text);
                ExtraLargeOnion.SelectedIndex = 0;
            }

            if (ExtraLargeGreenPepper.SelectedIndex != ExtraLargeGreenPepper.FindString("None"))
            {
                topping.Add(ExtraLargeGreenPepper.Text + " " + ExtraLargeGreenPepperLabel.Text);
                ExtraLargeGreenPepper.SelectedIndex = 0;
            }

            if (ExtraLargeTomato.SelectedIndex != ExtraLargeTomato.FindString("None"))
            {
                topping.Add(ExtraLargeTomato.Text + " " + ExtraLargeTomatoLabel.Text);
                ExtraLargeTomato.SelectedIndex = 0;
            }

            if (ExtraLargeMushroom.SelectedIndex != ExtraLargeMushroom.FindString("None"))
            {
                topping.Add(ExtraLargeMushroom.Text + " " + ExtraLargeMushroomLabel.Text);
                ExtraLargeMushroom.SelectedIndex = 0;
            }

            if (ExtraLargePineapple.SelectedIndex != ExtraLargePineapple.FindString("None"))
            {
                topping.Add(ExtraLargePineapple.Text + " " + ExtraLargePineappleLabel.Text);
                ExtraLargePineapple.SelectedIndex = 0;
            }

            MenuItem pizza = new MenuItem(ExtraLargePizzaText.Text, price, int.Parse(ExtraLargePizzaQuantity.Value.ToString()), "ExtraLarge", topping, crust);
            foreach (MenuItem m in currentOrder.currentOrder)
            {
                int numberSameToppings = 0;
                if (m.ItemName.Equals(ExtraLargePizzaText.Text) && m.Toppings.Count == pizza.Toppings.Count && m.CrustOption == pizza.CrustOption)
                {

                    for (int i = 0; i < pizza.Toppings.Count; i++)
                    {
                        if (m.Toppings[i] == pizza.Toppings[i])
                        {
                            numberSameToppings++;
                        }
                    }
                    if (numberSameToppings == pizza.Toppings.Count)
                    {
                        m.ItemQuantity += pizza.ItemQuantity;
                        hasThisPizza = true;
                    }
                    else
                    {
                        currentOrder.AddToOrder(pizza);
                    }
                }
            }
            if (hasThisPizza == false)
            {
                currentOrder.AddToOrder(pizza);
            }
            ExtraLargePizzaQuantity.Value = 0;
        }

        void UncheckDrinkSelections(RadioButton radioButton)
        {
            radioButton.Checked = false;
        }

        /// <summary>
        /// PrintOrder takes all the menu items from the cart list and displays them on the cart tab along with the total for the meal
        /// </summary>
        void PrintOrder()
        {
            float totalPrice = 0f;
            TotalLabel.Text = string.Empty;
            CartTextBox.Text = string.Empty;
            foreach (MenuItem item in currentOrder.currentOrder)
            {
                totalPrice += (item.ItemQuantity * item.ItemPrice);
                if (item.ItemName != SmallPizzaText.Text && item.ItemName != MediumPizzaText.Text && item.ItemName != LargePizzaText.Text && item.ItemName != ExtraLargePizzaText.Text)
                {
                    CartTextBox.Text += item.ItemQuantity + " " + item.ItemName + " $"
                        + item.ItemPrice * item.ItemQuantity + Environment.NewLine;
                }
                else
                {
                    CartTextBox.Text += item.ItemQuantity + " " + item.ItemName + " $" + item.ItemPrice * item.ItemQuantity + Environment.NewLine;
                    CartTextBox.Text += "   " + item.CrustOption + Environment.NewLine;

                    foreach (string topping in item.Toppings)
                    {
                        CartTextBox.Text += "   " + topping + Environment.NewLine;
                    }
                }
            }
            TotalLabel.Text = "$ " + (totalPrice + totalPrice * .06f).ToString("0.00");
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Form login = new LoginPage();
            this.Hide();
            login.ShowDialog();
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

        /// <summary>
        /// PreviousOrdersButton_Click is called when the customer clicks PreviousOrders to acces their previous orders tab. This method checks how many orders are stored
        /// and displays them in their correct sections of the tab.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviousOrdersButton_Click(object sender, EventArgs e)
        {
            PreviousOrders.Visible = true;
            PreviousOrders.Enabled = true;
            PreviousOrder1Label.Text = string.Empty;
            PreviousOrder2Label.Text = string.Empty;
            PreviousOrder3Label.Text = string.Empty;

            if (customer.GetPreviousOrders.Count == 1)
            {
                Order order = customer.GetPreviousOrders.Peek();
                foreach (MenuItem item in order.currentOrder)
                {
                    if (item.ItemName != SmallPizzaText.Text && item.ItemName != MediumPizzaText.Text && item.ItemName != LargePizzaText.Text && item.ItemName != ExtraLargePizzaText.Text)
                    {
                        PreviousOrder1Label.Text += item.ItemQuantity + " " + item.ItemName + " $"
                            + item.ItemPrice * item.ItemQuantity + Environment.NewLine;
                    }
                    else
                    {
                        PreviousOrder1Label.Text += item.ItemQuantity + " " + item.ItemName + " $" + item.ItemPrice * item.ItemQuantity + Environment.NewLine;
                        PreviousOrder1Label.Text += "   " + item.CrustOption + Environment.NewLine;

                        foreach (string topping in item.Toppings)
                        {
                            PreviousOrder1Label.Text += "   " + topping + Environment.NewLine;
                        }
                    }
                }

            }
            else if(customer.GetPreviousOrders.Count == 2)
            {
                Queue<Order> tempQueue = new Queue<Order>();

                Order order = customer.GetPreviousOrders.Peek();
                foreach (MenuItem item in order.currentOrder)
                {
                    if (item.ItemName != SmallPizzaText.Text && item.ItemName != MediumPizzaText.Text && item.ItemName != LargePizzaText.Text && item.ItemName != ExtraLargePizzaText.Text)
                    {
                        PreviousOrder1Label.Text += item.ItemQuantity + " " + item.ItemName + " $"
                            + item.ItemPrice * item.ItemQuantity + Environment.NewLine;
                    }
                    else
                    {
                        PreviousOrder1Label.Text += item.ItemQuantity + " " + item.ItemName + " $" + item.ItemPrice * item.ItemQuantity + Environment.NewLine;
                        PreviousOrder1Label.Text += "   " + item.CrustOption + Environment.NewLine;

                        foreach (string topping in item.Toppings)
                        {
                            PreviousOrder1Label.Text += "   " + topping + Environment.NewLine;
                        }
                    }
                }

                tempQueue.Enqueue(customer.GetPreviousOrders.Peek());
                customer.GetPreviousOrders.Dequeue();

                order = customer.GetPreviousOrders.Peek();
                foreach (MenuItem item in order.currentOrder)
                {
                    if (item.ItemName != SmallPizzaText.Text && item.ItemName != MediumPizzaText.Text && item.ItemName != LargePizzaText.Text && item.ItemName != ExtraLargePizzaText.Text)
                    {
                        PreviousOrder2Label.Text += item.ItemQuantity + " " + item.ItemName + " $"
                            + item.ItemPrice * item.ItemQuantity + Environment.NewLine;
                    }
                    else
                    {
                        PreviousOrder2Label.Text += item.ItemQuantity + " " + item.ItemName + " $" + item.ItemPrice * item.ItemQuantity + Environment.NewLine;
                        PreviousOrder2Label.Text += "   " + item.CrustOption + Environment.NewLine;

                        foreach (string topping in item.Toppings)
                        {
                            PreviousOrder2Label.Text += "   " + topping + Environment.NewLine;
                        }
                    }
                }

                tempQueue.Enqueue(customer.GetPreviousOrders.Peek());
                customer.GetPreviousOrders.Dequeue();

                while(tempQueue.Count > 0)
                {
                    customer.GetPreviousOrders.Enqueue(tempQueue.Peek());
                    tempQueue.Dequeue();
                }
            }
            else if(customer.GetPreviousOrders.Count == 3)
            {
                Queue<Order> tempQueue = new Queue<Order>();

                Order order = customer.GetPreviousOrders.Peek();
                foreach (MenuItem item in order.currentOrder)
                {
                    if (item.ItemName != SmallPizzaText.Text && item.ItemName != MediumPizzaText.Text && item.ItemName != LargePizzaText.Text && item.ItemName != ExtraLargePizzaText.Text)
                    {
                        PreviousOrder1Label.Text += item.ItemQuantity + " " + item.ItemName + " $"
                            + item.ItemPrice * item.ItemQuantity + Environment.NewLine;
                    }
                    else
                    {
                        PreviousOrder1Label.Text += item.ItemQuantity + " " + item.ItemName + " $" + item.ItemPrice * item.ItemQuantity + Environment.NewLine;
                        PreviousOrder1Label.Text += "   " + item.CrustOption + Environment.NewLine;

                        foreach (string topping in item.Toppings)
                        {
                            PreviousOrder1Label.Text += "   " + topping + Environment.NewLine;
                        }
                    }
                }

                tempQueue.Enqueue(customer.GetPreviousOrders.Peek());
                customer.GetPreviousOrders.Dequeue();

                order = customer.GetPreviousOrders.Peek();
                foreach (MenuItem item in order.currentOrder)
                {
                    if (item.ItemName != SmallPizzaText.Text && item.ItemName != MediumPizzaText.Text && item.ItemName != LargePizzaText.Text && item.ItemName != ExtraLargePizzaText.Text)
                    {
                        PreviousOrder2Label.Text += item.ItemQuantity + " " + item.ItemName + " $"
                            + item.ItemPrice * item.ItemQuantity + Environment.NewLine;
                    }
                    else
                    {
                        PreviousOrder2Label.Text += item.ItemQuantity + " " + item.ItemName + " $" + item.ItemPrice * item.ItemQuantity + Environment.NewLine;
                        PreviousOrder2Label.Text += "   " + item.CrustOption + Environment.NewLine;

                        foreach (string topping in item.Toppings)
                        {
                            PreviousOrder2Label.Text += "   " + topping + Environment.NewLine;
                        }
                    }
                }

                tempQueue.Enqueue(customer.GetPreviousOrders.Peek());
                customer.GetPreviousOrders.Dequeue();

                order = customer.GetPreviousOrders.Peek();
                foreach (MenuItem item in order.currentOrder)
                {
                    if (item.ItemName != SmallPizzaText.Text && item.ItemName != MediumPizzaText.Text && item.ItemName != LargePizzaText.Text && item.ItemName != ExtraLargePizzaText.Text)
                    {
                        PreviousOrder3Label.Text += item.ItemQuantity + " " + item.ItemName + " $"
                            + item.ItemPrice * item.ItemQuantity + Environment.NewLine;
                    }
                    else
                    {
                        PreviousOrder3Label.Text += item.ItemQuantity + " " + item.ItemName + " $" + item.ItemPrice * item.ItemQuantity + Environment.NewLine;
                        PreviousOrder3Label.Text += "   " + item.CrustOption + Environment.NewLine;

                        foreach (string topping in item.Toppings)
                        {
                            PreviousOrder3Label.Text += "   " + topping + Environment.NewLine;
                        }
                    }
                }

                tempQueue.Enqueue(customer.GetPreviousOrders.Peek());
                customer.GetPreviousOrders.Dequeue();

                while (tempQueue.Count > 0)
                {
                    customer.GetPreviousOrders.Enqueue(tempQueue.Peek());
                    tempQueue.Dequeue();
                }
            }
        }

        private void PreviousOrderXButton_Click(object sender, EventArgs e)
        {
            PreviousOrders.Visible = false;
            PreviousOrder1Label.Text = string.Empty;
            PreviousOrder2Label.Text = string.Empty;
            PreviousOrder3Label.Text = string.Empty;
            PreviousOrders.Enabled = false;
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

        /// <summary>
        /// CheckoutButton_Click makes sure the user has added at least one order to the cart before allowing them to continue to pay.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            if (currentOrder.currentOrder.Count <= 0) return;
            this.Hide();
            Payment payment = new Payment();
            payment.SetOrder(GetOrder());
            payment.SetCustomer(GetCustomer());
            payment.Show();
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            currentOrder.currentOrder.Clear();
            PrintOrder();
        }

        /// <summary>
        /// SmallCheese_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmallCheese_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(SmallCheese, lastSmallCheeseSelection, activeSmallComboBoxes);

            if (SmallCheese.FindString("Extra") == SmallCheese.SelectedIndex)
            {
                float total = float.Parse(SmallPizzaPrice.Text.Substring(1)) + .50f;
                SmallPizzaPrice.Text = "$" + total;
            }
            else if (!SmallPizzaPrice.Text.Equals("$4") && lastSmallCheeseSelection == SmallCheese.FindString("Extra"))
            {
                float total = float.Parse(SmallPizzaPrice.Text.Substring(1)) - 0.50f;
                SmallPizzaPrice.Text = "$" + total;
            }

            lastSmallCheeseSelection = SmallCheese.SelectedIndex;
        }

        /// <summary>
        /// SmallPepperoni_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmallPepperoni_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(SmallPepperoni, lastSmallPepSelection, activeSmallComboBoxes);

            if (SmallPepperoni.FindString("Extra") == SmallPepperoni.SelectedIndex)
            {
                float total = float.Parse(SmallPizzaPrice.Text.Substring(1)) + .50f;
                SmallPizzaPrice.Text = "$" + total;
            }
            else if (!SmallPizzaPrice.Text.Equals("$4") && (lastSmallPepSelection == SmallPepperoni.FindString("Extra")))
            {
                float total = float.Parse(SmallPizzaPrice.Text.Substring(1)) - 0.50f;
                SmallPizzaPrice.Text = "$" + total;
            }

            lastSmallPepSelection = SmallPepperoni.SelectedIndex;
        }

        /// <summary>
        /// SmallSausage_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmallSausage_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(SmallSausage, lastSmallSausageSelection, activeSmallComboBoxes);

            if (SmallSausage.FindString("Extra") == SmallSausage.SelectedIndex)
            {
                float total = float.Parse(SmallPizzaPrice.Text.Substring(1)) + .50f;
                SmallPizzaPrice.Text = "$" + total;
            }
            else if (!SmallPizzaPrice.Text.Equals("$4") && lastSmallSausageSelection == SmallSausage.FindString("Extra"))
            {
                float total = float.Parse(SmallPizzaPrice.Text.Substring(1)) - 0.50f;
                SmallPizzaPrice.Text = "$" + total;
            }
            lastSmallSausageSelection = SmallSausage.SelectedIndex;
        }

        /// <summary>
        /// SmallHam_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmallHam_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(SmallHam, lastSmallHamSelection, activeSmallComboBoxes);

            if (SmallHam.FindString("Extra") == SmallHam.SelectedIndex)
            {
                float total = float.Parse(SmallPizzaPrice.Text.Substring(1)) + .50f;
                SmallPizzaPrice.Text = "$" + total;
            }
            else if (!SmallPizzaPrice.Text.Equals("$4") && lastSmallHamSelection == SmallHam.FindString("Extra"))
            {
                float total = float.Parse(SmallPizzaPrice.Text.Substring(1)) - 0.50f;
                SmallPizzaPrice.Text = "$" + total;
            }
            lastSmallHamSelection = SmallHam.SelectedIndex;
        }

        /// <summary>
        /// SmallOnion_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmallOnion_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(SmallOnion, lastSmallOnionSelection, activeSmallComboBoxes);

            if (SmallOnion.FindString("Extra") == SmallOnion.SelectedIndex)
            {
                float total = float.Parse(SmallPizzaPrice.Text.Substring(1)) + .50f;
                SmallPizzaPrice.Text = "$" + total;
            }
            else if (!SmallPizzaPrice.Text.Equals("$4") && lastSmallOnionSelection == SmallOnion.FindString("Extra"))
            {
                float total = float.Parse(SmallPizzaPrice.Text.Substring(1)) - 0.50f;
                SmallPizzaPrice.Text = "$" + total;
            }
            lastSmallOnionSelection = SmallOnion.SelectedIndex;
        }

        /// <summary>
        /// SmallGreenPepper_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmallGreenPepper_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(SmallGreenPepper, lastSmallGPSelection, activeSmallComboBoxes);

            if (SmallGreenPepper.FindString("Extra") == SmallGreenPepper.SelectedIndex)
            {
                float total = float.Parse(SmallPizzaPrice.Text.Substring(1)) + .50f;
                SmallPizzaPrice.Text = "$" + total;
            }
            else if (!SmallPizzaPrice.Text.Equals("$4") && lastSmallGPSelection == SmallGreenPepper.FindString("Extra"))
            {
                float total = float.Parse(SmallPizzaPrice.Text.Substring(1)) - 0.50f;
                SmallPizzaPrice.Text = "$" + total;
            }
            lastSmallGPSelection = SmallGreenPepper.SelectedIndex;
        }

        /// <summary>
        /// SmallTomato_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmallTomato_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(SmallTomato, lastSmallTomatoSelection, activeSmallComboBoxes);

            if (SmallTomato.FindString("Extra") == SmallTomato.SelectedIndex)
            {
                float total = float.Parse(SmallPizzaPrice.Text.Substring(1)) + .50f;
                SmallPizzaPrice.Text = "$" + total;
            }
            else if (!SmallPizzaPrice.Text.Equals("$4") && lastSmallTomatoSelection == SmallTomato.FindString("Extra"))
            {
                float total = float.Parse(SmallPizzaPrice.Text.Substring(1)) - 0.50f;
                SmallPizzaPrice.Text = "$" + total;
            }
            lastSmallTomatoSelection = SmallTomato.SelectedIndex;
        }

        /// <summary>
        /// SmallMushroom_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmallMushroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(SmallMushroom, lastSmallMushroomSelection, activeSmallComboBoxes);


            if (SmallMushroom.FindString("Extra") == SmallMushroom.SelectedIndex)
            {
                float total = float.Parse(SmallPizzaPrice.Text.Substring(1)) + .50f;
                SmallPizzaPrice.Text = "$" + total;
            }
            else if (!SmallPizzaPrice.Text.Equals("$4") && lastSmallMushroomSelection == SmallMushroom.FindString("Extra"))
            {
                float total = float.Parse(SmallPizzaPrice.Text.Substring(1)) - 0.50f;
                SmallPizzaPrice.Text = "$" + total;
            }
            lastSmallMushroomSelection = SmallMushroom.SelectedIndex;
        }

        /// <summary>
        /// SmallPineapple_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmallPineapple_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(SmallPineapple, lastSmallPineappleSelection, activeSmallComboBoxes);

            if (SmallPineapple.FindString("Extra") == SmallPineapple.SelectedIndex)
            {
                float total = float.Parse(SmallPizzaPrice.Text.Substring(1)) + .50f;
                SmallPizzaPrice.Text = "$" + total;
            }
            else if (!SmallPizzaPrice.Text.Equals("$4") && lastSmallPineappleSelection == SmallPineapple.FindString("Extra"))
            {
                float total = float.Parse(SmallPizzaPrice.Text.Substring(1)) - 0.50f;
                SmallPizzaPrice.Text = "$" + total;
            }
            lastSmallPineappleSelection = SmallPineapple.SelectedIndex;
        }

        /// <summary>
        /// MediumCheese_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MediumCheese_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(MediumCheese, lastMedCheeseSelection, activeMediumComboBoxes);

            if (MediumCheese.FindString("Extra") == MediumCheese.SelectedIndex)
            {
                float total = float.Parse(MediumPizzaPrice.Text.Substring(1)) + .75f;
                MediumPizzaPrice.Text = "$" + total;
            }
            else if (!MediumPizzaPrice.Text.Equals("$6") && lastMedCheeseSelection == MediumCheese.FindString("Extra"))
            {
                float total = float.Parse(MediumPizzaPrice.Text.Substring(1)) - 0.75f;
                MediumPizzaPrice.Text = "$" + total;
            }
            lastMedCheeseSelection = MediumCheese.SelectedIndex;
        }

        /// <summary>
        /// MediumPepperoni_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MediumPepperoni_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(MediumPepperoni, lastMedPepSelection, activeMediumComboBoxes);

            if (MediumPepperoni.FindString("Extra") == MediumPepperoni.SelectedIndex)
            {
                float total = float.Parse(MediumPizzaPrice.Text.Substring(1)) + .75f;
                MediumPizzaPrice.Text = "$" + total;
            }
            else if (!MediumPizzaPrice.Text.Equals("$6") && lastMedPepSelection == MediumPepperoni.FindString("Extra"))
            {
                float total = float.Parse(MediumPizzaPrice.Text.Substring(1)) - 0.75f;
                MediumPizzaPrice.Text = "$" + total;
            }
            lastMedPepSelection = MediumPepperoni.SelectedIndex;
        }

        /// <summary>
        /// MediumSausage_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MediumSausage_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(MediumSausage, lastMedSausageSelection, activeMediumComboBoxes);

            if (MediumSausage.FindString("Extra") == MediumSausage.SelectedIndex)
            {
                float total = float.Parse(MediumPizzaPrice.Text.Substring(1)) + .75f;
                MediumPizzaPrice.Text = "$" + total;
            }
            else if (!MediumPizzaPrice.Text.Equals("$6") && lastMedSausageSelection == MediumSausage.FindString("Extra"))
            {
                float total = float.Parse(MediumPizzaPrice.Text.Substring(1)) - 0.75f;
                MediumPizzaPrice.Text = "$" + total;
            }
            lastMedSausageSelection = MediumSausage.SelectedIndex;
        }

        /// <summary>
        /// MediumHam_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MediumHam_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(MediumHam, lastMedHamSelection, activeMediumComboBoxes);

            if (MediumHam.FindString("Extra") == MediumHam.SelectedIndex)
            {
                float total = float.Parse(MediumPizzaPrice.Text.Substring(1)) + .75f;
                MediumPizzaPrice.Text = "$" + total;
            }
            else if (!MediumPizzaPrice.Text.Equals("$6") && lastMedHamSelection == MediumHam.FindString("Extra"))
            {
                float total = float.Parse(MediumPizzaPrice.Text.Substring(1)) - 0.75f;
                MediumPizzaPrice.Text = "$" + total;
            }
            lastMedHamSelection = MediumHam.SelectedIndex;
        }

        /// <summary>
        /// MediumOnion_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MediumOnion_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(MediumOnion, lastMedOnionSelection, activeMediumComboBoxes);

            if (MediumOnion.FindString("Extra") == MediumOnion.SelectedIndex)
            {
                float total = float.Parse(MediumPizzaPrice.Text.Substring(1)) + .75f;
                MediumPizzaPrice.Text = "$" + total;
            }
            else if (!MediumPizzaPrice.Text.Equals("$6") && lastMedOnionSelection == MediumOnion.FindString("Extra"))
            {
                float total = float.Parse(MediumPizzaPrice.Text.Substring(1)) - 0.75f;
                MediumPizzaPrice.Text = "$" + total;
            }
            lastMedOnionSelection = MediumOnion.SelectedIndex;
        }

        /// <summary>
        /// MediumGreenPepper_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MediumGreenPepper_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(MediumGreenPepper, lastMedPepSelection, activeMediumComboBoxes);

            if (MediumGreenPepper.FindString("Extra") == MediumGreenPepper.SelectedIndex)
            {
                float total = float.Parse(MediumPizzaPrice.Text.Substring(1)) + .75f;
                MediumPizzaPrice.Text = "$" + total;
            }
            else if (!MediumPizzaPrice.Text.Equals("$6") && lastMedGPSelection == MediumGreenPepper.FindString("Extra"))
            {
                float total = float.Parse(MediumPizzaPrice.Text.Substring(1)) - 0.75f;
                MediumPizzaPrice.Text = "$" + total;
            }
            lastMedGPSelection = MediumGreenPepper.SelectedIndex;
        }

        /// <summary>
        /// MediumTomato_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MediumTomato_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(MediumTomato, lastMedTomatoSelection, activeMediumComboBoxes);

            if (MediumTomato.FindString("Extra") == MediumTomato.SelectedIndex)
            {
                float total = float.Parse(MediumPizzaPrice.Text.Substring(1)) + .75f;
                MediumPizzaPrice.Text = "$" + total;
            }
            else if (!MediumPizzaPrice.Text.Equals("$6") && lastMedTomatoSelection == MediumTomato.FindString("Extra"))
            {
                float total = float.Parse(MediumPizzaPrice.Text.Substring(1)) - 0.75f;
                MediumPizzaPrice.Text = "$" + total;
            }
            lastMedTomatoSelection = MediumTomato.SelectedIndex;
        }

        /// <summary>
        /// MediumMushroom_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MediumMushroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(MediumMushroom, lastMedMushroomSelection, activeMediumComboBoxes);

            if (MediumMushroom.FindString("Extra") == MediumMushroom.SelectedIndex)
            {
                float total = float.Parse(MediumPizzaPrice.Text.Substring(1)) + .75f;
                MediumPizzaPrice.Text = "$" + total;
            }
            else if (!MediumPizzaPrice.Text.Equals("$6") && lastMedMushroomSelection == MediumMushroom.FindString("Extra"))
            {
                float total = float.Parse(MediumPizzaPrice.Text.Substring(1)) - 0.75f;
                MediumPizzaPrice.Text = "$" + total;
            }
            lastMedMushroomSelection = MediumMushroom.SelectedIndex;
        }

        /// <summary>
        /// MediumPineapple_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MediumPineapple_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(MediumPineapple, lastMedPineappleSelection, activeMediumComboBoxes);

            if (MediumPineapple.FindString("Extra") == MediumPineapple.SelectedIndex)
            {
                float total = float.Parse(MediumPizzaPrice.Text.Substring(1)) + .75f;
                MediumPizzaPrice.Text = "$" + total;
            }
            else if (!MediumPizzaPrice.Text.Equals("$6") && lastMedPineappleSelection == MediumPineapple.FindString("Extra"))
            {
                float total = float.Parse(MediumPizzaPrice.Text.Substring(1)) - 0.75f;
                MediumPizzaPrice.Text = "$" + total;
            }
            lastMedPineappleSelection = MediumPineapple.SelectedIndex;
        }

        /// <summary>
        /// LargeCheese_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LargeCheese_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(LargeCheese, lastLargeCheeseSelection, activeLargeComboBoxes);

            if (LargeCheese.FindString("Extra") == LargeCheese.SelectedIndex)
            {
                float total = float.Parse(LargePizzaPrice.Text.Substring(1)) + .75f;
                LargePizzaPrice.Text = "$" + total;
            }
            else if (!LargePizzaPrice.Text.Equals("$8") && lastLargeCheeseSelection == LargeCheese.FindString("Extra"))
            {
                float total = float.Parse(LargePizzaPrice.Text.Substring(1)) - 0.75f;
                LargePizzaPrice.Text = "$" + total;
            }
            lastLargeCheeseSelection = LargeCheese.SelectedIndex;
        }

        /// <summary>
        /// LargePepperoni_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LargePepperoni_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(LargePepperoni, lastLargePepSelection, activeLargeComboBoxes);

            if (LargePepperoni.FindString("Extra") == LargePepperoni.SelectedIndex)
            {
                float total = float.Parse(LargePizzaPrice.Text.Substring(1)) + .75f;
                LargePizzaPrice.Text = "$" + total;
            }
            else if (!LargePizzaPrice.Text.Equals("$8") && lastLargePepSelection == LargePepperoni.FindString("Extra"))
            {
                float total = float.Parse(LargePizzaPrice.Text.Substring(1)) - 0.75f;
                LargePizzaPrice.Text = "$" + total;
            }
            lastLargePepSelection = LargePepperoni.SelectedIndex;
        }

        /// <summary>
        /// LargeSausage_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LargeSausage_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(LargeSausage, lastLargeSausageSelection, activeLargeComboBoxes);

            if (LargeSausage.FindString("Extra") == LargeSausage.SelectedIndex)
            {
                float total = float.Parse(LargePizzaPrice.Text.Substring(1)) + .75f;
                LargePizzaPrice.Text = "$" + total;
            }
            else if (!LargePizzaPrice.Text.Equals("$8") && lastLargeSausageSelection == LargeSausage.FindString("Extra"))
            {
                float total = float.Parse(LargePizzaPrice.Text.Substring(1)) - 0.75f;
                LargePizzaPrice.Text = "$" + total;
            }
            lastLargeSausageSelection = LargeSausage.SelectedIndex;
        }

        /// <summary>
        /// LargeHam_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LargeHam_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(LargeHam, lastLargeHamSelection, activeLargeComboBoxes);

            if (LargeHam.FindString("Extra") == LargeHam.SelectedIndex)
            {
                float total = float.Parse(LargePizzaPrice.Text.Substring(1)) + .75f;
                LargePizzaPrice.Text = "$" + total;
            }
            else if (!LargePizzaPrice.Text.Equals("$8") && lastLargeHamSelection == LargeHam.FindString("Extra"))
            {
                float total = float.Parse(LargePizzaPrice.Text.Substring(1)) - 0.75f;
                LargePizzaPrice.Text = "$" + total;
            }
            lastLargeHamSelection = LargeHam.SelectedIndex;
        }

        /// <summary>
        /// LargeOnion_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LargeOnion_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(LargeOnion, lastLargeOnionSelection, activeLargeComboBoxes);

            if (LargeOnion.FindString("Extra") == LargeOnion.SelectedIndex)
            {
                float total = float.Parse(LargePizzaPrice.Text.Substring(1)) + .75f;
                LargePizzaPrice.Text = "$" + total;
            }
            else if (!LargePizzaPrice.Text.Equals("$8") && lastLargeOnionSelection == LargeOnion.FindString("Extra"))
            {
                float total = float.Parse(LargePizzaPrice.Text.Substring(1)) - 0.75f;
                LargePizzaPrice.Text = "$" + total;
            }
            lastLargeOnionSelection = LargeOnion.SelectedIndex;
        }

        /// <summary>
        /// LargeGreenPepper_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LargeGreenPepper_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(LargeGreenPepper, lastLargeGPSelection, activeLargeComboBoxes);

            if (LargeGreenPepper.FindString("Extra") == LargeGreenPepper.SelectedIndex)
            {
                float total = float.Parse(LargePizzaPrice.Text.Substring(1)) + .75f;
                LargePizzaPrice.Text = "$" + total;
            }
            else if (!LargePizzaPrice.Text.Equals("$8") && lastLargeGPSelection == LargeGreenPepper.FindString("Extra"))
            {
                float total = float.Parse(LargePizzaPrice.Text.Substring(1)) - 0.75f;
                LargePizzaPrice.Text = "$" + total;
            }
            lastLargeGPSelection = LargeGreenPepper.SelectedIndex;
        }

        /// <summary>
        /// LargeTomato_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LargeTomato_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(LargeTomato, lastLargeTomatoSelection, activeLargeComboBoxes);

            if (LargeTomato.FindString("Extra") == LargeTomato.SelectedIndex)
            {
                float total = float.Parse(LargePizzaPrice.Text.Substring(1)) + .75f;
                LargePizzaPrice.Text = "$" + total;
            }
            else if (!LargePizzaPrice.Text.Equals("$8") && lastLargeTomatoSelection == LargeTomato.FindString("Extra"))
            {
                float total = float.Parse(LargePizzaPrice.Text.Substring(1)) - 0.75f;
                LargePizzaPrice.Text = "$" + total;
            }
            lastLargeTomatoSelection = LargeTomato.SelectedIndex;
        }

        /// <summary>
        /// LargeMushroom_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LargeMushroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(LargeMushroom, lastLargeMushroomSelection, activeLargeComboBoxes);

            if (LargeMushroom.FindString("Extra") == LargeMushroom.SelectedIndex)
            {
                float total = float.Parse(LargePizzaPrice.Text.Substring(1)) + .75f;
                LargePizzaPrice.Text = "$" + total;
            }
            else if (!LargePizzaPrice.Text.Equals("$8") && lastLargeMushroomSelection == LargeMushroom.FindString("Extra"))
            {
                float total = float.Parse(LargePizzaPrice.Text.Substring(1)) - 0.75f;
                LargePizzaPrice.Text = "$" + total;
            }
            lastLargeMushroomSelection = LargeMushroom.SelectedIndex;
        }

        /// <summary>
        /// LargePineapple_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LargePineapple_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(LargePineapple, lastLargePineappleSelection, activeLargeComboBoxes);

            if (LargePineapple.FindString("Extra") == LargePineapple.SelectedIndex)
            {
                float total = float.Parse(LargePizzaPrice.Text.Substring(1)) + .75f;
                LargePizzaPrice.Text = "$" + total;
            }
            else if (!LargePizzaPrice.Text.Equals("$8") && lastLargePineappleSelection == LargePineapple.FindString("Extra"))
            {
                float total = float.Parse(LargePizzaPrice.Text.Substring(1)) - 0.75f;
                LargePizzaPrice.Text = "$" + total;
            }
            lastLargePineappleSelection = LargePineapple.SelectedIndex;
        }

        /// <summary>
        /// ExtraLargeCheese_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExtraLargeCheese_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(ExtraLargeCheese, lastXLCheeseSelection, activeExtraLargeComboBoxes);

            if (ExtraLargeCheese.FindString("Extra") == ExtraLargeCheese.SelectedIndex)
            {
                float total = float.Parse(ExtraLargePizzaPrice.Text.Substring(1)) + 1f;
                ExtraLargePizzaPrice.Text = "$" + total;
            }
            else if (!ExtraLargePizzaPrice.Text.Equals("$8") && lastXLCheeseSelection == ExtraLargeCheese.FindString("Extra"))
            {
                float total = float.Parse(ExtraLargePizzaPrice.Text.Substring(1)) - 1f;
                ExtraLargePizzaPrice.Text = "$" + total;
            }
            lastXLCheeseSelection = ExtraLargeCheese.SelectedIndex;
        }

        /// <summary>
        /// ExtraLargePepperoni_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExtraLargePepperoni_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(ExtraLargePepperoni, lastXLPepSelection, activeExtraLargeComboBoxes);

            if (ExtraLargePepperoni.FindString("Extra") == ExtraLargePepperoni.SelectedIndex)
            {
                float total = float.Parse(ExtraLargePizzaPrice.Text.Substring(1)) + 1f;
                ExtraLargePizzaPrice.Text = "$" + total;
            }
            else if (!ExtraLargePizzaPrice.Text.Equals("$8") && lastXLPepSelection == ExtraLargePepperoni.FindString("Extra"))
            {
                float total = float.Parse(ExtraLargePizzaPrice.Text.Substring(1)) - 1f;
                ExtraLargePizzaPrice.Text = "$" + total;
            }
            lastXLPepSelection = ExtraLargePepperoni.SelectedIndex;
        }

        /// <summary>
        /// ExtraLargeHam_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExtraLargeSausage_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(ExtraLargeSausage, lastXLSausageSelection, activeExtraLargeComboBoxes);

            if (ExtraLargeSausage.FindString("Extra") == ExtraLargeSausage.SelectedIndex)
            {
                float total = float.Parse(ExtraLargePizzaPrice.Text.Substring(1)) + 1f;
                ExtraLargePizzaPrice.Text = "$" + total;
            }
            else if (!ExtraLargePizzaPrice.Text.Equals("$8") && lastXLSausageSelection == ExtraLargeSausage.FindString("Extra"))
            {
                float total = float.Parse(ExtraLargePizzaPrice.Text.Substring(1)) - 1f;
                ExtraLargePizzaPrice.Text = "$" + total;
            }
            lastXLSausageSelection = ExtraLargeSausage.SelectedIndex;
        }

        /// <summary>
        /// ExtraLargeHam_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExtraLargeHam_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(ExtraLargeHam, lastXLHamSelection, activeExtraLargeComboBoxes);

            if (ExtraLargeHam.FindString("Extra") == ExtraLargeHam.SelectedIndex)
            {
                float total = float.Parse(ExtraLargePizzaPrice.Text.Substring(1)) + 1f;
                ExtraLargePizzaPrice.Text = "$" + total;
            }
            else if (!ExtraLargePizzaPrice.Text.Equals("$8") && lastXLHamSelection == ExtraLargeHam.FindString("Extra"))
            {
                float total = float.Parse(ExtraLargePizzaPrice.Text.Substring(1)) - 1f;
                ExtraLargePizzaPrice.Text = "$" + total;
            }
            lastXLHamSelection = ExtraLargeHam.SelectedIndex;
        }

        private void ExtraLargeOnion_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(ExtraLargeOnion, lastXLOnionSelection, activeExtraLargeComboBoxes);

            if (ExtraLargeOnion.FindString("Extra") == ExtraLargeOnion.SelectedIndex)
            {
                float total = float.Parse(ExtraLargePizzaPrice.Text.Substring(1)) + .75f;
                ExtraLargePizzaPrice.Text = "$" + total;
            }
            else if (!ExtraLargePizzaPrice.Text.Equals("$8") && lastXLOnionSelection == ExtraLargeOnion.FindString("Extra"))
            {
                float total = float.Parse(ExtraLargePizzaPrice.Text.Substring(1)) - 0.75f;
                ExtraLargePizzaPrice.Text = "$" + total;
            }
            lastXLOnionSelection = ExtraLargeOnion.SelectedIndex;
        }

        /// <summary>
        /// ExtraLargeGreenPepper_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExtraLargeGreenPepper_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(ExtraLargeGreenPepper, lastXLGPSelection, activeExtraLargeComboBoxes);

            if (ExtraLargeGreenPepper.FindString("Extra") == ExtraLargeGreenPepper.SelectedIndex)
            {
                float total = float.Parse(ExtraLargePizzaPrice.Text.Substring(1)) + 1f;
                ExtraLargePizzaPrice.Text = "$" + total;
            }
            else if (!ExtraLargePizzaPrice.Text.Equals("$8") && lastXLGPSelection == ExtraLargeGreenPepper.FindString("Extra"))
            {
                float total = float.Parse(ExtraLargePizzaPrice.Text.Substring(1)) - 1f;
                ExtraLargePizzaPrice.Text = "$" + total;
            }
            lastXLGPSelection = ExtraLargeGreenPepper.SelectedIndex;
        }

        /// <summary>
        /// ExtraLargeTomato_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExtraLargeTomato_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(ExtraLargeTomato, lastXLTomatoSelection, activeExtraLargeComboBoxes);

            if (ExtraLargeTomato.FindString("Extra") == ExtraLargeTomato.SelectedIndex)
            {
                float total = float.Parse(ExtraLargePizzaPrice.Text.Substring(1)) + 1f;
                ExtraLargePizzaPrice.Text = "$" + total;
            }
            else if (!ExtraLargePizzaPrice.Text.Equals("$8") && lastXLTomatoSelection == ExtraLargeTomato.FindString("Extra"))
            {
                float total = float.Parse(ExtraLargePizzaPrice.Text.Substring(1)) - 1f;
                ExtraLargePizzaPrice.Text = "$" + total;
            }
            lastXLTomatoSelection = ExtraLargeTomato.SelectedIndex;
        }

        /// <summary>
        /// ExtraLargeMushroom_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExtraLargeMushroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(ExtraLargeMushroom, lastXLMushroomSelection, activeExtraLargeComboBoxes);

            if (ExtraLargeMushroom.FindString("Extra") == ExtraLargeMushroom.SelectedIndex)
            {
                float total = float.Parse(ExtraLargePizzaPrice.Text.Substring(1)) + 1f;
                ExtraLargePizzaPrice.Text = "$" + total;
            }
            else if (!ExtraLargePizzaPrice.Text.Equals("$8") && lastXLMushroomSelection == ExtraLargeMushroom.FindString("Extra"))
            {
                float total = float.Parse(ExtraLargePizzaPrice.Text.Substring(1)) - 1f;
                ExtraLargePizzaPrice.Text = "$" + total;
            }
            lastXLMushroomSelection = ExtraLargeMushroom.SelectedIndex;
        }

        /// <summary>
        /// ExtraLargePineapple_SelectedIndexChanges is called wheenver the combo boxes selected index is changed. It calls CheckComboBoxes and then checks the following:
        /// If the customers orders "Extra" it adds the corresponding amount based on pizza size to the total.
        /// If the customer had it selected as "Extra" before but changes it, it subtracts the added amount from the total.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExtraLargePineapple_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBoxes(ExtraLargePineapple, lastXLPineappleSelection, activeExtraLargeComboBoxes);

            if (ExtraLargePineapple.FindString("Extra") == ExtraLargePineapple.SelectedIndex)
            {
                float total = float.Parse(ExtraLargePizzaPrice.Text.Substring(1)) + 1f;
                ExtraLargePizzaPrice.Text = "$" + total;
            }
            else if (!ExtraLargePizzaPrice.Text.Equals("$8") && lastXLPineappleSelection == ExtraLargePineapple.FindString("Extra"))
            {
                float total = float.Parse(ExtraLargePizzaPrice.Text.Substring(1)) - 1f;
                ExtraLargePizzaPrice.Text = "$" + total;
            }
            lastXLPineappleSelection = ExtraLargePineapple.SelectedIndex;
        }

        public Customer GetCustomer()
        {
            return customer;
        }

        public void SetCustomer(Customer cust)
        {
            customer = cust;
        }

        /// <summary>
        /// PreviousOrderOneAddToCart_Click is adds the second previous order to the current order. It creates a temp queue which holds the values of the previous order
        /// queue so the third value can be accessed. Then it goes through and adds each menu item in the order to the list and reassigns all the values of previous order to
        /// previousOrder.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviousOrderOneAddToCart_Click(object sender, EventArgs e)
        {
            Order order = customer.GetPreviousOrders.Peek();
            foreach (MenuItem m in order.currentOrder)
            {
                currentOrder.AddToOrder(m);
            }
        }

        /// <summary>
        /// PreviousOrderTwoAddToCart_Click adds the first previous order to the current order. It goes through and assigns each menu item from the previous order to the 
        /// current order.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviousOrderTwoAddToCart_Click(object sender, EventArgs e)
        {
            Queue<Order> tempQueue = new Queue<Order>();
            tempQueue.Enqueue(customer.GetPreviousOrders.Peek());
            customer.GetPreviousOrders.Dequeue();

            Order order = customer.GetPreviousOrders.Peek();
            foreach (MenuItem m in order.currentOrder)
            {
                currentOrder.AddToOrder(m);
            }

            tempQueue.Enqueue(customer.GetPreviousOrders.Peek());
            customer.GetPreviousOrders.Dequeue();

            while (tempQueue.Count > 0)
            {
                customer.GetPreviousOrders.Enqueue(tempQueue.Peek());
                tempQueue.Dequeue();
            }
        }

        /// <summary>
        /// PreviousOrderaThreeAddToCart_Click is adds the third previous order to the current order. It creates a temp queue which holds the values of the previous order
        /// queue so the third value can be accessed. Then it goes through and adds each menu item in the order to the list and reassigns all the values of previous order to
        /// previousOrder.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviousOrdersThreeAddToCart_Click(object sender, EventArgs e)
        {
            Queue<Order> tempQueue = new Queue<Order>();
            tempQueue.Enqueue(customer.GetPreviousOrders.Peek());
            customer.GetPreviousOrders.Dequeue();

            tempQueue.Enqueue(customer.GetPreviousOrders.Peek());
            customer.GetPreviousOrders.Dequeue();

            Order order = customer.GetPreviousOrders.Peek();
            foreach (MenuItem m in order.currentOrder)
            {
                currentOrder.AddToOrder(m);
            }

            tempQueue.Enqueue(customer.GetPreviousOrders.Peek());
            customer.GetPreviousOrders.Dequeue();

            while (tempQueue.Count > 0)
            {
                customer.GetPreviousOrders.Enqueue(tempQueue.Peek());
                tempQueue.Dequeue();
            }
        }

        /// <summary>
        /// CheckComboBoxes is called whenver a combo box value is changed. The method takes in the target ComboBox, the int for its last selection, and the list 
        /// of active combo boxes based on the boxes size. It will then go in and check multiple things, if the boxes last selection was not none and the current selection is 
        /// none, then it will check and make sure the box is in the current list and will remove it. If the current selection is not none, the current list has less than 4 boxes
        /// in it, and the box is not currently in the list then it will add the box to the list. This makes sure only 4 different combo boxes can be selected at once. Then, if the
        /// following is not true, it checks if the box is not currently in the list and if it is not it changes the index back to its base value which is none.
        /// </summary>
        /// <param name="currentBox"></param>
        /// <param name="lastSelection"></param>
        /// <param name="comboBoxSize"></param>
        private void CheckComboBoxes(ComboBox currentBox, int lastSelection, List<ComboBox> comboBoxSize)
        {
            if (lastSelection != 0 && currentBox.SelectedIndex == 0)//Makes sure the lastSelection was not none and current selection is none before removing box
            {
                if (comboBoxSize.Contains(currentBox))
                {
                    comboBoxSize.Remove(currentBox);
                }
            }

            if (currentBox.SelectedIndex != 0 && comboBoxSize.Count < 4 && !comboBoxSize.Contains(currentBox))
            //Makes sure 4 other combo boxes have been activated and that this box is not in the list already and it is not set to a base value before adding it to list
            {
                comboBoxSize.Add(currentBox);
            }
            else if (!comboBoxSize.Contains(currentBox) && (currentBox != SmallCheese && currentBox != MediumCheese && 
                currentBox != LargeCheese && currentBox != ExtraLargeCheese)) //If the box is not apart of the active list, resets value to a default state
            {
                currentBox.SelectedIndex = 0;
            }
            else
            {
                currentBox.SelectedIndex = 2;
            }
        }
    }
}
