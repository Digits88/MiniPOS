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
            this.cust_search_textBox = new System.Windows.Forms.TextBox();
            this.cust_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cust_delete_button = new System.Windows.Forms.Button();
            this.custCity_comboBox = new System.Windows.Forms.ComboBox();
            this.cust_update_button = new System.Windows.Forms.Button();
            this.cust_save_button = new System.Windows.Forms.Button();
            this.cust_new_button = new System.Windows.Forms.Button();
            this.custKebele_comboBox = new System.Windows.Forms.ComboBox();
            this.custFname_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.custTel_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.custLname_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.custType_textBox = new System.Windows.Forms.TextBox();
            this.custContract_comboBox = new System.Windows.Forms.ComboBox();
            this.custEnd_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cust_dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cust_search_textBox
            // 
            this.cust_search_textBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cust_search_textBox.Location = new System.Drawing.Point(807, 339);
            this.cust_search_textBox.Name = "cust_search_textBox";
            this.cust_search_textBox.Size = new System.Drawing.Size(273, 31);
            this.cust_search_textBox.TabIndex = 15;
            this.cust_search_textBox.TextChanged += new System.EventHandler(this.cust_search_textBox_TextChanged);
            // 
            // cust_dataGridView1
            // 
            this.cust_dataGridView1.AllowUserToAddRows = false;
            this.cust_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cust_dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8,
            this.Column9});
            this.cust_dataGridView1.Location = new System.Drawing.Point(12, 385);
            this.cust_dataGridView1.Name = "cust_dataGridView1";
            this.cust_dataGridView1.RowTemplate.Height = 28;
            this.cust_dataGridView1.Size = new System.Drawing.Size(1068, 281);
            this.cust_dataGridView1.TabIndex = 14;
            this.cust_dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cust_dataGridView1_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.custEnd_dateTimePicker);
            this.groupBox1.Controls.Add(this.custContract_comboBox);
            this.groupBox1.Controls.Add(this.custType_textBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.custCity_comboBox);
            this.groupBox1.Controls.Add(this.custKebele_comboBox);
            this.groupBox1.Controls.Add(this.custFname_textBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.custTel_textBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.custLname_textBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1048, 317);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // cust_delete_button
            // 
            this.cust_delete_button.Location = new System.Drawing.Point(503, 24);
            this.cust_delete_button.Name = "cust_delete_button";
            this.cust_delete_button.Size = new System.Drawing.Size(136, 41);
            this.cust_delete_button.TabIndex = 14;
            this.cust_delete_button.Text = "Delete";
            this.cust_delete_button.UseVisualStyleBackColor = true;
            this.cust_delete_button.Click += new System.EventHandler(this.cust_delete_button_Click);
            // 
            // custCity_comboBox
            // 
            this.custCity_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.custCity_comboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custCity_comboBox.FormattingEnabled = true;
            this.custCity_comboBox.Items.AddRange(new object[] {
            "Hawassa",
            "Wondogenet"});
            this.custCity_comboBox.Location = new System.Drawing.Point(144, 207);
            this.custCity_comboBox.Name = "custCity_comboBox";
            this.custCity_comboBox.Size = new System.Drawing.Size(194, 33);
            this.custCity_comboBox.TabIndex = 9;
            // 
            // cust_update_button
            // 
            this.cust_update_button.Location = new System.Drawing.Point(349, 24);
            this.cust_update_button.Name = "cust_update_button";
            this.cust_update_button.Size = new System.Drawing.Size(136, 41);
            this.cust_update_button.TabIndex = 13;
            this.cust_update_button.Text = "Update";
            this.cust_update_button.UseVisualStyleBackColor = true;
            this.cust_update_button.Click += new System.EventHandler(this.cust_update_button_Click);
            // 
            // cust_save_button
            // 
            this.cust_save_button.Location = new System.Drawing.Point(188, 24);
            this.cust_save_button.Name = "cust_save_button";
            this.cust_save_button.Size = new System.Drawing.Size(136, 41);
            this.cust_save_button.TabIndex = 12;
            this.cust_save_button.Text = "Save";
            this.cust_save_button.UseVisualStyleBackColor = true;
            this.cust_save_button.Click += new System.EventHandler(this.cust_save_button_Click);
            // 
            // cust_new_button
            // 
            this.cust_new_button.Location = new System.Drawing.Point(24, 24);
            this.cust_new_button.Name = "cust_new_button";
            this.cust_new_button.Size = new System.Drawing.Size(136, 41);
            this.cust_new_button.TabIndex = 11;
            this.cust_new_button.Text = "New";
            this.cust_new_button.UseVisualStyleBackColor = true;
            this.cust_new_button.Click += new System.EventHandler(this.cust_new_button_Click);
            // 
            // custKebele_comboBox
            // 
            this.custKebele_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.custKebele_comboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custKebele_comboBox.FormattingEnabled = true;
            this.custKebele_comboBox.Items.AddRange(new object[] {
            "Hogane"});
            this.custKebele_comboBox.Location = new System.Drawing.Point(144, 258);
            this.custKebele_comboBox.Name = "custKebele_comboBox";
            this.custKebele_comboBox.Size = new System.Drawing.Size(194, 33);
            this.custKebele_comboBox.TabIndex = 10;
            // 
            // custFname_textBox
            // 
            this.custFname_textBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custFname_textBox.Location = new System.Drawing.Point(144, 41);
            this.custFname_textBox.Name = "custFname_textBox";
            this.custFname_textBox.Size = new System.Drawing.Size(329, 31);
            this.custFname_textBox.TabIndex = 5;
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
            // custTel_textBox
            // 
            this.custTel_textBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custTel_textBox.Location = new System.Drawing.Point(144, 153);
            this.custTel_textBox.Name = "custTel_textBox";
            this.custTel_textBox.Size = new System.Drawing.Size(329, 31);
            this.custTel_textBox.TabIndex = 7;
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
            // custLname_textBox
            // 
            this.custLname_textBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custLname_textBox.Location = new System.Drawing.Point(144, 97);
            this.custLname_textBox.Name = "custLname_textBox";
            this.custLname_textBox.Size = new System.Drawing.Size(329, 31);
            this.custLname_textBox.TabIndex = 6;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(521, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Customer Type :";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(568, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "End Date :";
            // 
            // custType_textBox
            // 
            this.custType_textBox.Location = new System.Drawing.Point(670, 41);
            this.custType_textBox.Name = "custType_textBox";
            this.custType_textBox.ReadOnly = true;
            this.custType_textBox.Size = new System.Drawing.Size(308, 31);
            this.custType_textBox.TabIndex = 14;
            this.custType_textBox.Text = "Contract";
            // 
            // custContract_comboBox
            // 
            this.custContract_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.custContract_comboBox.FormattingEnabled = true;
            this.custContract_comboBox.Items.AddRange(new object[] {
            "New",
            "Renewal"});
            this.custContract_comboBox.Location = new System.Drawing.Point(670, 97);
            this.custContract_comboBox.Name = "custContract_comboBox";
            this.custContract_comboBox.Size = new System.Drawing.Size(308, 33);
            this.custContract_comboBox.TabIndex = 15;
            // 
            // custEnd_dateTimePicker
            // 
            this.custEnd_dateTimePicker.Location = new System.Drawing.Point(670, 153);
            this.custEnd_dateTimePicker.Name = "custEnd_dateTimePicker";
            this.custEnd_dateTimePicker.Size = new System.Drawing.Size(308, 31);
            this.custEnd_dateTimePicker.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cust_delete_button);
            this.panel1.Controls.Add(this.cust_new_button);
            this.panel1.Controls.Add(this.cust_save_button);
            this.panel1.Controls.Add(this.cust_update_button);
            this.panel1.Location = new System.Drawing.Point(389, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 85);
            this.panel1.TabIndex = 17;
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
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 678);
            this.Controls.Add(this.cust_search_textBox);
            this.Controls.Add(this.cust_dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cust_dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cust_search_textBox;
        private System.Windows.Forms.DataGridView cust_dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cust_delete_button;
        private System.Windows.Forms.ComboBox custCity_comboBox;
        private System.Windows.Forms.Button cust_update_button;
        private System.Windows.Forms.Button cust_save_button;
        private System.Windows.Forms.Button cust_new_button;
        private System.Windows.Forms.ComboBox custKebele_comboBox;
        private System.Windows.Forms.TextBox custFname_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox custTel_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox custLname_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker custEnd_dateTimePicker;
        private System.Windows.Forms.ComboBox custContract_comboBox;
        private System.Windows.Forms.TextBox custType_textBox;
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