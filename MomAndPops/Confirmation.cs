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

        private void button1_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.SetCustomer(GetCustomer());
            this.Hide();
            login.ShowDialog();
        }

        public Customer GetCustomer()
        {
            return customer;
        }

        public void SetCustomer(Customer cust)
        {
            customer = cust;
        }

        private void PickUpText_Click(object sender, EventArgs e)
        {

        }

        public void SetDelivery(bool del)
        {
            delivery = del;
        }
    }
}
