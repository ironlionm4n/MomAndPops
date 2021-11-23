using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MomAndPops.Resources;
using System.IO;

namespace MomAndPops
{
    public partial class LoginPage : Form
    {
        Customer currentCustomer = new Customer("testFirst", "testLast", "0000000000", "testAddress", "73");
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
            if (/*LoginPhoneNumberBox.Text == "TestUsername" && LoginPasswordBox.Text == "TestPassword"*/true)
            {
                this.Hide();
                MenuLanding menu = new MenuLanding();
                menu.SetCustomer(GetCustomer());
                menu.ShowDialog();
                
            }
        }

        private void CreateSubmitButton_Click(object sender, EventArgs e)
        {
            bool passwordsMatch = CreatePasswordTextBox.Text == CreateConfirmTextBox.Text;
            if(passwordsMatch == false)
            {
                Color mismatchColor = Color.FromArgb(255, 113, 113);
                CreatePasswordTextBox.BackColor = mismatchColor;
                CreateConfirmTextBox.BackColor = mismatchColor;
            }
            if (!CreateFirstTextBox.Text.Equals("") && !CreateLastTextBox.Text.Equals("") && !CreatePhoneTextBox.Text.Equals("")
                && !CreateAddressTextBox.Text.Equals("") && !CreateAptTextBox.Text.Equals("") && !CreateCityTextBox.Text.Equals("")
                && !CreateZipTextBox.Text.Equals("") && !CreatePasswordTextBox.Text.Equals("") && passwordsMatch )
            {
                Customer customer = new Customer(CreateFirstTextBox.Text, CreateLastTextBox.Text, CreatePhoneTextBox.Text, CreateAddressTextBox.Text,
                    CreateAptTextBox.Text, CreateZipTextBox.Text, CreateCityTextBox.Text, CreatePasswordTextBox.Text);
                customer.WriteToFile(customer);
                currentCustomer = customer;
                CreatePanel.Hide();
            }
        }

        private void CreateBackButton_Click(object sender, EventArgs e)
        {
            CreatePanel.Hide();
        }

        public Customer GetCustomer()
        {
            return currentCustomer;
        }

        public void SetCustomer(Customer customer)
        {
            currentCustomer = customer;
        }
    }
}
