namespace Marriage_Certificate_Main_File
{
    partial class Reports
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewAddProduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnViewCertificate = new System.Windows.Forms.Button();
            this.DateTo = new System.Windows.Forms.DateTimePicker();
            this.DateFrom = new System.Windows.Forms.DateTimePicker();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblRID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.lblBID = new System.Windows.Forms.Label();
            this.cbSeachType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAddProduct
            // 
            this.dataGridViewAddProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAddProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAddProduct.Location = new System.Drawing.Point(34, 410);
            this.dataGridViewAddProduct.Name = "dataGridViewAddProduct";
            this.dataGridViewAddProduct.RowTemplate.Height = 24;
            this.dataGridViewAddProduct.Size = new System.Drawing.Size(1180, 321);
            this.dataGridViewAddProduct.TabIndex = 177;
            this.dataGridViewAddProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAddProduct_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 37);
            this.label1.TabIndex = 176;
            this.label1.Text = "Report Certificate";
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnShowAll.FlatAppearance.BorderSize = 0;
            this.btnShowAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAll.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(470, 339);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(166, 43);
            this.btnShowAll.TabIndex = 175;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(202, 339);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(166, 43);
            this.btnSearch.TabIndex = 174;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnViewCertificate
            // 
            this.btnViewCertificate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnViewCertificate.FlatAppearance.BorderSize = 0;
            this.btnViewCertificate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCertificate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnViewCertificate.ForeColor = System.Drawing.Color.White;
            this.btnViewCertificate.Location = new System.Drawing.Point(737, 339);
            this.btnViewCertificate.Name = "btnViewCertificate";
            this.btnViewCertificate.Size = new System.Drawing.Size(166, 43);
            this.btnViewCertificate.TabIndex = 173;
            this.btnViewCertificate.Text = "View Certificate";
            this.btnViewCertificate.UseVisualStyleBackColor = false;
            this.btnViewCertificate.Visible = false;
            this.btnViewCertificate.Click += new System.EventHandler(this.btnViewCertificate_Click);
            // 
            // DateTo
            // 
            this.DateTo.CustomFormat = "yyyy-MM-dd";
            this.DateTo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTo.Location = new System.Drawing.Point(279, 288);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(259, 27);
            this.DateTo.TabIndex = 172;
            // 
            // DateFrom
            // 
            this.DateFrom.CustomFormat = "yyyy-MM-dd";
            this.DateFrom.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateFrom.Location = new System.Drawing.Point(644, 288);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Size = new System.Drawing.Size(259, 27);
            this.DateFrom.TabIndex = 171;
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(279, 227);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(324, 27);
            this.txtCustName.TabIndex = 169;
            // 
            // lblRID
            // 
            this.lblRID.AutoSize = true;
            this.lblRID.Location = new System.Drawing.Point(894, 135);
            this.lblRID.Name = "lblRID";
            this.lblRID.Size = new System.Drawing.Size(47, 17);
            this.lblRID.TabIndex = 168;
            this.lblRID.Text = "RegID";
            this.lblRID.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(110, 294);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(92, 19);
            this.lblDate.TabIndex = 167;
            this.lblDate.Text = "Select Date";
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTo.Location = new System.Drawing.Point(586, 294);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(26, 19);
            this.lblDateTo.TabIndex = 166;
            this.lblDateTo.Text = "To";
            // 
            // lblBID
            // 
            this.lblBID.AutoSize = true;
            this.lblBID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBID.Location = new System.Drawing.Point(110, 235);
            this.lblBID.Name = "lblBID";
            this.lblBID.Size = new System.Drawing.Size(97, 19);
            this.lblBID.TabIndex = 165;
            this.lblBID.Text = "Enter Name";
            // 
            // cbSeachType
            // 
            this.cbSeachType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbSeachType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbSeachType.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.cbSeachType.FormattingEnabled = true;
            this.cbSeachType.Items.AddRange(new object[] {
            "Date and Name"});
            this.cbSeachType.Location = new System.Drawing.Point(279, 161);
            this.cbSeachType.Name = "cbSeachType";
            this.cbSeachType.Size = new System.Drawing.Size(300, 29);
            this.cbSeachType.TabIndex = 164;
            this.cbSeachType.Visible = false;
            this.cbSeachType.SelectedIndexChanged += new System.EventHandler(this.cbSeachType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 19);
            this.label2.TabIndex = 163;
            this.label2.Text = "Select Search Type";
            this.label2.Visible = false;
            // 
            // txtBID
            // 
            this.txtBID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBID.Location = new System.Drawing.Point(790, 161);
            this.txtBID.Name = "txtBID";
            this.txtBID.Size = new System.Drawing.Size(53, 27);
            this.txtBID.TabIndex = 170;
            this.txtBID.Visible = false;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridViewAddProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnViewCertificate);
            this.Controls.Add(this.DateTo);
            this.Controls.Add(this.DateFrom);
            this.Controls.Add(this.txtBID);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.lblRID);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.lblBID);
            this.Controls.Add(this.cbSeachType);
            this.Controls.Add(this.label2);
            this.Name = "Reports";
            this.Size = new System.Drawing.Size(1249, 769);
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAddProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAddProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnViewCertificate;
        private System.Windows.Forms.DateTimePicker DateTo;
        private System.Windows.Forms.DateTimePicker DateFrom;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblRID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Label lblBID;
        private System.Windows.Forms.ComboBox cbSeachType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBID;
    }
}
