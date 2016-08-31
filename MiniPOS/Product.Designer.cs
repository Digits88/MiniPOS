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
            this.ItemProdType_comboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.item_new_button = new System.Windows.Forms.Button();
            this.item_save_button = new System.Windows.Forms.Button();
            this.itemProdName_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inv_delete_button = new System.Windows.Forms.Button();
            this.inv_update_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.inv_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inv_save_button = new System.Windows.Forms.Button();
            this.inv_new_button = new System.Windows.Forms.Button();
            this.inv_UPrice_textBox = new System.Windows.Forms.TextBox();
            this.inv_Qty_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.inv_Product_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inv_search_textBox = new System.Windows.Forms.TextBox();
            this.inv_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inv_Qty_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv_dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ItemProdType_comboBox);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.itemProdName_textBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 247);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // ItemProdType_comboBox
            // 
            this.ItemProdType_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemProdType_comboBox.FormattingEnabled = true;
            this.ItemProdType_comboBox.Items.AddRange(new object[] {
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
            this.ItemProdType_comboBox.Location = new System.Drawing.Point(144, 94);
            this.ItemProdType_comboBox.Name = "ItemProdType_comboBox";
            this.ItemProdType_comboBox.Size = new System.Drawing.Size(235, 33);
            this.ItemProdType_comboBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.item_new_button);
            this.panel1.Controls.Add(this.item_save_button);
            this.panel1.Location = new System.Drawing.Point(6, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 85);
            this.panel1.TabIndex = 17;
            // 
            // item_new_button
            // 
            this.item_new_button.Location = new System.Drawing.Point(137, 20);
            this.item_new_button.Name = "item_new_button";
            this.item_new_button.Size = new System.Drawing.Size(136, 41);
            this.item_new_button.TabIndex = 3;
            this.item_new_button.Text = "New";
            this.item_new_button.UseVisualStyleBackColor = true;
            this.item_new_button.Click += new System.EventHandler(this.item_new_button_Click);
            // 
            // item_save_button
            // 
            this.item_save_button.Location = new System.Drawing.Point(330, 20);
            this.item_save_button.Name = "item_save_button";
            this.item_save_button.Size = new System.Drawing.Size(136, 41);
            this.item_save_button.TabIndex = 2;
            this.item_save_button.Text = "Save";
            this.item_save_button.UseVisualStyleBackColor = true;
            this.item_save_button.Click += new System.EventHandler(this.item_save_button_Click);
            // 
            // itemProdName_textBox
            // 
            this.itemProdName_textBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemProdName_textBox.Location = new System.Drawing.Point(144, 41);
            this.itemProdName_textBox.Name = "itemProdName_textBox";
            this.itemProdName_textBox.Size = new System.Drawing.Size(329, 31);
            this.itemProdName_textBox.TabIndex = 0;
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
            // inv_delete_button
            // 
            this.inv_delete_button.Location = new System.Drawing.Point(14, 179);
            this.inv_delete_button.Name = "inv_delete_button";
            this.inv_delete_button.Size = new System.Drawing.Size(136, 41);
            this.inv_delete_button.TabIndex = 10;
            this.inv_delete_button.Text = "Delete";
            this.inv_delete_button.UseVisualStyleBackColor = true;
            this.inv_delete_button.Click += new System.EventHandler(this.inv_delete_button_Click);
            // 
            // inv_update_button
            // 
            this.inv_update_button.Location = new System.Drawing.Point(14, 121);
            this.inv_update_button.Name = "inv_update_button";
            this.inv_update_button.Size = new System.Drawing.Size(136, 41);
            this.inv_update_button.TabIndex = 9;
            this.inv_update_button.Text = "Update";
            this.inv_update_button.UseVisualStyleBackColor = true;
            this.inv_update_button.Click += new System.EventHandler(this.inv_update_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.inv_dateTimePicker);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.inv_UPrice_textBox);
            this.groupBox2.Controls.Add(this.inv_Qty_numericUpDown);
            this.groupBox2.Controls.Add(this.inv_Product_comboBox);
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
            // inv_dateTimePicker
            // 
            this.inv_dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inv_dateTimePicker.Location = new System.Drawing.Point(119, 93);
            this.inv_dateTimePicker.Name = "inv_dateTimePicker";
            this.inv_dateTimePicker.Size = new System.Drawing.Size(270, 31);
            this.inv_dateTimePicker.TabIndex = 20;
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
            this.panel2.Controls.Add(this.inv_save_button);
            this.panel2.Controls.Add(this.inv_new_button);
            this.panel2.Controls.Add(this.inv_update_button);
            this.panel2.Controls.Add(this.inv_delete_button);
            this.panel2.Location = new System.Drawing.Point(407, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 239);
            this.panel2.TabIndex = 18;
            // 
            // inv_save_button
            // 
            this.inv_save_button.Location = new System.Drawing.Point(14, 63);
            this.inv_save_button.Name = "inv_save_button";
            this.inv_save_button.Size = new System.Drawing.Size(136, 41);
            this.inv_save_button.TabIndex = 8;
            this.inv_save_button.Text = "Save";
            this.inv_save_button.UseVisualStyleBackColor = true;
            this.inv_save_button.Click += new System.EventHandler(this.inv_save_button_Click);
            // 
            // inv_new_button
            // 
            this.inv_new_button.Location = new System.Drawing.Point(14, 7);
            this.inv_new_button.Name = "inv_new_button";
            this.inv_new_button.Size = new System.Drawing.Size(136, 41);
            this.inv_new_button.TabIndex = 7;
            this.inv_new_button.Text = "New";
            this.inv_new_button.UseVisualStyleBackColor = true;
            this.inv_new_button.Click += new System.EventHandler(this.inv_new_button_Click);
            // 
            // inv_UPrice_textBox
            // 
            this.inv_UPrice_textBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inv_UPrice_textBox.Location = new System.Drawing.Point(119, 195);
            this.inv_UPrice_textBox.Name = "inv_UPrice_textBox";
            this.inv_UPrice_textBox.Size = new System.Drawing.Size(120, 31);
            this.inv_UPrice_textBox.TabIndex = 6;
            this.inv_UPrice_textBox.Text = "0.00";
            this.inv_UPrice_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // inv_Qty_numericUpDown
            // 
            this.inv_Qty_numericUpDown.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inv_Qty_numericUpDown.Location = new System.Drawing.Point(119, 148);
            this.inv_Qty_numericUpDown.Name = "inv_Qty_numericUpDown";
            this.inv_Qty_numericUpDown.Size = new System.Drawing.Size(120, 31);
            this.inv_Qty_numericUpDown.TabIndex = 5;
            // 
            // inv_Product_comboBox
            // 
            this.inv_Product_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inv_Product_comboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inv_Product_comboBox.FormattingEnabled = true;
            this.inv_Product_comboBox.Location = new System.Drawing.Point(119, 41);
            this.inv_Product_comboBox.Name = "inv_Product_comboBox";
            this.inv_Product_comboBox.Size = new System.Drawing.Size(270, 33);
            this.inv_Product_comboBox.TabIndex = 4;
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
            // inv_search_textBox
            // 
            this.inv_search_textBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inv_search_textBox.Location = new System.Drawing.Point(807, 292);
            this.inv_search_textBox.Name = "inv_search_textBox";
            this.inv_search_textBox.ReadOnly = true;
            this.inv_search_textBox.Size = new System.Drawing.Size(330, 31);
            this.inv_search_textBox.TabIndex = 11;
            this.inv_search_textBox.TextChanged += new System.EventHandler(this.inv_search_textBox_TextChanged);
            // 
            // inv_dataGridView1
            // 
            this.inv_dataGridView1.AllowUserToAddRows = false;
            this.inv_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inv_dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.inv_dataGridView1.Location = new System.Drawing.Point(12, 338);
            this.inv_dataGridView1.Name = "inv_dataGridView1";
            this.inv_dataGridView1.RowTemplate.Height = 28;
            this.inv_dataGridView1.Size = new System.Drawing.Size(1125, 268);
            this.inv_dataGridView1.TabIndex = 16;
            this.inv_dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inv_dataGridView1_MouseClick);
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
            this.Controls.Add(this.inv_search_textBox);
            this.Controls.Add(this.inv_dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.inv_Qty_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inv_dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button inv_delete_button;
        private System.Windows.Forms.Button item_new_button;
        private System.Windows.Forms.Button item_save_button;
        private System.Windows.Forms.Button inv_update_button;
        private System.Windows.Forms.TextBox itemProdName_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ItemProdType_comboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button inv_save_button;
        private System.Windows.Forms.Button inv_new_button;
        private System.Windows.Forms.TextBox inv_UPrice_textBox;
        private System.Windows.Forms.NumericUpDown inv_Qty_numericUpDown;
        private System.Windows.Forms.ComboBox inv_Product_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inv_search_textBox;
        private System.Windows.Forms.DataGridView inv_dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker inv_dateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}