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
        static List<Customer> activeCustomers = new List<Customer>();

        bool correctNumberFormat = false;
        bool correctZipFormat = false;
        public LoginPage()
        {
            InitializeComponent();
            CreatePanel.Hide();
            Customer testCustomer = new Customer();
            activeCustomers.Add(testCustomer);
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            CreatePanel.Show();
        }


        /// <summary>
        /// LoginButton_Click makes sure that the Phone number is from an active customer added to the system and then checks if the password enters matches the password
        /// stored in the customer with that phone number before taking the user to the menu page and passing their information along.
        /// Failing to enter a number in the system or a matching password displays an error message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool correctPassword = false;

            foreach (Customer customer in activeCustomers)
            {
                if (customer.GetPhone() == LoginPhoneNumberBox.Text)
                {
                    if (customer.GetPassword() == LoginPasswordBox.Text)
                    {
                        correctPassword = true;
                        currentCustomer = customer;

                    }
                }
            }

            if (correctPassword)
            {
                //Form.ActiveForm.Close();
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

        /// <summary>
        /// CreateSubmitButton_Click is called when the user attempts to create an account after entering all their information. The method makes sure each field has something
        /// entered for it and also checks that the password and confirm password fields match, a 10 digit phone number is enetered, and a number is entered for the zip code.
        /// If any of these conditions are not met the fields will be marked red and the customer can not continue.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            if (!correctZipFormat)
            {
                Color incorrectColor = Color.FromArgb(255, 113, 113);
                CreateZipTextBox.BackColor = incorrectColor;
            }
            else
            {
                Color correctColor = Color.FromArgb(255, 255, 255);
                CreateZipTextBox.BackColor = correctColor;
            }

            if (!CreateFirstTextBox.Text.Trim().Equals("") && !CreateLastTextBox.Text.Trim().Equals("") && !CreatePhoneTextBox.Text.Trim().Equals("")
                && !CreateAddressTextBox.Text.Trim().Equals("") && !CreateCityTextBox.Text.Trim().Equals("")
                && !CreateZipTextBox.Text.Trim().Equals("") && !CreatePasswordTextBox.Text.Trim().Equals("") && passwordsMatch && correctNumberFormat
                && correctZipFormat)
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
                //Resets all text fields to blank after use
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
            //Resets all text fields to blank after use
        }

        public Customer GetCustomer()
        {
            return currentCustomer;
        }

        public void SetCustomer(Customer customer)
        {
            currentCustomer = customer;
        }

        /// <summary>
        /// AddCustomer checks to make sure the phone number provided is not already in use by anothe customer in the system.
        /// </summary>
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

        /// <summary>
        /// CreatePhoneTextBox_TextChanged is called anytime the user enters a value into the Phone Text box. If checks if the users number is a number and not words
        /// and then checks if it is ten digits.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreatePhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            correctNumberFormat = false;
            long phoneNumber = 0;

            try
            {
                phoneNumber = long.Parse(CreatePhoneTextBox.Text.Trim());

                if (CreatePhoneTextBox.Text.Trim().Length == 10)
                {
                    correctNumberFormat = true;
                }
            }
            catch (Exception)
            {

            }
        }

        /// <summary>
        /// CreateZipTextBox_Changed is called whenever the customers enters a value into the Zip text box. It checks to make sure what the customers enters is a number and
        /// not words or letters.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void About_Click(object sender, EventArgs e)
        {
            AboutPanel.Visible = true;
            AboutPanel.Enabled = true;
        }

        private void AboutClose_Click(object sender, EventArgs e)
        {
            AboutPanel.Visible = false;
            AboutPanel.Enabled = false;
        }
    }
}
