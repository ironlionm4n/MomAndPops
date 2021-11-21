using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MomAndPops
{
    public class Customer
    {
        string fullName;
        string phoneNumber;
        string address;
        string apt; 
        Queue<Order> previousOrders = new Queue<Order>();
        //  DirectoryInfo directory = new DirectoryInfo(@"c:\MomAndPopsCustomerData");
        string path = Directory.GetCurrentDirectory() + "\\CustomerData.txt";
        public string GetPath
        {
            get { return path; }
        }
        public Customer(string fullName, string phoneNumber, string address, string apt = "")
        {
            this.fullName = fullName; this.phoneNumber = phoneNumber; this.address = address; this.apt = apt;
        }
        public Queue<Order> GetPreviousOrders
        {
            get { return previousOrders; }
        }

        public void WriteToFile(Customer customer)
        {
            TextWriter textWriter = new StreamWriter(path, true);
            textWriter.WriteLine(customer.fullName);
            textWriter.WriteLine(customer.phoneNumber);
            textWriter.WriteLine(customer.address);
            foreach(Order order in customer.GetPreviousOrders)
            {
                foreach(MenuItem menuItem in order)
                {
                    textWriter.WriteLine(menuItem.ItemQuantity + " " + menuItem.ItemName + " $" + menuItem.ItemPrice);
                }
            }
        }
        public void AddToPreviousOrders(Order order)
        {
            previousOrders.Enqueue(order);
        }

        public void RemoveOldestPreviousOrder()
        {
            previousOrders.Dequeue();
        }
    }
}
