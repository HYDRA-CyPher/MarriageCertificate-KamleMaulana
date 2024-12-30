using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Marriage_Certificate_Main_File
{
    public partial class Reports : UserControl
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void cbSeachType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSeachType.Text == "Registration ID")
            {
                lblBID.Visible = true;
                txtBID.Visible = true;
                //lblCustName.Visible = false;
                txtCustName.Visible = false;
                lblDate.Visible = false;
                DateTo.Visible = false;
                lblDateTo.Visible = false;
                DateFrom.Visible = false;
                //btnSearch.Enabled = true;
            }



            if (cbSeachType.Text == "Date and Name")
            {
                lblBID.Visible = true;
                txtBID.Visible = true;
                // lblCustName.Visible = false;
                txtCustName.Visible = false;
                lblDate.Visible = true;
                DateTo.Visible = true;
                lblDateTo.Visible = true;
                DateFrom.Visible = true;
                //btnSearch.Enabled = true;
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                DataTable donater = new DataTable();
                con.Open();


                SqlDataAdapter sda = new SqlDataAdapter("select rid,certifythat,marriedto,date from tbl_Certifcate", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewAddProduct.DataSource = dt;
                con.Close();
                dataGridViewAddProduct.Visible = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (lblBID.Visible == true)
            {


                try
                {
                    if (txtCustName.Text == "")
                    {
                        string msg1 = "Please Insert Name";
                        string msg2 = "Certificate";
                        MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                        DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                        txtBID.Focus();
                        return;
                    }

                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring);
                    DataTable donater = new DataTable();
                    con.Open();


                    SqlDataAdapter sda = new SqlDataAdapter("select rid,certifythat,marriedto,date from tbl_Certifcate where certifythat='" + txtCustName.Text + "' and date between'" + DateTo.Text + "'and'" + DateFrom.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridViewAddProduct.DataSource = dt;
                    con.Close();
                    dataGridViewAddProduct.Visible = true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }


            if (lblDate.Visible == true)
            {
                try
                {

                    string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                    SqlConnection con = new SqlConnection(constring);
                    DataTable donater = new DataTable();
                    con.Open();


                    SqlDataAdapter sda = new SqlDataAdapter("select rid,certifythat,marriedto,date from tbl_Certifcate where certifythat='" + txtCustName.Text + "' and date between'" + DateTo.Text + "'and'" + DateFrom.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridViewAddProduct.DataSource = dt;
                    con.Close();
                    dataGridViewAddProduct.Visible = true;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void dataGridViewAddProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblRID.Text = dataGridViewAddProduct.Rows[e.RowIndex].Cells["rid"].Value.ToString();
           // string rno = dataGridViewAddProduct.Rows[e.RowIndex].Cells["rno"].Value.ToString();
            try
            {

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                string sql = "select * from tbl_Certifcate where rid='" + lblRID.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, con);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                //  SqlCommand cmd = new SqlCommand(sql, con);
                int x = cmd.ExecuteNonQuery();
                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.Read())
                {
                    rid = int.Parse(dr["rid"].ToString());

                }
                else
                {
                    MessageBox.Show("Data not Availebel");



                }
                con.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //btnPrint.Visible = true;
            btnViewCertificate.Visible = true;
        }
        public static int regno, rid;

        private void btnViewCertificate_Click(object sender, EventArgs e)
        {
            rid = int.Parse(rid.ToString());
            ViewCertificate ob = new ViewCertificate();
            ob.Show();
        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }
    }
}
