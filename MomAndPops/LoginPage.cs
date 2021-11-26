using MomAndPops.Resources;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace MomAndPops
{
    public partial class LoginPage : Form
    {
        Customer currentCustomer = new Customer();
        List<Customer> activeCustomers = new List<Customer>();
        public LoginPage()
        {
            InitializeComponent();
            CreatePanel.Hide();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            CreatePanel.Show();
        }



        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool correctPassword = false; 

            foreach(Customer customer in activeCustomers)
            {
                if(customer.GetPhone() == LoginPhoneNumberBox.Text.Trim())
                {
                    Console.WriteLine("Correct number");
                    if (customer.GetPassword() == LoginPasswordBox.Text.Trim())
                    {
                        Console.WriteLine("Correct password");
                        correctPassword = true;
                        currentCustomer = customer;
                    }
                }
            }

            if (correctPassword)
            {
                this.Hide();
                MenuLanding menu = new MenuLanding();
                menu.SetCustomer(GetCustomer());
                menu.ShowDialog();
            }
            else
            {
                LoginPhoneNumberBox.Text = string.Empty;
                LoginPasswordBox.Text = string.Empty;
                IncorrectPass.Visible = true;
            }
        }

        private void CreateSubmitButton_Click(object sender, EventArgs e)
        {
            bool passwordsMatch = CreatePasswordTextBox.Text == CreateConfirmTextBox.Text;
            if (passwordsMatch == false)
            {
                Color mismatchColor = Color.FromArgb(255, 113, 113);
                CreatePasswordTextBox.BackColor = mismatchColor;
                CreateConfirmTextBox.BackColor = mismatchColor;
            }
            if (!CreateFirstTextBox.Text.Equals("") && !CreateLastTextBox.Text.Equals("") && !CreatePhoneTextBox.Text.Equals("")
                && !CreateAddressTextBox.Text.Equals("") && !CreateAptTextBox.Text.Equals("") && !CreateCityTextBox.Text.Equals("")
                && !CreateZipTextBox.Text.Equals("") && !CreatePasswordTextBox.Text.Equals("") && passwordsMatch)
            {
                Customer customer = new Customer(CreateFirstTextBox.Text, CreateLastTextBox.Text, CreatePhoneTextBox.Text, CreateAddressTextBox.Text,
                    CreateAptTextBox.Text, CreateZipTextBox.Text, CreateCityTextBox.Text, CreatePasswordTextBox.Text);
                customer.WriteToFile(customer);
                activeCustomers.Add(customer);
                currentCustomer = customer;
                CreatePanel.Hide();
                CreateFirstTextBox.Text = string.Empty;
                CreateLastTextBox.Text = string.Empty;
                CreatePhoneTextBox.Text = string.Empty;
                CreateAddressTextBox.Text = string.Empty;
                CreateAptTextBox.Text = string.Empty;
                CreateCityTextBox.Text = string.Empty;
                CreateZipTextBox.Text = string.Empty;
                CreatePasswordTextBox.Text = string.Empty;
                CreateConfirmTextBox.Text = string.Empty;
            }
        }

        private void CreateBackButton_Click(object sender, EventArgs e)
        {
            CreatePanel.Hide();
            CreateFirstTextBox.Text = string.Empty;
            CreateLastTextBox.Text = string.Empty;
            CreatePhoneTextBox.Text = string.Empty;
            CreateAddressTextBox.Text = string.Empty;
            CreateAptTextBox.Text = string.Empty;
            CreateCityTextBox.Text = string.Empty;
            CreateZipTextBox.Text = string.Empty;
            CreatePasswordTextBox.Text = string.Empty;
            CreateConfirmTextBox.Text = string.Empty;
        }

        public Customer GetCustomer()
        {
            return currentCustomer;
        }

        public void SetCustomer(Customer customer)
        {
            currentCustomer = customer;
        }

        public void AddCustomer()
        {
            bool usedPhone = false;
            foreach(Customer cust in activeCustomers)
            {
                if(cust.GetPhone() == currentCustomer.GetPhone()) //Compares currentCustomer number to other customer numbers
                {
                    usedPhone = true;
                }
            }

            if(!usedPhone)//If the number is not in the list, adds currentCustomer
            {
                activeCustomers.Add(currentCustomer);
            }
        }
    }
}
