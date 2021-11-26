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
        /// <summary>
        /// WriteToFile writes the current customer infomation to their own file which is created using their first and last name plus Database Info. 
        /// The customers data, which includes their first name, last name, phone number, password, address, apartment, zip, and city are written to the file.
        /// Then it calls WriteOrder to write the customers last 3 previous orders.
        /// </summary>
        /// <param name="customer"></param>
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

        /// <summary>
        /// AddToPreviousOrders checks if their are already three previous orders stored, if there isn't it adds the passed order.
        /// If there is 3 stored orders it gets rid of the oldest order and replaces it with the new order.
        /// </summary>
        /// <param name="order"></param>
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

        /// <summary>
        /// WriteOrder writes all the customers previousOrders to the file with headers for "Order 1", "Order 2", and "Order 3".
        /// The method goes through and writes each menu item in each order to the file, including each element for name, quantity, price, for drinks is includes size,
        /// and for pizzas it also includes all the toppings.
        /// </summary>
        public void WriteOrder()
        {
            Queue<Order> tempQueue = new Queue<Order>();
            if (previousOrders.Count > 0)
            {
                int counter = 1;
                Order order = previousOrders.Peek();
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
                         sw.WriteLine(order.currentOrder[i].ItemPrice * order.currentOrder[i].ItemQuantity);
                      }
                      else if (!order.currentOrder[i].ItemSize.Equals("none"))
                      {
                         sw.WriteLine(order.currentOrder[i].ItemName + "," + order.currentOrder[i].ItemQuantity + "," +
                                      order.currentOrder[i].ItemSize + "," + order.currentOrder[i].ItemPrice*order.currentOrder[i].ItemQuantity);
                      }
                      else
                      {
                        sw.WriteLine(order.currentOrder[i].ItemName + "," + order.currentOrder[i].ItemQuantity + ","
                                    + order.currentOrder[i].ItemPrice*order.currentOrder[i].ItemQuantity);
                      }
                   }
                   counter++;
                   sw.Close();
                }
                tempQueue.Enqueue(previousOrders.Peek());
            }

            while (tempQueue.Count > 0)
            {
                previousOrders.Enqueue(tempQueue.Peek());
                tempQueue.Dequeue();
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
