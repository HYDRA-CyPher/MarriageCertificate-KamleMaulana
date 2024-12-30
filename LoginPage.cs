using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Marriage_Certificate_3
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUName.Text == "Kamle123" && txtPass.Text == "1974")
            {
                MessageBox.Show("Welcome Back Admin");
                this.Hide();
                Dashbord ob = new Dashbord();
                ob.Show();
            }
            else
            {
                MessageBox.Show("Please check user name and Password!!!");
                txtUName.Text = "";
                txtPass.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exit the System");
            this.Close();
        }
    }
}
