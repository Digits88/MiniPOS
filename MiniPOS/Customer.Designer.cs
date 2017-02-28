namespace MiniPOS
{
    partial class Customer
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
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.dgvCustomerInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnClearCustomerInfo = new System.Windows.Forms.Button();
            this.btnSaveNewCustomer = new System.Windows.Forms.Button();
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.custEnd_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cboContract = new System.Windows.Forms.ComboBox();
            this.txtCustomerType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.cboKebele = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomer.Location = new System.Drawing.Point(807, 339);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(273, 31);
            this.txtSearchCustomer.TabIndex = 15;
            this.txtSearchCustomer.TextChanged += new System.EventHandler(this.txtSearchCustomer_TextChanged);
            // 
            // dgvCustomerInfo
            // 
            this.dgvCustomerInfo.AllowUserToAddRows = false;
            this.dgvCustomerInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvCustomerInfo.Location = new System.Drawing.Point(12, 385);
            this.dgvCustomerInfo.Name = "dgvCustomerInfo";
            this.dgvCustomerInfo.RowTemplate.Height = 28;
            this.dgvCustomerInfo.Size = new System.Drawing.Size(1068, 281);
            this.dgvCustomerInfo.TabIndex = 14;
            this.dgvCustomerInfo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvCustomerInfo_MouseClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 150F;
            this.Column1.HeaderText = "First Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 150F;
            this.Column2.HeaderText = "Last Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 150F;
            this.Column3.HeaderText = "Telephone";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.FillWeight = 150F;
            this.Column4.HeaderText = "City";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.FillWeight = 150F;
            this.Column5.HeaderText = "Kebele";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.FillWeight = 150F;
            this.Column7.HeaderText = "Contract Type";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.FillWeight = 150F;
            this.Column8.HeaderText = "Start Date";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.FillWeight = 150F;
            this.Column9.HeaderText = "End Date";
            this.Column9.Name = "Column9";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.custEnd_dateTimePicker);
            this.groupBox1.Controls.Add(this.cboContract);
            this.groupBox1.Controls.Add(this.txtCustomerType);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboCity);
            this.groupBox1.Controls.Add(this.cboKebele);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTelephone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1048, 317);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDeleteCustomer);
            this.panel1.Controls.Add(this.btnClearCustomerInfo);
            this.panel1.Controls.Add(this.btnSaveNewCustomer);
            this.panel1.Controls.Add(this.btnUpdateCustomer);
            this.panel1.Location = new System.Drawing.Point(389, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 85);
            this.panel1.TabIndex = 17;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Location = new System.Drawing.Point(503, 24);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(136, 41);
            this.btnDeleteCustomer.TabIndex = 14;
            this.btnDeleteCustomer.Text = "Delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnClearCustomerInfo
            // 
            this.btnClearCustomerInfo.Location = new System.Drawing.Point(24, 24);
            this.btnClearCustomerInfo.Name = "btnClearCustomerInfo";
            this.btnClearCustomerInfo.Size = new System.Drawing.Size(136, 41);
            this.btnClearCustomerInfo.TabIndex = 11;
            this.btnClearCustomerInfo.Text = "New";
            this.btnClearCustomerInfo.UseVisualStyleBackColor = true;
            this.btnClearCustomerInfo.Click += new System.EventHandler(this.btnClearCustomerInfo_Click);
            // 
            // btnSaveNewCustomer
            // 
            this.btnSaveNewCustomer.Location = new System.Drawing.Point(188, 24);
            this.btnSaveNewCustomer.Name = "btnSaveNewCustomer";
            this.btnSaveNewCustomer.Size = new System.Drawing.Size(136, 41);
            this.btnSaveNewCustomer.TabIndex = 12;
            this.btnSaveNewCustomer.Text = "Save";
            this.btnSaveNewCustomer.UseVisualStyleBackColor = true;
            this.btnSaveNewCustomer.Click += new System.EventHandler(this.btnSaveNewCustomer_Click);
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(349, 24);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(136, 41);
            this.btnUpdateCustomer.TabIndex = 13;
            this.btnUpdateCustomer.Text = "Update";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // custEnd_dateTimePicker
            // 
            this.custEnd_dateTimePicker.Location = new System.Drawing.Point(670, 153);
            this.custEnd_dateTimePicker.Name = "custEnd_dateTimePicker";
            this.custEnd_dateTimePicker.Size = new System.Drawing.Size(308, 31);
            this.custEnd_dateTimePicker.TabIndex = 16;
            // 
            // cboContract
            // 
            this.cboContract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboContract.FormattingEnabled = true;
            this.cboContract.Items.AddRange(new object[] {
            "New",
            "Renewal"});
            this.cboContract.Location = new System.Drawing.Point(670, 97);
            this.cboContract.Name = "cboContract";
            this.cboContract.Size = new System.Drawing.Size(308, 33);
            this.cboContract.TabIndex = 15;
            // 
            // txtCustomerType
            // 
            this.txtCustomerType.Location = new System.Drawing.Point(670, 41);
            this.txtCustomerType.Name = "txtCustomerType";
            this.txtCustomerType.ReadOnly = true;
            this.txtCustomerType.Size = new System.Drawing.Size(308, 31);
            this.txtCustomerType.TabIndex = 14;
            this.txtCustomerType.Text = "Contract";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(568, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "End Date :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(531, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Contract Type :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(521, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Customer Type :";
            // 
            // cboCity
            // 
            this.cboCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Items.AddRange(new object[] {
            "Hawassa",
            "Wondogenet"});
            this.cboCity.Location = new System.Drawing.Point(144, 207);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(194, 33);
            this.cboCity.TabIndex = 9;
            // 
            // cboKebele
            // 
            this.cboKebele.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKebele.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKebele.FormattingEnabled = true;
            this.cboKebele.Items.AddRange(new object[] {
            "Hogane"});
            this.cboKebele.Location = new System.Drawing.Point(144, 258);
            this.cboKebele.Name = "cboKebele";
            this.cboKebele.Size = new System.Drawing.Size(194, 33);
            this.cboKebele.TabIndex = 10;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(144, 41);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(329, 31);
            this.txtFirstName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name :";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.Location = new System.Drawing.Point(144, 153);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(329, 31);
            this.txtTelephone.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telephone :";
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(144, 97);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(329, 31);
            this.txtLastName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "City :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kebele :";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 678);
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.dgvCustomerInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.DataGridView dgvCustomerInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.Button btnSaveNewCustomer;
        private System.Windows.Forms.Button btnClearCustomerInfo;
        private System.Windows.Forms.ComboBox cboKebele;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker custEnd_dateTimePicker;
        private System.Windows.Forms.ComboBox cboContract;
        private System.Windows.Forms.TextBox txtCustomerType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
    }
}