using MomAndPops.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MomAndPops
{
    public partial class Payment : Form
    {
        Order newOrder;

        public Payment()
        {
            InitializeComponent();
        }

        public void SetOrder(Order customerOrder)
        {
            newOrder = customerOrder;
            float subtotal = 0;
            foreach(MenuItem m in newOrder.currentOrder)
            {
                subtotal += m.ItemPrice * m.ItemQuantity;
            }
            Subtotal.Text = "$" + subtotal.ToString();
            float tax = subtotal * .06f;
            Tax.Text = "$" + tax.ToString();
            Total.Text = "$" + (subtotal + tax).ToString();
        }
        
        public Order GetOrder()
        {
            return newOrder;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((radioButton1.Checked || radioButton2.Checked || radioButton3.Checked) && (radioButton4.Checked || radioButton5.Checked))
            {
                Form confirmation = new Confirmation();
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
            this.Hide();
            menu.Show();
        }
    }
}
