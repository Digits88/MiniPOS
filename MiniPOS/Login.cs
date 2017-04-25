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

        private void LoginClear()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //also check the roles
            Connection conn = new Connection();
            SqlDataAdapter sda = new SqlDataAdapter("select * from profile where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'", conn.ActiveConn());
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
                LoginClear();
            }
        }
    }
}
