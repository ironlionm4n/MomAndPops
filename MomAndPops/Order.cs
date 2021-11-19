using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomAndPops
{
    public class Order : IEnumerator, IEnumerable
    {
        private string menuItemName;
        public string MenuItemName
        {
            get { return menuItemName; }
            set { menuItemName = value; }
        }

        public List<MenuItem> currentOrder = new List<MenuItem>();

        int index = -1;
        public Order()
        {
           
        }
        public object Current => currentOrder[index];
        public void AddToOrder(MenuItem menuItem)
        {
            currentOrder.Add(menuItem);
        }
        public IEnumerator GetEnumerator()
        {
            return this;
        }
        public bool MoveNext()
        {
            index++;
            return (index < currentOrder.Count);
        }
        public void Reset()
        {
            index = -1;
        }
    }
}
