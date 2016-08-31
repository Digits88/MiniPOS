using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MiniPOS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            username_textBox.Clear();
            password_textBox.Clear();
            username_textBox.Focus();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ok_Click(object sender, EventArgs e)
        {
            Connection conn = new Connection();
            SqlDataAdapter sda = new SqlDataAdapter("select * from profile where username='" + username_textBox.Text + "' and password='" + password_textBox.Text + "'", conn.ActiveConn());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                POS pos = new POS();
                pos.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Clear();
            }
        }
    }
}
