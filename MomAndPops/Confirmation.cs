using System;
using System.Windows.Forms;

namespace MomAndPops
{
    public partial class Confirmation : Form
    {
        Customer customer;
        bool delivery = false;
        public Confirmation(bool del)
        {
            InitializeComponent();
            if(del)
            {
                DeliveryText.Visible = true;
            }
            else
            {
                PickUpText.Visible = true;
            }
        }

        /// <summary>
        /// LogoutButton_Click occurs when the user clicks logout. It creates a new login page and passes it the current customer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            // LoginPage login = new LoginPage();
            Program.loginPageInstance.SetCustomer(GetCustomer());
            //Form.ActiveForm.Close();
             
            //  login.ShowDialog();
            Program.loginPageInstance.Show();
            Program.loginPageInstance.UserSelectedTOExit = false;
            this.Close();
        }

        public Customer GetCustomer()
        {
            return customer;
        }

        public void SetCustomer(Customer cust)
        {
            customer = cust;
        }
        public void SetDelivery(bool del)
        {
            delivery = del;
        }

        private void Confirmation_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Program.loginPageInstance.UserSelectedTOExit)
                Program.loginPageInstance.Close();
        }
    }
}
