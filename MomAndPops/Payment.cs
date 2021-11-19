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
        Order currentOrder;
        public Payment()
        {
            InitializeComponent();
        }

        public void SetOrder(Order customerOrder)
        {
            currentOrder = customerOrder;
            float subtotal = 0;
            foreach(MenuItem m in currentOrder.currentOrder)
            {
                subtotal += m.ItemPrice;
            }
            Subtotal.Text = "$" + subtotal.ToString();
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
    }
}
