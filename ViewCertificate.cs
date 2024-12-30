using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Marriage_Certificate_Main_File
{
    public partial class ViewCertificate : Form
    {
        public ViewCertificate()
        {
            InitializeComponent();
        }
        int regno = Reports.regno;
        int rid = Reports.rid;
        private void ViewCertificate_Load(object sender, EventArgs e)
        {
            try
            {
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);
                string sql = "select * from tbl_Certifcate where rid='" + rid + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                   // txtRegisterNo.Text = dr["rno"].ToString();
                    dateTimePicker1.Text = dr["date"].ToString();
                    txtCertificateThat.Text = dr["certifythat"].ToString();
                    txtFFatherName.Text = dr["ffathername"].ToString();
                    txtFAge.Text = dr["fage"].ToString();
                    txtFOccupation.Text = dr["foccupation"].ToString();
                    txtFAddress.Text = dr["faddress"].ToString();
                    txtTName.Text = dr["marriedto"].ToString();
                    txtTFatherName.Text = dr["tfathername"].ToString();
                    txtTAge.Text = dr["tage"].ToString();
                    txtTOccupation.Text = dr["toccupation"].ToString();
                    txtTAddress.Text = dr["taddress"].ToString();
                    //txtTTaluka.Text = dr["taluka"].ToString();
                    txtMaher.Text = dr["maher"].ToString();
                    txtMaherInWord.Text = dr["maherinword"].ToString();
                    txtFFather.Text = dr["ffather"].ToString();
                    txtTFather.Text = dr["tfather"].ToString();
                    txtVakeel.Text = dr["vakeel"].ToString();
                    txtWitness1.Text = dr["witness1"].ToString();
                    txtWitness2.Text = dr["witness2"].ToString();
                    cbMaher.Text = dr["marriageperfomer"].ToString();
                    txtMarriagePerformer.Text = dr["marriageperfomer"].ToString();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtCertificateThat.Text == "")
                {
                    string msg1 = "Please Insert Certify that";
                    string msg2 = "Add Certificate";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtCertificateThat.Focus();
                    return;
                }
                if (txtFFatherName.Text == "")
                {
                    string msg1 = "Please Insert Father name";
                    string msg2 = "Add Certificate";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtFFatherName.Focus();
                    return;
                }
                if (txtFAge.Text == "")
                {
                    string msg1 = "Please Insert Age";
                    string msg2 = "Add Certificate";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtFAge.Focus();
                    return;
                }
                if (txtFOccupation.Text == "")
                {
                    string msg1 = "Please Insert Occupation";
                    string msg2 = "Add Certificate";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtFOccupation.Focus();
                    return;
                }
                if (txtFAddress.Text == "")
                {
                    string msg1 = "Please Insert Address";
                    string msg2 = "Add Certificate";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtFAddress.Focus();
                    return;
                }
                if (txtTName.Text == "")
                {
                    string msg1 = "Please Insert Has Married to";
                    string msg2 = "Add Certificate";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtTName.Focus();
                    return;
                }
                if (txtTFatherName.Text == "")
                {
                    string msg1 = "Please Insert Father name";
                    string msg2 = "Add Certificate";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtTFatherName.Focus();
                    return;
                }
                if (txtTAge.Text == "")
                {
                    string msg1 = "Please Insert Age";
                    string msg2 = "Add Certificate";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtTAge.Focus();
                    return;
                }
              /*  if (txtTOccupation.Text == "")
                {
                    string msg1 = "Please Insert Occupation";
                    string msg2 = "Add Certificate";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtTOccupation.Focus();
                    return;
                }*/
                if (txtTAddress.Text == "")
                {
                    string msg1 = "Please Insert Address";
                    string msg2 = "Add Certificate";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtTAddress.Focus();
                    return;
                }
                /* if (txtTTaluka.Text == "")
                 {
                     string msg1 = "Please Insert Taluka";
                     string msg2 = "Add Certificate";
                     MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                     DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                     txtTTaluka.Focus();
                     return;
                 }*/
                if (txtMaher.Text == "")
                {
                    string msg1 = "Please Insert Maher";
                    string msg2 = "Add Certificate";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtMaher.Focus();
                    return;
                }
                if (txtFFather.Text == "")
                {
                    string msg1 = "Please Insert Father Name";
                    string msg2 = "Add Certificate";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtFFather.Focus();
                    return;
                }
                if (txtTFather.Text == "")
                {
                    string msg1 = "Please Insert Father Name";
                    string msg2 = "Add Certificate";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtTFather.Focus();
                    return;
                }
                /*if (txtVakeel.Text == "")
                {
                    string msg1 = "Please Insert Vakeel Name";
                    string msg2 = "Add Certificate";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtTAddress.Focus();
                    return;
                }*/
                if (txtWitness1.Text == "")
                {
                    string msg1 = "Please Insert Witness No.1";
                    string msg2 = "Add Certificate";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtWitness1.Focus();
                    return;
                }
                if (txtWitness2.Text == "")
                {
                    string msg1 = "Please Insert Witness No.2";
                    string msg2 = "Add Certificate";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtWitness2.Focus();
                    return;
                }
                if (cbMaher.Text == "")
                {
                    string msg1 = "Please Insert Mahar Paid or Unpaid";
                    string msg2 = "Add Certificate";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    cbMaher.Focus();
                    return;
                }
                if (txtMarriagePerformer.Text == "")
                {
                    string msg1 = "Please enter the name of Marraige Performer Name";
                    string msg2 = "Add Certificate";
                    MessageBoxButtons btn = MessageBoxButtons.OKCancel;
                    DialogResult rs = MessageBox.Show(msg1, msg2, btn, MessageBoxIcon.Error);
                    txtMarriagePerformer.Focus();
                    return;
                }
                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                string sql = "update tbl_Certifcate set rno=@rno,date=@date,certifythat=@certifythat,ffathername=@ffathername,fage=@fage,foccupation=@foccupation,faddress=@faddress,marriedto=@marriedto,tfathername=@tfathername,tage=@tage,toccupation=@toccupation,taddress=@taddress,maher=@maher,maherinword=@maherinword,ffather=@ffather,tfather=@tfather,vakeel=@vakeel,witness1=@witness1,witness2=@witness2,marriageperfomer=@marriageperfomer where rid='" + rid + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@rno", txtRegisterNo.Text);
                cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(dateTimePicker1.Text));
                cmd.Parameters.AddWithValue("@certifythat", txtCertificateThat.Text);
                cmd.Parameters.AddWithValue("@ffathername", txtFFatherName.Text);
                cmd.Parameters.AddWithValue("@fage", txtFAge.Text);
                cmd.Parameters.AddWithValue("@foccupation", txtFOccupation.Text);
                cmd.Parameters.AddWithValue("@faddress", txtFAddress.Text);
                cmd.Parameters.AddWithValue("@marriedto", txtTName.Text);
                cmd.Parameters.AddWithValue("@tfathername", txtTFatherName.Text);
                cmd.Parameters.AddWithValue("@tage", txtTAge.Text);
                cmd.Parameters.AddWithValue("@toccupation", txtTOccupation.Text);
                cmd.Parameters.AddWithValue("@taddress", txtTAddress.Text);

                cmd.Parameters.AddWithValue("@maher", txtMaher.Text);
                cmd.Parameters.AddWithValue("@maherinword", txtMaherInWord.Text);
                cmd.Parameters.AddWithValue("@ffather", txtFFather.Text);
                cmd.Parameters.AddWithValue("@tfather", txtTFather.Text);
                cmd.Parameters.AddWithValue("@vakeel", txtVakeel.Text);
                cmd.Parameters.AddWithValue("@witness1", txtWitness1.Text);
                cmd.Parameters.AddWithValue("@witness2", txtWitness2.Text);
                cmd.Parameters.AddWithValue("@marriageperfomer", txtMarriagePerformer.Text);
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(x.ToString() + "Record Updated");
                //this.Close();
                // ClearData();
                //LoadData();
                //dataGridViewAddProduct.Update();
                //dataGridViewAddProduct.Refresh();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                string constring = ConfigurationManager.ConnectionStrings["MyConnection"].ToString();
                SqlConnection con = new SqlConnection(constring);

                string sql = "delete tbl_Certifcate where rid='" + rid + "'";
                SqlCommand cmd = new SqlCommand(sql, con);

                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                int x = cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show(x.ToString() + "Record Deleted");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtFAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtTAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtRegisterNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtMaher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        public static string NumberToWord(int number)
        {
            if (number == 0) return " Zero";

            if (number < 0) return " minus" + NumberToWord(Math.Abs(number));
            string word = "";
            if ((number / 1000000) > 0)
            {
                word += NumberToWord(number / 1000000) + " Million";
                number %= 1000000;
            }
            if ((number / 1000) > 0)
            {
                word += NumberToWord(number / 1000) + " Thousand";
                number %= 1000;
            }
            if ((number / 100) > 0)
            {
                word += NumberToWord(number / 100) + " Hundred";
                number %= 100;
            }
            if (number > 0)
            {
                if (word != "") word += "and";
                var unitsmap = new[] { " Zero", " One", " Two", " Three", " Four", " Five", " Six", " Seven", " Eight", " Nine", " Ten", " Eleven", " Twelve", " Thirteen", " Fourteen", " Fifteen", " Sixteen", " Seventeen", " Eighteen", " Ninteen" };
                var tenmap = new[] { " Zero", " Ten", " Tweenty", " Thirty", " Fourth", " Fifty", " Sixty", " Seventy", " Eighty", " Ninety" };

                if (number < 20)
                {
                    word += unitsmap[number];
                }
                else
                {
                    word += tenmap[number / 10];
                    if ((number % 10) > 0)
                    {
                        word += "-" + unitsmap[number % 10];
                    }
                }

            }
            return word;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // e.Graphics.DrawString(txtRegisterNo.Text, new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(180, 185));
            e.Graphics.DrawString(txtCertificateThat.Text, new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(220, 272));
            e.Graphics.DrawString(txtFFatherName.Text, new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(465, 272));
            e.Graphics.DrawString(txtFAge.Text, new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(80, 330));
            e.Graphics.DrawString(txtFOccupation.Text, new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(500, 330));
            e.Graphics.DrawString(txtFAddress.Text, new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(150, 377));
            e.Graphics.DrawString(txtTName.Text, new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(170, 428));
            e.Graphics.DrawString(txtTFatherName.Text, new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(460, 428));
            e.Graphics.DrawString(txtTAge.Text, new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(80, 492));

            e.Graphics.DrawString(txtTOccupation.Text, new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(482, 490));
            e.Graphics.DrawString(txtTAddress.Text, new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(170, 540));
            e.Graphics.DrawString(dateTimePicker1.Text, new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(80, 585));

            e.Graphics.DrawString(txtMaher.Text, new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(290, 620));

            //e.Graphics.DrawString(txtIGST.Text, new Font("Times New Romans", 10, FontStyle.Bold), Brushes.Black, new PointF(650, 780));

            e.Graphics.DrawString(txtMaherInWord.Text, new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(150, 662));
            if (cbMaher.Text == "Paid")
            {
                e.Graphics.DrawString("Paid", new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(660, 620));
            }
            else
            {
                e.Graphics.DrawString("Unpaid", new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(660, 620));
            }
            e.Graphics.DrawString(txtFFather.Text, new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(210, 825));
            e.Graphics.DrawString(txtTFather.Text, new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(225, 873));

            e.Graphics.DrawString(txtVakeel.Text, new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(150, 915));
            e.Graphics.DrawString(txtWitness1.Text, new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(200, 961));
            e.Graphics.DrawString(txtWitness2.Text, new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(200, 1004));
            e.Graphics.DrawString(txtMarriagePerformer.Text, new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(215, 1060));
            e.Graphics.DrawString(dateTimePicker2.Text, new Font("Times New Romans", 12, FontStyle.Bold), Brushes.Black, new PointF(690, 1095));
 
        }

        private void btnMaher_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtMaher.Text);
            txtMaherInWord.Text = NumberToWord(a);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
