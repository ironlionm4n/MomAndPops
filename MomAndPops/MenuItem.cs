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
        private List<string> toppings;
        public List<string> Toppings
        {
            get { return toppings; }
            set { toppings = value; }
        }
        private string itemSize;
        public string ItemSize
        {
            get { return itemSize; }
            set { itemSize = value; }
        }
        private string crustOption;
        public string CrustOption
        {
            get { return crustOption; }
            set { crustOption = value; }
        }

        public MenuItem(string itemName = "DefaultName", float itemPrice = 999f, int itemQuantity = 0,
            string size = "Medium", List<string> numberOfToppings = null, string crustOption = "regular")
        {
            ItemName = itemName;
            ItemQuantity = itemQuantity;
            ItemPrice = itemPrice;
            ItemSize = size;
            Toppings = numberOfToppings;
            CrustOption = crustOption;
        }
    }
}
