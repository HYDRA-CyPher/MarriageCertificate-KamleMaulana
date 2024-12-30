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
    public partial class Dashbord : Form
    {
        public Dashbord()
        {
            InitializeComponent();
        }

        private void btnCreateCertificate_Click(object sender, EventArgs e)
        {
            panelMini.Height = btnCreateCertificate.Height;
            panelMini.Top = btnCreateCertificate.Top;
            createCertificate1.BringToFront();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            panelMini.Height = btnReport.Height;
            panelMini.Top = btnReport.Top;
            reports1.BringToFront();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            panelMini.Height = btnAboutUs.Height;
            panelMini.Top = btnAboutUs.Top;
            aboutUs1.BringToFront();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            panelMini.Height = btnLogout.Height;
            panelMini.Top = btnLogout.Top;
            MessageBox.Show("Are you conform for Logout!!!");
            this.Hide();
            LoginPage ob = new LoginPage();
            ob.Show();
        }
    }
}
