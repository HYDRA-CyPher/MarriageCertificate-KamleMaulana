namespace Marriage_Certificate_3
{
    partial class Dashbord
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMini = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnCreateCertificate = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.aboutUs1 = new Marriage_Certificate_Main_File.AboutUs();
            this.reports1 = new Marriage_Certificate_Main_File.Reports();
            this.createCertificate1 = new Marriage_Certificate_Main_File.CreateCertificate();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(48)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.panelMini);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnAboutUs);
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnCreateCertificate);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 701);
            this.panel1.TabIndex = 7;
            // 
            // panelMini
            // 
            this.panelMini.BackColor = System.Drawing.Color.White;
            this.panelMini.Location = new System.Drawing.Point(-1, 125);
            this.panelMini.Name = "panelMini";
            this.panelMini.Size = new System.Drawing.Size(11, 60);
            this.panelMini.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::Marriage_Certificate_3.Properties.Resources.Exit;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 305);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(232, 60);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAboutUs.FlatAppearance.BorderSize = 0;
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutUs.ForeColor = System.Drawing.Color.White;
            this.btnAboutUs.Image = global::Marriage_Certificate_3.Properties.Resources.About;
            this.btnAboutUs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutUs.Location = new System.Drawing.Point(0, 245);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(232, 60);
            this.btnAboutUs.TabIndex = 6;
            this.btnAboutUs.Text = "About Us";
            this.btnAboutUs.UseVisualStyleBackColor = true;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = global::Marriage_Certificate_3.Properties.Resources.icons8_certificate_26px;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 185);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(232, 60);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnCreateCertificate
            // 
            this.btnCreateCertificate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateCertificate.FlatAppearance.BorderSize = 0;
            this.btnCreateCertificate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateCertificate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCertificate.ForeColor = System.Drawing.Color.White;
            this.btnCreateCertificate.Image = global::Marriage_Certificate_3.Properties.Resources.DashBord1;
            this.btnCreateCertificate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateCertificate.Location = new System.Drawing.Point(0, 125);
            this.btnCreateCertificate.Name = "btnCreateCertificate";
            this.btnCreateCertificate.Size = new System.Drawing.Size(232, 60);
            this.btnCreateCertificate.TabIndex = 2;
            this.btnCreateCertificate.Text = "Create Certificate";
            this.btnCreateCertificate.UseVisualStyleBackColor = true;
            this.btnCreateCertificate.Click += new System.EventHandler(this.btnCreateCertificate_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(232, 125);
            this.panelLogo.TabIndex = 1;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogo.Image = global::Marriage_Certificate_3.Properties.Resources._3848;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(232, 125);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1289, 69);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.createCertificate1);
            this.panel3.Controls.Add(this.reports1);
            this.panel3.Controls.Add(this.aboutUs1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(232, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1057, 701);
            this.panel3.TabIndex = 9;
            // 
            // aboutUs1
            // 
            this.aboutUs1.BackColor = System.Drawing.Color.White;
            this.aboutUs1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutUs1.Location = new System.Drawing.Point(0, 0);
            this.aboutUs1.Name = "aboutUs1";
            this.aboutUs1.Size = new System.Drawing.Size(1057, 701);
            this.aboutUs1.TabIndex = 0;
            // 
            // reports1
            // 
            this.reports1.BackColor = System.Drawing.Color.White;
            this.reports1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reports1.Location = new System.Drawing.Point(0, 0);
            this.reports1.Name = "reports1";
            this.reports1.Size = new System.Drawing.Size(1057, 701);
            this.reports1.TabIndex = 1;
            // 
            // createCertificate1
            // 
            this.createCertificate1.AutoScroll = true;
            this.createCertificate1.BackColor = System.Drawing.Color.White;
            this.createCertificate1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createCertificate1.Location = new System.Drawing.Point(0, 0);
            this.createCertificate1.Name = "createCertificate1";
            this.createCertificate1.Size = new System.Drawing.Size(1057, 701);
            this.createCertificate1.TabIndex = 2;
            // 
            // Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 770);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Dashbord";
            this.Text = "Dashbord";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMini;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnCreateCertificate;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Marriage_Certificate_Main_File.CreateCertificate createCertificate1;
        private Marriage_Certificate_Main_File.Reports reports1;
        private Marriage_Certificate_Main_File.AboutUs aboutUs1;
    }
}