using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomAndPops
{
    public enum CrustOptions
    {
        Hand,
        Pan,
        Thin
    }

    class MenuItem
    {
        private int itemQuantity;

        public int ItemQuantity
        {
            get { return itemQuantity; }
            private set { itemQuantity = value; }
        }
       
        private string itemName;
        public string ItemName
        {
            get { return itemName; }
            private set { itemName = value; }
        }
        private float itemPrice;
        public float ItemPrice
        {
            get { return itemPrice; }
            private set { itemPrice = value; }
        }
        private int numberOfToppings;
        public int NumberOfToppings
        {
            get { return numberOfToppings; }
            private set { numberOfToppings = value; }
        }
        private string entreeSize;
        public string EntreeSize
        {
            get { return entreeSize; }
            private set { entreeSize = value; }
        }
        private CrustOptions crustOption;
        public CrustOptions CrustOption
        {
            get { return crustOption; }
            set { crustOption = value; }
        }

        public MenuItem(string itemName = "DefaultName", int itemQuantity = 0, float itemPrice = 999f,
            int numberOfToppings = 0, string entreeSize = "Medium", CrustOptions crustOption = CrustOptions.Hand)
        {
            ItemName = itemName;
            ItemQuantity = itemQuantity;
            ItemPrice = itemPrice;
            NumberOfToppings = numberOfToppings;
            EntreeSize = entreeSize;
            CrustOption = crustOption;
        }
    }
}
