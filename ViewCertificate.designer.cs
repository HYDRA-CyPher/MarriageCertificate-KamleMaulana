namespace Marriage_Certificate_Main_File
{
    partial class ViewCertificate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewCertificate));
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.cbMaher = new System.Windows.Forms.ComboBox();
            this.btnMaher = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtRegisterNo = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtWitness2 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtWitness1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtVakeel = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTFather = new System.Windows.Forms.TextBox();
            this.txtFFather = new System.Windows.Forms.TextBox();
            this.txtMaherInWord = new System.Windows.Forms.TextBox();
            this.txtMaher = new System.Windows.Forms.TextBox();
            this.txtTAddress = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtTOccupation = new System.Windows.Forms.TextBox();
            this.txtTAge = new System.Windows.Forms.TextBox();
            this.txtTFatherName = new System.Windows.Forms.TextBox();
            this.txtTName = new System.Windows.Forms.TextBox();
            this.txtFAddress = new System.Windows.Forms.TextBox();
            this.txtFOccupation = new System.Windows.Forms.TextBox();
            this.txtFAge = new System.Windows.Forms.TextBox();
            this.txtFFatherName = new System.Windows.Forms.TextBox();
            this.txtCertificateThat = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.txtMarriagePerformer = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(1042, 1342);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(209, 64);
            this.btnPrint.TabIndex = 244;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(715, 1342);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(209, 64);
            this.btnDelete.TabIndex = 198;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(337, 1342);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(209, 64);
            this.btnUpdate.TabIndex = 197;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(615, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 37);
            this.label1.TabIndex = 196;
            this.label1.Text = "View Certificate";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(70, 1038);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(173, 23);
            this.label26.TabIndex = 289;
            this.label26.Text = "Maher Paid/Unpaid";
            // 
            // cbMaher
            // 
            this.cbMaher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.cbMaher.FormattingEnabled = true;
            this.cbMaher.Items.AddRange(new object[] {
            "Paid",
            "Unpaid"});
            this.cbMaher.Location = new System.Drawing.Point(307, 1038);
            this.cbMaher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMaher.Name = "cbMaher";
            this.cbMaher.Size = new System.Drawing.Size(247, 31);
            this.cbMaher.TabIndex = 288;
            // 
            // btnMaher
            // 
            this.btnMaher.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMaher.FlatAppearance.BorderSize = 0;
            this.btnMaher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaher.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaher.ForeColor = System.Drawing.Color.White;
            this.btnMaher.Location = new System.Drawing.Point(736, 901);
            this.btnMaher.Name = "btnMaher";
            this.btnMaher.Size = new System.Drawing.Size(135, 39);
            this.btnMaher.TabIndex = 287;
            this.btnMaher.Text = "Calculate";
            this.btnMaher.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(999, 789);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(235, 30);
            this.dateTimePicker1.TabIndex = 286;
            // 
            // txtRegisterNo
            // 
            this.txtRegisterNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtRegisterNo.Location = new System.Drawing.Point(307, 80);
            this.txtRegisterNo.Name = "txtRegisterNo";
            this.txtRegisterNo.Size = new System.Drawing.Size(377, 30);
            this.txtRegisterNo.TabIndex = 262;
            this.txtRegisterNo.Visible = false;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(92, 83);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(116, 23);
            this.label25.TabIndex = 285;
            this.label25.Text = "Register No.";
            this.label25.Visible = false;
            // 
            // txtWitness2
            // 
            this.txtWitness2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtWitness2.Location = new System.Drawing.Point(999, 1240);
            this.txtWitness2.Name = "txtWitness2";
            this.txtWitness2.Size = new System.Drawing.Size(377, 30);
            this.txtWitness2.TabIndex = 284;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(806, 1244);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(126, 23);
            this.label24.TabIndex = 283;
            this.label24.Text = "Witness No. 2";
            // 
            // txtWitness1
            // 
            this.txtWitness1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtWitness1.Location = new System.Drawing.Point(307, 1240);
            this.txtWitness1.Name = "txtWitness1";
            this.txtWitness1.Size = new System.Drawing.Size(377, 30);
            this.txtWitness1.TabIndex = 282;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(113, 1244);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(126, 23);
            this.label18.TabIndex = 281;
            this.label18.Text = "Witness No. 1";
            // 
            // txtVakeel
            // 
            this.txtVakeel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtVakeel.Location = new System.Drawing.Point(307, 1181);
            this.txtVakeel.Name = "txtVakeel";
            this.txtVakeel.Size = new System.Drawing.Size(377, 30);
            this.txtVakeel.TabIndex = 280;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(147, 1181);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 46);
            this.label14.TabIndex = 279;
            this.label14.Text = "Vakeel\r\nवकील";
            // 
            // txtTFather
            // 
            this.txtTFather.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtTFather.Location = new System.Drawing.Point(999, 1103);
            this.txtTFather.Name = "txtTFather";
            this.txtTFather.Size = new System.Drawing.Size(377, 30);
            this.txtTFather.TabIndex = 278;
            // 
            // txtFFather
            // 
            this.txtFFather.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtFFather.Location = new System.Drawing.Point(307, 1101);
            this.txtFFather.Name = "txtFFather";
            this.txtFFather.Size = new System.Drawing.Size(377, 30);
            this.txtFFather.TabIndex = 277;
            // 
            // txtMaherInWord
            // 
            this.txtMaherInWord.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtMaherInWord.Location = new System.Drawing.Point(307, 978);
            this.txtMaherInWord.Name = "txtMaherInWord";
            this.txtMaherInWord.Size = new System.Drawing.Size(847, 30);
            this.txtMaherInWord.TabIndex = 276;
            // 
            // txtMaher
            // 
            this.txtMaher.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtMaher.Location = new System.Drawing.Point(307, 906);
            this.txtMaher.Name = "txtMaher";
            this.txtMaher.Size = new System.Drawing.Size(377, 30);
            this.txtMaher.TabIndex = 275;
            // 
            // txtTAddress
            // 
            this.txtTAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtTAddress.Location = new System.Drawing.Point(307, 786);
            this.txtTAddress.Multiline = true;
            this.txtTAddress.Name = "txtTAddress";
            this.txtTAddress.Size = new System.Drawing.Size(377, 67);
            this.txtTAddress.TabIndex = 274;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(147, 789);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(106, 46);
            this.label23.TabIndex = 273;
            this.label23.Text = "Resident of\r\nराहणार";
            // 
            // txtTOccupation
            // 
            this.txtTOccupation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtTOccupation.Location = new System.Drawing.Point(307, 693);
            this.txtTOccupation.Name = "txtTOccupation";
            this.txtTOccupation.Size = new System.Drawing.Size(377, 30);
            this.txtTOccupation.TabIndex = 272;
            // 
            // txtTAge
            // 
            this.txtTAge.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtTAge.Location = new System.Drawing.Point(307, 611);
            this.txtTAge.Name = "txtTAge";
            this.txtTAge.Size = new System.Drawing.Size(377, 30);
            this.txtTAge.TabIndex = 271;
            // 
            // txtTFatherName
            // 
            this.txtTFatherName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtTFatherName.Location = new System.Drawing.Point(999, 525);
            this.txtTFatherName.Name = "txtTFatherName";
            this.txtTFatherName.Size = new System.Drawing.Size(377, 30);
            this.txtTFatherName.TabIndex = 270;
            // 
            // txtTName
            // 
            this.txtTName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtTName.Location = new System.Drawing.Point(307, 525);
            this.txtTName.Name = "txtTName";
            this.txtTName.Size = new System.Drawing.Size(377, 30);
            this.txtTName.TabIndex = 269;
            // 
            // txtFAddress
            // 
            this.txtFAddress.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtFAddress.Location = new System.Drawing.Point(307, 402);
            this.txtFAddress.Multiline = true;
            this.txtFAddress.Name = "txtFAddress";
            this.txtFAddress.Size = new System.Drawing.Size(377, 67);
            this.txtFAddress.TabIndex = 268;
            // 
            // txtFOccupation
            // 
            this.txtFOccupation.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtFOccupation.Location = new System.Drawing.Point(307, 315);
            this.txtFOccupation.Name = "txtFOccupation";
            this.txtFOccupation.Size = new System.Drawing.Size(377, 30);
            this.txtFOccupation.TabIndex = 267;
            // 
            // txtFAge
            // 
            this.txtFAge.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtFAge.Location = new System.Drawing.Point(307, 221);
            this.txtFAge.Name = "txtFAge";
            this.txtFAge.Size = new System.Drawing.Size(377, 30);
            this.txtFAge.TabIndex = 266;
            // 
            // txtFFatherName
            // 
            this.txtFFatherName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtFFatherName.Location = new System.Drawing.Point(999, 138);
            this.txtFFatherName.Name = "txtFFatherName";
            this.txtFFatherName.Size = new System.Drawing.Size(377, 30);
            this.txtFFatherName.TabIndex = 265;
            // 
            // txtCertificateThat
            // 
            this.txtCertificateThat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtCertificateThat.Location = new System.Drawing.Point(307, 134);
            this.txtCertificateThat.Name = "txtCertificateThat";
            this.txtCertificateThat.Size = new System.Drawing.Size(377, 30);
            this.txtCertificateThat.TabIndex = 264;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(766, 1106);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(197, 46);
            this.label21.TabIndex = 263;
            this.label21.Text = "Father of Bride groom\r\n(दूल्हे के वाली)";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(115, 1103);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(139, 46);
            this.label20.TabIndex = 261;
            this.label20.Text = "Father of Bride\r\n(दुल्हन के वालिद)";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(31, 981);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(267, 46);
            this.label19.TabIndex = 260;
            this.label19.Text = "The Maher amount settled(Rs.\r\n   (अक्षरी रुपये";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(147, 910);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(107, 46);
            this.label17.TabIndex = 259;
            this.label17.Text = "Maher(Rs.)\r\nमहेर(रुपये )";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(853, 789);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 46);
            this.label16.TabIndex = 258;
            this.label16.Text = "On\r\nता.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(743, 695);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 46);
            this.label15.TabIndex = 257;
            this.label15.Text = "Religion: Islam\r\nधर्म: इस्लाम";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(147, 695);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 46);
            this.label11.TabIndex = 256;
            this.label11.Text = "Occupation\r\nव्यवसाय";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(724, 614);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(264, 46);
            this.label12.TabIndex = 255;
            this.label12.Text = "Year(At the time of Marriage)\r\nवर्षे (लग्नाचा वेळ)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(180, 614);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 46);
            this.label13.TabIndex = 254;
            this.label13.Text = "Age\r\nवय";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(853, 525);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 46);
            this.label10.TabIndex = 253;
            this.label10.Text = "S/o.\r\nवडिलांचे नाव";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(113, 527);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 46);
            this.label9.TabIndex = 252;
            this.label9.Text = "Has Married to\r\nयांचे लग्न";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(147, 406);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 46);
            this.label8.TabIndex = 251;
            this.label8.Text = "Resident of\r\nराहणार";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(781, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 46);
            this.label7.TabIndex = 250;
            this.label7.Text = "Religion: Islam\r\nधर्म: इस्लाम";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(147, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 46);
            this.label6.TabIndex = 249;
            this.label6.Text = "Occupation\r\nव्यवसाय";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(732, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 46);
            this.label5.TabIndex = 248;
            this.label5.Text = "Year(At the time of Marriage)\r\nवर्षे (लग्नाचा वेळ)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(180, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 46);
            this.label4.TabIndex = 247;
            this.label4.Text = "Age\r\nवय";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(853, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 46);
            this.label3.TabIndex = 246;
            this.label3.Text = "S/o.\r\nवडिलांचे नाव";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 46);
            this.label2.TabIndex = 245;
            this.label2.Text = "This is to Certify that\r\nदाखला देण्यात येत आहे की";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(1039, 1293);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(235, 30);
            this.dateTimePicker2.TabIndex = 293;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(885, 1296);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(121, 23);
            this.label27.TabIndex = 292;
            this.label27.Text = "Date of Issue";
            // 
            // txtMarriagePerformer
            // 
            this.txtMarriagePerformer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.txtMarriagePerformer.Location = new System.Drawing.Point(307, 1293);
            this.txtMarriagePerformer.Name = "txtMarriagePerformer";
            this.txtMarriagePerformer.Size = new System.Drawing.Size(503, 30);
            this.txtMarriagePerformer.TabIndex = 291;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(72, 1296);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(182, 23);
            this.label22.TabIndex = 290;
            this.label22.Text = "Marriage Performer";
            // 
            // ViewCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1504, 1055);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.txtMarriagePerformer);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.cbMaher);
            this.Controls.Add(this.btnMaher);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtRegisterNo);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtWitness2);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtWitness1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtVakeel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTFather);
            this.Controls.Add(this.txtFFather);
            this.Controls.Add(this.txtMaherInWord);
            this.Controls.Add(this.txtMaher);
            this.Controls.Add(this.txtTAddress);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtTOccupation);
            this.Controls.Add(this.txtTAge);
            this.Controls.Add(this.txtTFatherName);
            this.Controls.Add(this.txtTName);
            this.Controls.Add(this.txtFAddress);
            this.Controls.Add(this.txtFOccupation);
            this.Controls.Add(this.txtFAge);
            this.Controls.Add(this.txtFFatherName);
            this.Controls.Add(this.txtCertificateThat);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Name = "ViewCertificate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewCertificate";
            this.Load += new System.EventHandler(this.ViewCertificate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cbMaher;
        private System.Windows.Forms.Button btnMaher;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtRegisterNo;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtWitness2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtWitness1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtVakeel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTFather;
        private System.Windows.Forms.TextBox txtFFather;
        private System.Windows.Forms.TextBox txtMaherInWord;
        private System.Windows.Forms.TextBox txtMaher;
        private System.Windows.Forms.TextBox txtTAddress;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtTOccupation;
        private System.Windows.Forms.TextBox txtTAge;
        private System.Windows.Forms.TextBox txtTFatherName;
        private System.Windows.Forms.TextBox txtTName;
        private System.Windows.Forms.TextBox txtFAddress;
        private System.Windows.Forms.TextBox txtFOccupation;
        private System.Windows.Forms.TextBox txtFAge;
        private System.Windows.Forms.TextBox txtFFatherName;
        private System.Windows.Forms.TextBox txtCertificateThat;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtMarriagePerformer;
        private System.Windows.Forms.Label label22;
    }
}