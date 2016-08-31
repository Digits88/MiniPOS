namespace MiniPOS
{
    partial class Supplier
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firstName_textBox = new System.Windows.Forms.TextBox();
            this.lastName_textBox = new System.Windows.Forms.TextBox();
            this.tel_textBox = new System.Windows.Forms.TextBox();
            this.city_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sup_delete_button = new System.Windows.Forms.Button();
            this.sup_update_button = new System.Windows.Forms.Button();
            this.sup_save_button = new System.Windows.Forms.Button();
            this.sup_new_button = new System.Windows.Forms.Button();
            this.kebele_comboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sup_search_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // firstName_textBox
            // 
            this.firstName_textBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName_textBox.Location = new System.Drawing.Point(144, 41);
            this.firstName_textBox.Name = "firstName_textBox";
            this.firstName_textBox.Size = new System.Drawing.Size(329, 31);
            this.firstName_textBox.TabIndex = 5;
            // 
            // lastName_textBox
            // 
            this.lastName_textBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_textBox.Location = new System.Drawing.Point(144, 97);
            this.lastName_textBox.Name = "lastName_textBox";
            this.lastName_textBox.Size = new System.Drawing.Size(329, 31);
            this.lastName_textBox.TabIndex = 6;
            // 
            // tel_textBox
            // 
            this.tel_textBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tel_textBox.Location = new System.Drawing.Point(144, 153);
            this.tel_textBox.Name = "tel_textBox";
            this.tel_textBox.Size = new System.Drawing.Size(329, 31);
            this.tel_textBox.TabIndex = 7;
            // 
            // city_comboBox
            // 
            this.city_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.city_comboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city_comboBox.FormattingEnabled = true;
            this.city_comboBox.Items.AddRange(new object[] {
            "Hawassa",
            "Wondogenet"});
            this.city_comboBox.Location = new System.Drawing.Point(144, 207);
            this.city_comboBox.Name = "city_comboBox";
            this.city_comboBox.Size = new System.Drawing.Size(194, 33);
            this.city_comboBox.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sup_delete_button);
            this.groupBox1.Controls.Add(this.city_comboBox);
            this.groupBox1.Controls.Add(this.sup_update_button);
            this.groupBox1.Controls.Add(this.sup_save_button);
            this.groupBox1.Controls.Add(this.sup_new_button);
            this.groupBox1.Controls.Add(this.kebele_comboBox);
            this.groupBox1.Controls.Add(this.firstName_textBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tel_textBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lastName_textBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(770, 317);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // sup_delete_button
            // 
            this.sup_delete_button.Location = new System.Drawing.Point(529, 228);
            this.sup_delete_button.Name = "sup_delete_button";
            this.sup_delete_button.Size = new System.Drawing.Size(136, 41);
            this.sup_delete_button.TabIndex = 14;
            this.sup_delete_button.Text = "Delete";
            this.sup_delete_button.UseVisualStyleBackColor = true;
            this.sup_delete_button.Click += new System.EventHandler(this.sup_delete_button_Click);
            // 
            // sup_update_button
            // 
            this.sup_update_button.Location = new System.Drawing.Point(529, 165);
            this.sup_update_button.Name = "sup_update_button";
            this.sup_update_button.Size = new System.Drawing.Size(136, 41);
            this.sup_update_button.TabIndex = 13;
            this.sup_update_button.Text = "Update";
            this.sup_update_button.UseVisualStyleBackColor = true;
            this.sup_update_button.Click += new System.EventHandler(this.sup_update_button_Click);
            // 
            // sup_save_button
            // 
            this.sup_save_button.Location = new System.Drawing.Point(529, 97);
            this.sup_save_button.Name = "sup_save_button";
            this.sup_save_button.Size = new System.Drawing.Size(136, 41);
            this.sup_save_button.TabIndex = 12;
            this.sup_save_button.Text = "Save";
            this.sup_save_button.UseVisualStyleBackColor = true;
            this.sup_save_button.Click += new System.EventHandler(this.sup_save_button_Click);
            // 
            // sup_new_button
            // 
            this.sup_new_button.Location = new System.Drawing.Point(529, 41);
            this.sup_new_button.Name = "sup_new_button";
            this.sup_new_button.Size = new System.Drawing.Size(136, 41);
            this.sup_new_button.TabIndex = 11;
            this.sup_new_button.Text = "New";
            this.sup_new_button.UseVisualStyleBackColor = true;
            this.sup_new_button.Click += new System.EventHandler(this.sup_new_button_Click);
            // 
            // kebele_comboBox
            // 
            this.kebele_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kebele_comboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kebele_comboBox.FormattingEnabled = true;
            this.kebele_comboBox.Items.AddRange(new object[] {
            "Hogane"});
            this.kebele_comboBox.Location = new System.Drawing.Point(144, 258);
            this.kebele_comboBox.Name = "kebele_comboBox";
            this.kebele_comboBox.Size = new System.Drawing.Size(194, 33);
            this.kebele_comboBox.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(12, 382);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(788, 254);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
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
            // sup_search_textBox
            // 
            this.sup_search_textBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sup_search_textBox.Location = new System.Drawing.Point(527, 332);
            this.sup_search_textBox.Name = "sup_search_textBox";
            this.sup_search_textBox.Size = new System.Drawing.Size(273, 31);
            this.sup_search_textBox.TabIndex = 12;
            this.sup_search_textBox.TextChanged += new System.EventHandler(this.sup_search_textBox_TextChanged);
            // 
            // Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 661);
            this.Controls.Add(this.sup_search_textBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Supplier";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firstName_textBox;
        private System.Windows.Forms.TextBox lastName_textBox;
        private System.Windows.Forms.TextBox tel_textBox;
        private System.Windows.Forms.ComboBox city_comboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox kebele_comboBox;
        private System.Windows.Forms.Button sup_delete_button;
        private System.Windows.Forms.Button sup_update_button;
        private System.Windows.Forms.Button sup_save_button;
        private System.Windows.Forms.Button sup_new_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox sup_search_textBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}