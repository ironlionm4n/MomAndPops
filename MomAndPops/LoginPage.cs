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

        bool correctNumberFormat = false;
        bool correctZipFormat = false;
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
            else
            {
                Color matchColor = Color.FromArgb(255, 255, 255);
                CreatePasswordTextBox.BackColor = matchColor;
                CreateConfirmTextBox.BackColor = matchColor;
            }

            if (!correctNumberFormat)
            {
                Color incorrectColor = Color.FromArgb(255, 113, 113);
                CreatePhoneTextBox.BackColor = incorrectColor;
            }
            else
            {
                Color correctColor = Color.FromArgb(255, 255, 255);
                CreatePhoneTextBox.BackColor = correctColor;
            }

            if(!correctZipFormat)
            {
                Color incorrectColor = Color.FromArgb(255, 113, 113);
                CreateZipTextBox.BackColor = incorrectColor;
            }
            else
            {
                Color correctColor = Color.FromArgb(255, 255, 255);
                CreateZipTextBox.BackColor = correctColor;
            }

            if (!CreateFirstTextBox.Text.Equals("") && !CreateLastTextBox.Text.Equals("") && !CreatePhoneTextBox.Text.Equals("")
                && !CreateAddressTextBox.Text.Equals("") && !CreateAptTextBox.Text.Equals("") && !CreateCityTextBox.Text.Equals("")
                && !CreateZipTextBox.Text.Equals("") && !CreatePasswordTextBox.Text.Equals("") && passwordsMatch && correctNumberFormat
                &&  correctZipFormat)
            {
                Customer customer = new Customer(CreateFirstTextBox.Text, CreateLastTextBox.Text, CreatePhoneTextBox.Text, CreateAddressTextBox.Text,
                    CreateAptTextBox.Text, CreateZipTextBox.Text, CreateCityTextBox.Text, CreatePasswordTextBox.Text);
                customer.WriteToFile(customer);
                currentCustomer = customer;
                AddCustomer();

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

        private void CreatePhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            correctNumberFormat = false;
            int phoneNumber = 0;

            try
            {
                phoneNumber = Int32.Parse(CreatePhoneTextBox.Text);

                if (phoneNumber > 999999999 && phoneNumber < 10000000000)
                {
                    correctNumberFormat = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private void CreateZipTextBox_TextChanged(object sender, EventArgs e)
        {
            correctZipFormat = false;
            int zipCode = 0;
            try
            {
                zipCode = Int32.Parse(CreateZipTextBox.Text);
                correctZipFormat = true;
            }
            catch (Exception)
            {

            }
        }
    }
}
