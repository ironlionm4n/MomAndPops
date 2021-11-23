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
                    WriteOrder();
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
                    sw.Close();
                }
                WriteOrder();
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

        public void WriteOrder()
        {
            Order testOrder = new Order();
            MenuItem testMenuitem = new MenuItem("Breadsticks", 4f, 3);
            testOrder.currentOrder.Add(testMenuitem);
            testMenuitem = new MenuItem("Breadstick Bites", 2f, 2);
            testOrder.currentOrder.Add(testMenuitem);
            List<string> top = new List<string>();
            top.Add("Extra Cheese");
            top.Add("Light Ham");
            testMenuitem = new MenuItem("Small Pizza", 5f, 1, "small", top, "thin");
            testOrder.currentOrder.Add(testMenuitem);
            testMenuitem = new MenuItem("Pepsi", 1f, 3, "Large");
            testOrder.currentOrder.Add(testMenuitem);

            previousOrders.Enqueue(testOrder);
            if(previousOrders.Count > 0)
            {
                Queue<Order> tempQueue = previousOrders;
                while (tempQueue.Count > 0)
                {
                    Order order = tempQueue.Peek();
                    using (StreamWriter sw = File.AppendText("CustomerData.txt"))
                    {
                        for(int i = 0; i < order.currentOrder.Count; i++)
                        {
                            if(order.currentOrder[i].ItemName == "Small Pizza" || order.currentOrder[i].ItemName == "Medium Pizza" ||
                                order.currentOrder[i].ItemName == "Large Pizza" || order.currentOrder[i].ItemName == "Extra Large Pizza")
                            {
                                sw.Write(order.currentOrder[i].ItemName + "," + order.currentOrder[i].ItemQuantity + ",");
                                foreach(string t in order.currentOrder[i].Toppings)
                                {
                                    sw.Write(t + ",");
                                }
                                sw.WriteLine(order.currentOrder[i].ItemPrice);
                            }
                            else if(!order.currentOrder[i].ItemSize.Equals("none"))
                            {
                                sw.WriteLine(order.currentOrder[i].ItemName + "," + order.currentOrder[i].ItemQuantity + "," + 
                                    order.currentOrder[i].ItemSize + "," + order.currentOrder[i].ItemPrice);
                            }
                            else
                            {
                                sw.WriteLine(order.currentOrder[i].ItemName + "," + order.currentOrder[i].ItemQuantity + "," 
                                    + order.currentOrder[i].ItemPrice);
                            }
                        }
                        sw.Close();
                    }
                    tempQueue.Dequeue();
                }
               
            }
        }
    }
}
