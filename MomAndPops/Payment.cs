using MomAndPops.Resources;
using System;
using System.Windows.Forms;

namespace MomAndPops
{
    public partial class Payment : Form
    {
        Order newOrder;
        Customer customer;

        public Payment()
        {
            InitializeComponent();
        }

        public void SetOrder(Order customerOrder)
        {
            newOrder = customerOrder;
            float subtotal = 0;
            foreach (MenuItem m in newOrder.currentOrder)
            {
                subtotal += m.ItemPrice * m.ItemQuantity;
            }
            Subtotal.Text = "$" + subtotal.ToString("0.00");
            float tax = subtotal * .06f;
            Tax.Text = "$" + tax.ToString("0.00");
            Total.Text = "$" + (subtotal + tax).ToString("0.00");
        }

        public Order GetOrder()
        {
            return newOrder;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked || radioButton2.Checked || radioButton3.Checked) && (radioButton4.Checked || radioButton5.Checked))
            {
                customer.AddToPreviousOrders(GetOrder());
                customer.WriteToFile(customer);

                Confirmation confirmation = new Confirmation();
                confirmation.SetCustomer(GetCustomer());
                this.Hide();
                confirmation.ShowDialog();
            }
        }

        private void Total_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuLanding menu = new MenuLanding();
            menu.SetOrder(GetOrder());
            menu.SetCustomer(GetCustomer());
            this.Hide();
            menu.Show();
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
