using MomAndPops.Resources;
using System;
using System.Windows.Forms;

namespace MomAndPops
{
    public partial class Payment : Form
    {
        Order newOrder;
        Customer customer;
        bool delivery = false;


        public Payment()
        {
            InitializeComponent();
        }

        /// <summary>
        /// SetOrder takes in the customers order created at the menu screen and transfers it to the payment screen where it calculates the subtotal, tax, and total
        /// </summary>
        /// <param name="customerOrder"></param>
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

        public bool GetDelivery()
        {
            return delivery;
        }

        /// <summary>
        /// SubmitPayment_Click runs when the SubmitPayment button is clicked and checks if deliviry or pickup is selected and changes the bool Delivery to reflect.
        /// Then it makes sure the customer has chosen a payment method and a delivery option before being allowed to progress to the confirmation screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitPayment_Click(object sender, EventArgs e)
        {
            if(PickupButton.Checked)
            {
                delivery = false;
            }
            else if(DeliveryButton.Checked)
            {
                delivery = true;
            }

            if ((CashButton.Checked || CheckButton.Checked || CardButton.Checked) && (PickupButton.Checked || DeliveryButton.Checked))
            {
                customer.AddToPreviousOrders(GetOrder());
                customer.WriteToFile(customer);

                Confirmation confirmation = new Confirmation(GetDelivery());
                confirmation.SetCustomer(GetCustomer());
                confirmation.SetDelivery(GetDelivery());
                this.Hide();
                confirmation.ShowDialog();
            }
        }

        /// <summary>
        /// BackButton_Click runs wheenver the customer clicks Back. It creates a new MenuLanding screen and passes the customer and their order to the page so the user
        /// can pick up where they left off.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
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
