using System;
using System.Windows.Forms;

namespace MomAndPops
{
    public partial class Confirmation : Form
    {
        Customer customer;
        public Confirmation()
        {
            InitializeComponent();
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
    }
}
