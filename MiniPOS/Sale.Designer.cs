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
            this.sale_product_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sale_totPrice_Label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.sale__dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.sale_price_textBox = new System.Windows.Forms.TextBox();
            this.sale_qty_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sale_remove_button = new System.Windows.Forms.Button();
            this.sale_addToList_button = new System.Windows.Forms.Button();
            this.sale_new_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.sale_TotalPrice_Label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sale_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sale_type_comboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sale_purchase_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sale_qty_numericUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sale_dataGridView1)).BeginInit();
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
            // sale_product_comboBox
            // 
            this.sale_product_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sale_product_comboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_product_comboBox.FormattingEnabled = true;
            this.sale_product_comboBox.Location = new System.Drawing.Point(195, 43);
            this.sale_product_comboBox.Name = "sale_product_comboBox";
            this.sale_product_comboBox.Size = new System.Drawing.Size(291, 33);
            this.sale_product_comboBox.TabIndex = 18;
            this.sale_product_comboBox.SelectedIndexChanged += new System.EventHandler(this.sale_product_comboBox_SelectedIndexChanged);
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
            // sale_totPrice_Label
            // 
            this.sale_totPrice_Label.AutoSize = true;
            this.sale_totPrice_Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_totPrice_Label.Location = new System.Drawing.Point(707, 143);
            this.sale_totPrice_Label.Name = "sale_totPrice_Label";
            this.sale_totPrice_Label.Size = new System.Drawing.Size(47, 25);
            this.sale_totPrice_Label.TabIndex = 3;
            this.sale_totPrice_Label.Text = "0.00";
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(200, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "label13";
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
            // sale__dateTimePicker
            // 
            this.sale__dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale__dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.sale__dateTimePicker.Location = new System.Drawing.Point(195, 93);
            this.sale__dateTimePicker.Name = "sale__dateTimePicker";
            this.sale__dateTimePicker.Size = new System.Drawing.Size(291, 31);
            this.sale__dateTimePicker.TabIndex = 0;
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
            // sale_price_textBox
            // 
            this.sale_price_textBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_price_textBox.Location = new System.Drawing.Point(707, 95);
            this.sale_price_textBox.Name = "sale_price_textBox";
            this.sale_price_textBox.ReadOnly = true;
            this.sale_price_textBox.Size = new System.Drawing.Size(120, 31);
            this.sale_price_textBox.TabIndex = 2;
            this.sale_price_textBox.Text = "0.00";
            this.sale_price_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sale_price_textBox.TextChanged += new System.EventHandler(this.sale_price_textBox_TextChanged);
            // 
            // sale_qty_numericUpDown
            // 
            this.sale_qty_numericUpDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_qty_numericUpDown.Location = new System.Drawing.Point(707, 44);
            this.sale_qty_numericUpDown.Name = "sale_qty_numericUpDown";
            this.sale_qty_numericUpDown.Size = new System.Drawing.Size(120, 31);
            this.sale_qty_numericUpDown.TabIndex = 1;
            this.sale_qty_numericUpDown.ValueChanged += new System.EventHandler(this.sale_qty_numericUpDown_ValueChanged);
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
            this.panel2.Controls.Add(this.sale_remove_button);
            this.panel2.Controls.Add(this.sale_addToList_button);
            this.panel2.Controls.Add(this.sale_new_button);
            this.panel2.Location = new System.Drawing.Point(274, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 77);
            this.panel2.TabIndex = 18;
            // 
            // sale_remove_button
            // 
            this.sale_remove_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_remove_button.Location = new System.Drawing.Point(490, 18);
            this.sale_remove_button.Name = "sale_remove_button";
            this.sale_remove_button.Size = new System.Drawing.Size(182, 41);
            this.sale_remove_button.TabIndex = 6;
            this.sale_remove_button.Text = "Remove From List";
            this.sale_remove_button.UseVisualStyleBackColor = true;
            this.sale_remove_button.Click += new System.EventHandler(this.sale_remove_button_Click);
            // 
            // sale_addToList_button
            // 
            this.sale_addToList_button.Location = new System.Drawing.Point(296, 18);
            this.sale_addToList_button.Name = "sale_addToList_button";
            this.sale_addToList_button.Size = new System.Drawing.Size(136, 41);
            this.sale_addToList_button.TabIndex = 5;
            this.sale_addToList_button.Text = "Add To List";
            this.sale_addToList_button.UseVisualStyleBackColor = true;
            this.sale_addToList_button.Click += new System.EventHandler(this.sale_addToList_button_Click);
            // 
            // sale_new_button
            // 
            this.sale_new_button.Location = new System.Drawing.Point(96, 18);
            this.sale_new_button.Name = "sale_new_button";
            this.sale_new_button.Size = new System.Drawing.Size(136, 41);
            this.sale_new_button.TabIndex = 4;
            this.sale_new_button.Text = "New";
            this.sale_new_button.UseVisualStyleBackColor = true;
            this.sale_new_button.Click += new System.EventHandler(this.sale_new_button_Click);
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
            // sale_TotalPrice_Label
            // 
            this.sale_TotalPrice_Label.AutoSize = true;
            this.sale_TotalPrice_Label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_TotalPrice_Label.Location = new System.Drawing.Point(949, 588);
            this.sale_TotalPrice_Label.Name = "sale_TotalPrice_Label";
            this.sale_TotalPrice_Label.Size = new System.Drawing.Size(47, 25);
            this.sale_TotalPrice_Label.TabIndex = 29;
            this.sale_TotalPrice_Label.Text = "0.00";
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
            // sale_dataGridView1
            // 
            this.sale_dataGridView1.AllowUserToAddRows = false;
            this.sale_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sale_dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.sale_dataGridView1.Location = new System.Drawing.Point(13, 304);
            this.sale_dataGridView1.Name = "sale_dataGridView1";
            this.sale_dataGridView1.RowTemplate.Height = 28;
            this.sale_dataGridView1.Size = new System.Drawing.Size(1060, 272);
            this.sale_dataGridView1.TabIndex = 25;
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
            this.groupBox2.Controls.Add(this.sale_type_comboBox);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.sale_product_comboBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.sale_totPrice_Label);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.sale__dateTimePicker);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.sale_price_textBox);
            this.groupBox2.Controls.Add(this.sale_qty_numericUpDown);
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
            // sale_type_comboBox
            // 
            this.sale_type_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sale_type_comboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_type_comboBox.FormattingEnabled = true;
            this.sale_type_comboBox.Items.AddRange(new object[] {
            "Cash",
            "Contract"});
            this.sale_type_comboBox.Location = new System.Drawing.Point(195, 143);
            this.sale_type_comboBox.Name = "sale_type_comboBox";
            this.sale_type_comboBox.Size = new System.Drawing.Size(291, 33);
            this.sale_type_comboBox.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.sale_purchase_button);
            this.panel1.Location = new System.Drawing.Point(805, 622);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 72);
            this.panel1.TabIndex = 31;
            // 
            // sale_purchase_button
            // 
            this.sale_purchase_button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_purchase_button.Location = new System.Drawing.Point(72, 11);
            this.sale_purchase_button.Name = "sale_purchase_button";
            this.sale_purchase_button.Size = new System.Drawing.Size(136, 42);
            this.sale_purchase_button.TabIndex = 0;
            this.sale_purchase_button.Text = "Purchase";
            this.sale_purchase_button.UseVisualStyleBackColor = true;
            this.sale_purchase_button.Click += new System.EventHandler(this.sale_purchase_button_Click);
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 710);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.sale_TotalPrice_Label);
            this.Controls.Add(this.sale_dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Sale";
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.Sale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sale_qty_numericUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sale_dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox sale_product_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sale_totPrice_Label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker sale__dateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sale_price_textBox;
        private System.Windows.Forms.NumericUpDown sale_qty_numericUpDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button sale_addToList_button;
        private System.Windows.Forms.Button sale_new_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sale_TotalPrice_Label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView sale_dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox sale_type_comboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button sale_purchase_button;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button sale_remove_button;
    }
}