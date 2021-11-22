using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MomAndPops
{
    public class Customer
    {
        string firstName;
        string lastName;
        string phoneNumber;
        string address;
        string apt;
        string zip;
        string city;
        string password;
        Queue<Order> previousOrders = new Queue<Order>();

        public Customer(string firstName, string lastName, string phoneNumber, string address, string apt = "", string zip = "12345", string city = "undefined", string password = "Admin")
        {
            this.firstName = firstName; this.lastName = lastName; this.phoneNumber = phoneNumber; this.address = address; this.apt = apt;
            this.zip = zip; this.city = city; this.password = password;
        }
        public Queue<Order> GetPreviousOrders
        {
            get { return previousOrders; }
        }

        public void WriteToFile(Customer customer)
        {
            string[] customerData = {customer.firstName, customer.lastName, customer.phoneNumber, customer.address,
                customer.apt, customer.zip, customer.city, customer.password};
            if (!File.Exists("CustomerData.txt")) // If file does not exists
            {
                File.Create("CustomerData.txt").Close(); // Create file
                using (StreamWriter sw = File.AppendText("CustomerData.txt"))
                {
                    foreach(string data in customerData)
                    {
                        sw.WriteLine(data);
                    }
                }
            }
            else // If file already exists
            {
                // File.WriteAllText("FILENAME.txt", String.Empty); // Clear file
                using (StreamWriter sw = File.AppendText("CustomerData.txt"))
                {
                    foreach (string data in customerData)
                    {
                        sw.WriteLine(data);
                    }
                }
            }

            /*            //TextWriter textWriter = new StreamWriter(path, true);
                        StreamWriter writer = new StreamWriter("CustomerData.txt", true);
                        writer.WriteLine("Hello World");
                        writer.WriteLine("PLEASE WORK");
                        writer.WriteLine(customer.fullName);
                        writer.WriteLine(customer.phoneNumber);
                        writer.WriteLine(customer.address);
                        foreach(Order order in customer.GetPreviousOrders)
                        {
                            foreach(MenuItem menuItem in order)
                            {
                                writer.WriteLine(menuItem.ItemQuantity + " " + menuItem.ItemName + " $" + menuItem.ItemPrice);
                            }
                        }*/
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
