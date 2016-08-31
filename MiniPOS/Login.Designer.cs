namespace MiniPOS
{
    partial class Login
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
            this.username_textBox = new System.Windows.Forms.TextBox();
            this.password_textBox = new System.Windows.Forms.TextBox();
            this.Btn_ok = new System.Windows.Forms.Button();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.forgetPass_linkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(46, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // username_textBox
            // 
            this.username_textBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.username_textBox.Location = new System.Drawing.Point(138, 52);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.Size = new System.Drawing.Size(326, 31);
            this.username_textBox.TabIndex = 3;
            // 
            // password_textBox
            // 
            this.password_textBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.password_textBox.Location = new System.Drawing.Point(138, 100);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '.';
            this.password_textBox.Size = new System.Drawing.Size(326, 31);
            this.password_textBox.TabIndex = 4;
            // 
            // Btn_ok
            // 
            this.Btn_ok.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_ok.Location = new System.Drawing.Point(325, 161);
            this.Btn_ok.Name = "Btn_ok";
            this.Btn_ok.Size = new System.Drawing.Size(139, 44);
            this.Btn_ok.TabIndex = 6;
            this.Btn_ok.Text = "Ok";
            this.Btn_ok.UseVisualStyleBackColor = true;
            this.Btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
            // 
            // Btn_exit
            // 
            this.Btn_exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_exit.Location = new System.Drawing.Point(138, 161);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(139, 44);
            this.Btn_exit.TabIndex = 7;
            this.Btn_exit.Text = "Exit";
            this.Btn_exit.UseVisualStyleBackColor = true;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // forgetPass_linkLabel
            // 
            this.forgetPass_linkLabel.AutoSize = true;
            this.forgetPass_linkLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.forgetPass_linkLabel.Location = new System.Drawing.Point(306, 233);
            this.forgetPass_linkLabel.Name = "forgetPass_linkLabel";
            this.forgetPass_linkLabel.Size = new System.Drawing.Size(152, 25);
            this.forgetPass_linkLabel.TabIndex = 8;
            this.forgetPass_linkLabel.TabStop = true;
            this.forgetPass_linkLabel.Text = "Forget Password?";
            // 
            // Login
            // 
            this.AcceptButton = this.Btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 290);
            this.Controls.Add(this.forgetPass_linkLabel);
            this.Controls.Add(this.Btn_exit);
            this.Controls.Add(this.Btn_ok);
            this.Controls.Add(this.password_textBox);
            this.Controls.Add(this.username_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox username_textBox;
        private System.Windows.Forms.TextBox password_textBox;
        private System.Windows.Forms.Button Btn_ok;
        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.LinkLabel forgetPass_linkLabel;
    }
}