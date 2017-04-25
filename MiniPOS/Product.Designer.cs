namespace MiniPOS
{
    partial class Product
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboItemProdType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClearItemNew = new System.Windows.Forms.Button();
            this.btnSaveNewItem = new System.Windows.Forms.Button();
            this.txtItemProdName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInvDelete = new System.Windows.Forms.Button();
            this.btnInvUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerInvExpiry = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInvSave = new System.Windows.Forms.Button();
            this.btnInvClearNew = new System.Windows.Forms.Button();
            this.txtInvUnitPrice = new System.Windows.Forms.TextBox();
            this.numericInvQty = new System.Windows.Forms.NumericUpDown();
            this.cboInvProduct = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInvSearch = new System.Windows.Forms.TextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericInvQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboItemProdType);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtItemProdName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 247);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // cboItemProdType
            // 
            this.cboItemProdType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboItemProdType.FormattingEnabled = true;
            this.cboItemProdType.Items.AddRange(new object[] {
            "Milk - 1 Liter",
            "Milk - 2 Liter",
            "Pasturized Milk - 0.5 Liter",
            "Pasturized Milk - 1 Liter",
            "Cheese - 0.5 Kg",
            "Cheese - 1 Kg",
            "Butter - 0.5 Kg",
            "Butter - 1 Kg",
            "Yoghurt - Small",
            "Yoghurt - Big"});
            this.cboItemProdType.Location = new System.Drawing.Point(144, 94);
            this.cboItemProdType.Name = "cboItemProdType";
            this.cboItemProdType.Size = new System.Drawing.Size(235, 33);
            this.cboItemProdType.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClearItemNew);
            this.panel1.Controls.Add(this.btnSaveNewItem);
            this.panel1.Location = new System.Drawing.Point(6, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 85);
            this.panel1.TabIndex = 17;
            // 
            // btnClearItemNew
            // 
            this.btnClearItemNew.Location = new System.Drawing.Point(137, 20);
            this.btnClearItemNew.Name = "btnClearItemNew";
            this.btnClearItemNew.Size = new System.Drawing.Size(136, 41);
            this.btnClearItemNew.TabIndex = 3;
            this.btnClearItemNew.Text = "New";
            this.btnClearItemNew.UseVisualStyleBackColor = true;
            this.btnClearItemNew.Click += new System.EventHandler(this.item_new_button_Click);
            // 
            // btnSaveNewItem
            // 
            this.btnSaveNewItem.Location = new System.Drawing.Point(330, 20);
            this.btnSaveNewItem.Name = "btnSaveNewItem";
            this.btnSaveNewItem.Size = new System.Drawing.Size(136, 41);
            this.btnSaveNewItem.TabIndex = 2;
            this.btnSaveNewItem.Text = "Save";
            this.btnSaveNewItem.UseVisualStyleBackColor = true;
            this.btnSaveNewItem.Click += new System.EventHandler(this.item_save_button_Click);
            // 
            // txtItemProdName
            // 
            this.txtItemProdName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemProdName.Location = new System.Drawing.Point(144, 41);
            this.txtItemProdName.Name = "txtItemProdName";
            this.txtItemProdName.Size = new System.Drawing.Size(329, 31);
            this.txtItemProdName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Type :";
            // 
            // btnInvDelete
            // 
            this.btnInvDelete.Location = new System.Drawing.Point(14, 179);
            this.btnInvDelete.Name = "btnInvDelete";
            this.btnInvDelete.Size = new System.Drawing.Size(136, 41);
            this.btnInvDelete.TabIndex = 10;
            this.btnInvDelete.Text = "Delete";
            this.btnInvDelete.UseVisualStyleBackColor = true;
            this.btnInvDelete.Click += new System.EventHandler(this.btnInvDelete_Click);
            // 
            // btnInvUpdate
            // 
            this.btnInvUpdate.Location = new System.Drawing.Point(14, 121);
            this.btnInvUpdate.Name = "btnInvUpdate";
            this.btnInvUpdate.Size = new System.Drawing.Size(136, 41);
            this.btnInvUpdate.TabIndex = 9;
            this.btnInvUpdate.Text = "Update";
            this.btnInvUpdate.UseVisualStyleBackColor = true;
            this.btnInvUpdate.Click += new System.EventHandler(this.btnInvUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dateTimePickerInvExpiry);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.txtInvUnitPrice);
            this.groupBox2.Controls.Add(this.numericInvQty);
            this.groupBox2.Controls.Add(this.cboInvProduct);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(559, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(578, 273);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(245, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "ETB";
            // 
            // dateTimePickerInvExpiry
            // 
            this.dateTimePickerInvExpiry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerInvExpiry.Location = new System.Drawing.Point(119, 93);
            this.dateTimePickerInvExpiry.Name = "dateTimePickerInvExpiry";
            this.dateTimePickerInvExpiry.Size = new System.Drawing.Size(270, 31);
            this.dateTimePickerInvExpiry.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Expiry Date :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnInvSave);
            this.panel2.Controls.Add(this.btnInvClearNew);
            this.panel2.Controls.Add(this.btnInvUpdate);
            this.panel2.Controls.Add(this.btnInvDelete);
            this.panel2.Location = new System.Drawing.Point(407, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 239);
            this.panel2.TabIndex = 18;
            // 
            // btnInvSave
            // 
            this.btnInvSave.Location = new System.Drawing.Point(14, 63);
            this.btnInvSave.Name = "btnInvSave";
            this.btnInvSave.Size = new System.Drawing.Size(136, 41);
            this.btnInvSave.TabIndex = 8;
            this.btnInvSave.Text = "Save";
            this.btnInvSave.UseVisualStyleBackColor = true;
            this.btnInvSave.Click += new System.EventHandler(this.btnInvSave_Click);
            // 
            // btnInvClearNew
            // 
            this.btnInvClearNew.Location = new System.Drawing.Point(14, 7);
            this.btnInvClearNew.Name = "btnInvClearNew";
            this.btnInvClearNew.Size = new System.Drawing.Size(136, 41);
            this.btnInvClearNew.TabIndex = 7;
            this.btnInvClearNew.Text = "New";
            this.btnInvClearNew.UseVisualStyleBackColor = true;
            this.btnInvClearNew.Click += new System.EventHandler(this.btnInvClearNew_Click);
            // 
            // txtInvUnitPrice
            // 
            this.txtInvUnitPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvUnitPrice.Location = new System.Drawing.Point(119, 195);
            this.txtInvUnitPrice.Name = "txtInvUnitPrice";
            this.txtInvUnitPrice.Size = new System.Drawing.Size(120, 31);
            this.txtInvUnitPrice.TabIndex = 6;
            this.txtInvUnitPrice.Text = "0.00";
            this.txtInvUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericInvQty
            // 
            this.numericInvQty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericInvQty.Location = new System.Drawing.Point(119, 148);
            this.numericInvQty.Name = "numericInvQty";
            this.numericInvQty.Size = new System.Drawing.Size(120, 31);
            this.numericInvQty.TabIndex = 5;
            // 
            // cboInvProduct
            // 
            this.cboInvProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboInvProduct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboInvProduct.FormattingEnabled = true;
            this.cboInvProduct.Location = new System.Drawing.Point(119, 41);
            this.cboInvProduct.Name = "cboInvProduct";
            this.cboInvProduct.Size = new System.Drawing.Size(270, 33);
            this.cboInvProduct.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Unit Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quantity :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Product :";
            // 
            // txtInvSearch
            // 
            this.txtInvSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvSearch.Location = new System.Drawing.Point(807, 292);
            this.txtInvSearch.Name = "txtInvSearch";
            this.txtInvSearch.ReadOnly = true;
            this.txtInvSearch.Size = new System.Drawing.Size(330, 31);
            this.txtInvSearch.TabIndex = 11;
            this.txtInvSearch.TextChanged += new System.EventHandler(this.txtInvSearch_TextChanged);
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvInventory.Location = new System.Drawing.Point(12, 338);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowTemplate.Height = 28;
            this.dgvInventory.Size = new System.Drawing.Size(1125, 268);
            this.dgvInventory.TabIndex = 16;
            this.dgvInventory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvInventory_MouseClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.FillWeight = 150F;
            this.Column1.HeaderText = "Product Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 150F;
            this.Column2.HeaderText = "Product Type";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 150F;
            this.Column3.HeaderText = "Expiry Date";
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
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 609);
            this.Controls.Add(this.txtInvSearch);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericInvQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInvDelete;
        private System.Windows.Forms.Button btnClearItemNew;
        private System.Windows.Forms.Button btnSaveNewItem;
        private System.Windows.Forms.Button btnInvUpdate;
        private System.Windows.Forms.TextBox txtItemProdName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboItemProdType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInvSave;
        private System.Windows.Forms.Button btnInvClearNew;
        private System.Windows.Forms.TextBox txtInvUnitPrice;
        private System.Windows.Forms.NumericUpDown numericInvQty;
        private System.Windows.Forms.ComboBox cboInvProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInvSearch;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerInvExpiry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}