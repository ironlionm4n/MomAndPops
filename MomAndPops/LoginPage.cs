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
                Form menu = new MenuLanding();
                menu.ShowDialog();
                
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // WriteToCreateTextBox();
            Customer customer = new Customer(CreateFirstTextBox.Text + " " + CreateLastTextBox.Text, CreatePhoneTextBox.Text, CreateAddressTextBox.Text, CreateAddressTextBox.Text);
            customer.WriteToFile(customer);
            CreatePanel.Hide();
        }

        private void WriteToCreateTextBox()
        {
            CreateAccountTextBox.Text += CreateFirstTextBox.Text + " " + CreateLastTextBox.Text + Environment.NewLine;
            CreateAccountTextBox.Text += CreatePhoneTextBox.Text + Environment.NewLine;
            CreateAccountTextBox.Text += CreateAddressTextBox.Text + Environment.NewLine;
            if (CreateAptTextBox.Text.Length > 0)
            {
                CreateAccountTextBox.Text += CreateAptTextBox.Text + Environment.NewLine;
            }
            CreateAccountTextBox.Text += CreateCityTextBox.Text + Environment.NewLine;
        }
    }
}
