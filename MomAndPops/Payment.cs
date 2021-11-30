using MomAndPops.Resources;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MomAndPops
{
    public partial class Payment : Form
    {
        Order newOrder;
        Customer customer;
        bool delivery = false;

        bool correctCardNumber= false;
        bool correctCVV = false;
        bool correctMonth = false;
        bool correctYear = false;
        bool correctZip = false;
        bool correctCardInformation = false;


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

            if ((CashButton.Checked || CheckButton.Checked || (CardButton.Checked && correctCardInformation)) && (PickupButton.Checked || DeliveryButton.Checked))
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

        /// <summary>
        /// CardXButton_Click is called whenever the customer clicks the X button on the card tab. It closes the card tab and resets all the text box values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardXButton_Click(object sender, EventArgs e)
        {
            CardPanel.Visible = false;
            CardPanel.Enabled = false;
            CardButton.Checked = false;

            CardNumber.Text = string.Empty;
            CVV.Text = string.Empty;
            Month.Text = string.Empty;
            Year.Text = string.Empty;
            ZipCode.Text = string.Empty;
        }

        /// <summary>
        /// CardSubmt_Click is called whenever the user clicks Submit on the card tab. It goes through and checks each text box for any incorrect data entered
        /// and stops the user from continuing until the errors are fixed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardSubmit_Click(object sender, EventArgs e)
        {
            bool cardNumberIsNum = false;
            try
            {
                long cardNumber = long.Parse(CardNumber.Text);

                cardNumberIsNum = true;
            }
            catch(Exception)
            {

            }

            bool cardCVVIsNum = false;
            try
            {
                int cvv = Int32.Parse(CVV.Text);

                cardCVVIsNum = true;
            }
            catch(Exception)
            {

            }

            bool monthIsNum = false;
            try
            {
                int month = Int32.Parse(Month.Text);

                if (month > 0 && month <= 12)
                {
                    monthIsNum = true;
                }
            }
            catch (Exception)
            {

            }

            bool yearIsNum = false;
            try
            {
                int year = Int32.Parse(Year.Text);

                if (year >= 0)
                {
                    yearIsNum = true;
                }
            }
            catch (Exception)
            {

            }

            bool zipIsNum = false;
            try
            {
                int zip = Int32.Parse(ZipCode.Text);

                zipIsNum = true;
            }
            catch (Exception)
            {

            }

            if (CardNumber.Text.Trim().Length == 12 && cardNumberIsNum)
            {
                correctCardNumber = true;
                Color matchColor = Color.FromArgb(255, 255, 255);
                CardNumber.BackColor = matchColor;
            }
            else
            {
                Color mismatchColor = Color.FromArgb(255, 113, 113);
                CardNumber.BackColor = mismatchColor;
            }

            if(CVV.Text.Trim().Length == 3 && cardCVVIsNum)
            {
                correctCVV = true;
                Color matchColor = Color.FromArgb(255, 255, 255);
                CVV.BackColor = matchColor;
            }
            else
            {
                Color mismatchColor = Color.FromArgb(255, 113, 113);
                CVV.BackColor = mismatchColor;
            }

            if (Month.Text.Trim().Length >= 1 && monthIsNum)
            {
                correctMonth = true;
                Color matchColor = Color.FromArgb(255, 255, 255);
                Month.BackColor = matchColor;
            }
            else
            {
                Color mismatchColor = Color.FromArgb(255, 113, 113);
                Month.BackColor = mismatchColor;
            }

            if (yearIsNum)
            {
                correctYear = true;
                Color matchColor = Color.FromArgb(255, 255, 255);
                Year.BackColor = matchColor;
            }
            else
            {
                Color mismatchColor = Color.FromArgb(255, 113, 113);
                Year.BackColor = mismatchColor;
            }

            if (ZipCode.Text.Trim().Length == 5 && zipIsNum)
            {
                correctZip = true;
                Color matchColor = Color.FromArgb(255, 255, 255);
                ZipCode.BackColor = matchColor;
            }
            else
            {
                Color mismatchColor = Color.FromArgb(255, 113, 113);
                ZipCode.BackColor = mismatchColor;
            }

            if (correctCardNumber && correctCVV && correctMonth && correctYear &&  correctZip)
            {
                CardPanel.Visible = false;
                CardPanel.Enabled = false;
                correctCardInformation = true;

                CardNumber.Text = string.Empty;
                CVV.Text = string.Empty;
                Month.Text = string.Empty;
                Year.Text = string.Empty;
                ZipCode.Text = string.Empty;
            }
        }

        private void CardButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CardButton.Checked)
            {
                CardPanel.Visible = true;
                CardPanel.Enabled = true;
            }
        }
    }
}
