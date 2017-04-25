namespace MiniPOS
{
    partial class Sale
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
            this.label8 = new System.Windows.Forms.Label();
            this.cboSaleProductName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSaleTotalPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.datePickerSaleDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSaleUnitPrice = new System.Windows.Forms.TextBox();
            this.numericSaleQty = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSaleRemoveFromList = new System.Windows.Forms.Button();
            this.btnSaleAddToList = new System.Windows.Forms.Button();
            this.btnSaleClearNew = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSaleSumTotalPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvSalePurchaseList = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboSaleType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalePurchase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericSaleQty)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalePurchaseList)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(82, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Sales Type :";
            // 
            // cboSaleProductName
            // 
            this.cboSaleProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSaleProductName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSaleProductName.FormattingEnabled = true;
            this.cboSaleProductName.Location = new System.Drawing.Point(195, 43);
            this.cboSaleProductName.Name = "cboSaleProductName";
            this.cboSaleProductName.Size = new System.Drawing.Size(291, 33);
            this.cboSaleProductName.TabIndex = 18;
            this.cboSaleProductName.SelectedIndexChanged += new System.EventHandler(this.sale_product_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Product :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(772, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "ETB";
            // 
            // lblSaleTotalPrice
            // 
            this.lblSaleTotalPrice.AutoSize = true;
            this.lblSaleTotalPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleTotalPrice.Location = new System.Drawing.Point(707, 143);
            this.lblSaleTotalPrice.Name = "lblSaleTotalPrice";
            this.lblSaleTotalPrice.Size = new System.Drawing.Size(47, 25);
            this.lblSaleTotalPrice.TabIndex = 3;
            this.lblSaleTotalPrice.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(833, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "ETB";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(200, 20);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(60, 20);
            this.lblProductId.TabIndex = 26;
            this.lblProductId.Text = "label13";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1024, 588);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 25);
            this.label12.TabIndex = 30;
            this.label12.Text = "ETB";
            // 
            // datePickerSaleDate
            // 
            this.datePickerSaleDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerSaleDate.Location = new System.Drawing.Point(195, 93);
            this.datePickerSaleDate.Name = "datePickerSaleDate";
            this.datePickerSaleDate.Size = new System.Drawing.Size(291, 31);
            this.datePickerSaleDate.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(603, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Quantity :";
            // 
            // txtSaleUnitPrice
            // 
            this.txtSaleUnitPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleUnitPrice.Location = new System.Drawing.Point(707, 95);
            this.txtSaleUnitPrice.Name = "txtSaleUnitPrice";
            this.txtSaleUnitPrice.ReadOnly = true;
            this.txtSaleUnitPrice.Size = new System.Drawing.Size(120, 31);
            this.txtSaleUnitPrice.TabIndex = 2;
            this.txtSaleUnitPrice.Text = "0.00";
            this.txtSaleUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSaleUnitPrice.TextChanged += new System.EventHandler(this.txtSaleUnitPrice_TextChanged);
            // 
            // numericSaleQty
            // 
            this.numericSaleQty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericSaleQty.Location = new System.Drawing.Point(707, 44);
            this.numericSaleQty.Name = "numericSaleQty";
            this.numericSaleQty.Size = new System.Drawing.Size(120, 31);
            this.numericSaleQty.TabIndex = 1;
            this.numericSaleQty.ValueChanged += new System.EventHandler(this.numericSaleQty_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(810, 588);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 25);
            this.label11.TabIndex = 28;
            this.label11.Text = "Sum Total :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSaleRemoveFromList);
            this.panel2.Controls.Add(this.btnSaleAddToList);
            this.panel2.Controls.Add(this.btnSaleClearNew);
            this.panel2.Location = new System.Drawing.Point(274, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 77);
            this.panel2.TabIndex = 18;
            // 
            // btnSaleRemoveFromList
            // 
            this.btnSaleRemoveFromList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleRemoveFromList.Location = new System.Drawing.Point(490, 18);
            this.btnSaleRemoveFromList.Name = "btnSaleRemoveFromList";
            this.btnSaleRemoveFromList.Size = new System.Drawing.Size(182, 41);
            this.btnSaleRemoveFromList.TabIndex = 6;
            this.btnSaleRemoveFromList.Text = "Remove From List";
            this.btnSaleRemoveFromList.UseVisualStyleBackColor = true;
            this.btnSaleRemoveFromList.Click += new System.EventHandler(this.btnSaleRemoveFromList_Click);
            // 
            // btnSaleAddToList
            // 
            this.btnSaleAddToList.Location = new System.Drawing.Point(296, 18);
            this.btnSaleAddToList.Name = "btnSaleAddToList";
            this.btnSaleAddToList.Size = new System.Drawing.Size(136, 41);
            this.btnSaleAddToList.TabIndex = 5;
            this.btnSaleAddToList.Text = "Add To List";
            this.btnSaleAddToList.UseVisualStyleBackColor = true;
            this.btnSaleAddToList.Click += new System.EventHandler(this.btnSaleAddToList_Click);
            // 
            // btnSaleClearNew
            // 
            this.btnSaleClearNew.Location = new System.Drawing.Point(96, 18);
            this.btnSaleClearNew.Name = "btnSaleClearNew";
            this.btnSaleClearNew.Size = new System.Drawing.Size(136, 41);
            this.btnSaleClearNew.TabIndex = 4;
            this.btnSaleClearNew.Text = "New";
            this.btnSaleClearNew.UseVisualStyleBackColor = true;
            this.btnSaleClearNew.Click += new System.EventHandler(this.btnSaleClearNew_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(598, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Unit Price :";
            // 
            // lblSaleSumTotalPrice
            // 
            this.lblSaleSumTotalPrice.AutoSize = true;
            this.lblSaleSumTotalPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleSumTotalPrice.Location = new System.Drawing.Point(949, 588);
            this.lblSaleSumTotalPrice.Name = "lblSaleSumTotalPrice";
            this.lblSaleSumTotalPrice.Size = new System.Drawing.Size(47, 25);
            this.lblSaleSumTotalPrice.TabIndex = 29;
            this.lblSaleSumTotalPrice.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(601, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sales Date :";
            // 
            // dgvSalePurchaseList
            // 
            this.dgvSalePurchaseList.AllowUserToAddRows = false;
            this.dgvSalePurchaseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalePurchaseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvSalePurchaseList.Location = new System.Drawing.Point(13, 304);
            this.dgvSalePurchaseList.Name = "dgvSalePurchaseList";
            this.dgvSalePurchaseList.RowTemplate.Height = 28;
            this.dgvSalePurchaseList.Size = new System.Drawing.Size(1060, 272);
            this.dgvSalePurchaseList.TabIndex = 25;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.FillWeight = 90F;
            this.Column9.HeaderText = "Id";
            this.Column9.Name = "Column9";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 150F;
            this.Column1.HeaderText = "Product";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 150F;
            this.Column2.HeaderText = "Sales Date";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 150F;
            this.Column3.HeaderText = "Sales Type";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.FillWeight = 150F;
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.FillWeight = 150F;
            this.Column5.HeaderText = "Unit Price";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.FillWeight = 150F;
            this.Column6.HeaderText = "Total Price";
            this.Column6.Name = "Column6";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboSaleType);
            this.groupBox2.Controls.Add(this.lblProductId);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cboSaleProductName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblSaleTotalPrice);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.datePickerSaleDate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtSaleUnitPrice);
            this.groupBox2.Controls.Add(this.numericSaleQty);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1061, 280);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // cboSaleType
            // 
            this.cboSaleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSaleType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSaleType.FormattingEnabled = true;
            this.cboSaleType.Items.AddRange(new object[] {
            "Cash",
            "Contract"});
            this.cboSaleType.Location = new System.Drawing.Point(195, 143);
            this.cboSaleType.Name = "cboSaleType";
            this.cboSaleType.Size = new System.Drawing.Size(291, 33);
            this.cboSaleType.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSalePurchase);
            this.panel1.Location = new System.Drawing.Point(805, 622);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 72);
            this.panel1.TabIndex = 31;
            // 
            // btnSalePurchase
            // 
            this.btnSalePurchase.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalePurchase.Location = new System.Drawing.Point(72, 11);
            this.btnSalePurchase.Name = "btnSalePurchase";
            this.btnSalePurchase.Size = new System.Drawing.Size(136, 42);
            this.btnSalePurchase.TabIndex = 0;
            this.btnSalePurchase.Text = "Purchase";
            this.btnSalePurchase.UseVisualStyleBackColor = true;
            this.btnSalePurchase.Click += new System.EventHandler(this.btnSalePurchase_Click);
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 710);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblSaleSumTotalPrice);
            this.Controls.Add(this.dgvSalePurchaseList);
            this.Controls.Add(this.groupBox2);
            this.Name = "Sale";
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericSaleQty)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalePurchaseList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboSaleProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSaleTotalPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker datePickerSaleDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSaleUnitPrice;
        private System.Windows.Forms.NumericUpDown numericSaleQty;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSaleAddToList;
        private System.Windows.Forms.Button btnSaleClearNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSaleSumTotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvSalePurchaseList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboSaleType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalePurchase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnSaleRemoveFromList;
    }
}