using System.Collections.Generic;
using System.IO;

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

        public Customer(string firstName = "testFirstName", string lastName = "testLastName", string phoneNumber = "0000000000", string address = "testAddress", string apt = "", string zip = "12345", string city = "undefined", string password = "Admin")
        {
            this.firstName = firstName; this.lastName = lastName; this.phoneNumber = phoneNumber; this.address = address; this.apt = apt;
            this.zip = zip; this.city = city; this.password = password;
        }
        public Queue<Order> GetPreviousOrders
        {
            get { return previousOrders; }
        }
        public string GetPassword()
        {
            return password.Trim();
        }
        public void WriteToFile(Customer customer)
        {
            string[] customerData = {customer.firstName, customer.lastName, customer.phoneNumber, customer.address,
                customer.apt, customer.zip, customer.city, customer.password};
            if (!File.Exists(GetName() + " Database Info.txt")) // If file does not exists
            {
                File.Create(GetName() + " Database Info.txt").Close();// Create file
                using (StreamWriter sw = File.CreateText(GetName() + " Database Info.txt"))
                {
                    foreach (string data in customerData)
                    {
                        sw.WriteLine(data);
                    }
                    sw.Close();
                }
                WriteOrder();
            }
            else // If file already exists
            {
                // File.WriteAllText("FILENAME.txt", String.Empty); // Clear file
                using (StreamWriter sw = File.CreateText(GetName() + " Database Info.txt"))
                {
                    foreach (string data in customerData)
                    {
                        sw.WriteLine(data);
                    }
                    sw.Close();
                }
                WriteOrder();
            }
        }
        public void AddToPreviousOrders(Order order)
        {
            if (previousOrders.Count < 3)
            {
                previousOrders.Enqueue(order);
            }
            else
            {
                RemoveOldestPreviousOrder();
                previousOrders.Enqueue(order);
            }
        }

        public void RemoveOldestPreviousOrder()
        {
            previousOrders.Dequeue();
        }

        public void WriteOrder()
        {
            if (previousOrders.Count > 0)
            {
                int counter = 1;
                Queue<Order> tempQueue = previousOrders;
                Queue<Order> passingQueue = new Queue<Order>();
                while (tempQueue.Count > 0)
                {
                    Order order = tempQueue.Peek();
                    using (StreamWriter sw = File.AppendText(GetName() + " Database Info.txt"))
                    {
                        sw.WriteLine("Order " + counter);
                        for (int i = 0; i < order.currentOrder.Count; i++)
                        {
                            if (order.currentOrder[i].ItemName == "Small Pizza" || order.currentOrder[i].ItemName == "Medium Pizza" ||
                                order.currentOrder[i].ItemName == "Large Pizza" || order.currentOrder[i].ItemName == "Extra Large Pizza")
                            {
                                sw.Write(order.currentOrder[i].ItemName + "," + order.currentOrder[i].ItemQuantity + ",");
                                foreach (string t in order.currentOrder[i].Toppings)
                                {
                                    sw.Write(t + ",");
                                }
                                sw.WriteLine(order.currentOrder[i].ItemPrice);
                            }
                            else if (!order.currentOrder[i].ItemSize.Equals("none"))
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
                        counter++;
                        sw.Close();
                    }
                    passingQueue.Enqueue(tempQueue.Peek());
                    tempQueue.Dequeue();
                }

                while(passingQueue.Count > 0)
                {
                    previousOrders.Enqueue(passingQueue.Peek());
                    passingQueue.Dequeue();
                }

            }
        }

        public string GetName()
        {
            return firstName + " " + lastName;
        }

        public string GetPhone()
        {
            return phoneNumber.Trim();
        }

    }
}
