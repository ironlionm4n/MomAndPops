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

    public class MenuItem
    {
        public const float drinkPrice = 1f;

        private float itemQuantity;

        public float ItemQuantity
        {
            get { return itemQuantity; }
            set { itemQuantity = value; }
        }
       
        private string itemName;
        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }
        private float itemPrice;
        public float ItemPrice
        {
            get { return itemPrice; }
            set { itemPrice = value; }
        }
        private int numberOfToppings;
        public int NumberOfToppings
        {
            get { return numberOfToppings; }
            set { numberOfToppings = value; }
        }
        private string itemSize;
        public string ItemSize
        {
            get { return itemSize; }
            set { itemSize = value; }
        }
        private CrustOptions crustOption;
        public CrustOptions CrustOption
        {
            get { return crustOption; }
            set { crustOption = value; }
        }

        public MenuItem(string itemName = "DefaultName", float itemPrice = 999f, int itemQuantity = 0,
            string size = "Medium", int numberOfToppings = 0, CrustOptions crustOption = CrustOptions.Hand)
        {
            ItemName = itemName;
            ItemQuantity = itemQuantity;
            ItemPrice = itemPrice;
            ItemSize = size;
            NumberOfToppings = numberOfToppings;
            CrustOption = crustOption;
        }
    }
}
