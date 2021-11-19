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

namespace MomAndPops
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (PhoneNumberBox.Text == "TestUsername" && PasswordBox.Text == "TestPassword")
            {
                this.Hide();
                Form menu = new MenuLanding();
                menu.ShowDialog();
                
            }
        }

    }
}
