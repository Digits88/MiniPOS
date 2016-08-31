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
    public partial class Customer : Form
    {
        Connection con = new Connection();
        DateTime date = System.DateTime.Today;
        public Customer()
        {
            InitializeComponent();
        }

        private void Clear_Customer()
        {
            custFname_textBox.Clear();
            custLname_textBox.Clear();
            custKebele_comboBox.SelectedIndex = -1;
            custCity_comboBox.SelectedIndex = -1;
            custContract_comboBox.SelectedIndex = -1;
            custTel_textBox.Clear();
            custType_textBox.Text = "Contract";
            //custEnd_dateTimePicker.Value = now();
            custFname_textBox.Focus();
        }

        private void Display_Customer()
        {

            SqlDataAdapter sda = new SqlDataAdapter("select * from customer", con.ActiveConn());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cust_dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = cust_dataGridView1.Rows.Add();
                cust_dataGridView1.Rows[n].Cells[0].Value = item["firstname"].ToString();
                cust_dataGridView1.Rows[n].Cells[1].Value = item["lastname"].ToString();
                cust_dataGridView1.Rows[n].Cells[2].Value = item["telephone"].ToString();
                cust_dataGridView1.Rows[n].Cells[3].Value = item["city"].ToString();
                cust_dataGridView1.Rows[n].Cells[4].Value = item["kebele"].ToString();
                cust_dataGridView1.Rows[n].Cells[5].Value = item["contract_type"].ToString();
                cust_dataGridView1.Rows[n].Cells[6].Value = item["start_date"].ToString();
                cust_dataGridView1.Rows[n].Cells[7].Value = item["end_date"].ToString();
            }
        }

        private void cust_new_button_Click(object sender, EventArgs e)
        {
            Clear_Customer();
        }

        private void cust_save_button_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand(@"Insert into customer (firstname,lastname,city,kebele,telephone,cust_type,start_date,end_date,contract_type) 
            values ('" + custFname_textBox.Text + "','" + custLname_textBox.Text + "','" + custCity_comboBox.Text + "','" + custKebele_comboBox.Text + "','" + custTel_textBox.Text + "','" + custType_textBox.Text + "','" + date + "','" + custEnd_dateTimePicker.Value + "','" + custContract_comboBox.Text + "')", con.ActiveConn());

            cmd.ExecuteNonQuery();
            MessageBox.Show("The Customer Information is saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear_Customer();
            Display_Customer();
        }

        private void cust_update_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update customer set firstname = '" + custFname_textBox.Text + "', lastname = '" + custLname_textBox.Text + "', city = '" + custCity_comboBox.Text + "', kebele = '" + custKebele_comboBox.Text + "', telephone = '" + custTel_textBox.Text + "', start_date = '" + date + "', end_date = '" + custEnd_dateTimePicker.Value + "', contract_type = '" + custContract_comboBox.Text + "' where firstname = '" + custFname_textBox.Text + "' ", con.ActiveConn());
            //sup_fname = '" + firstName_textBox.Text + "',
            //cust_type = '" + custType_textBox.Text + "'
            cmd.ExecuteNonQuery();
            MessageBox.Show("The Customer Information is updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear_Customer();
            Display_Customer();
        }

        private void cust_delete_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(@"delete from customer where firstname = '" + custFname_textBox.Text + "' ", con.ActiveConn());
            DialogResult msg = MessageBox.Show("Are you sure you want to delete this information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == System.Windows.Forms.DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("The Customer Information is deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Customer();
                Display_Customer();
            }
            else
            {
                MessageBox.Show("Customer information is not deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Customer();
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            Display_Customer();
        }

        private void cust_search_textBox_TextChanged(object sender, EventArgs e)
        {
            //no need to open and close connection when using sqldata adapter
            SqlDataAdapter sda = new SqlDataAdapter("select * from customer where (firstname like '%" + cust_search_textBox.Text + "%' or lastname like '%" + cust_search_textBox.Text + "%' or telephone like '%" + cust_search_textBox.Text + "%' or city like '%" + cust_search_textBox.Text + "%' or kebele like '%" + cust_search_textBox.Text + "%')", con.ActiveConn());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cust_dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = cust_dataGridView1.Rows.Add();
                cust_dataGridView1.Rows[n].Cells[0].Value = item["firstname"].ToString();
                cust_dataGridView1.Rows[n].Cells[1].Value = item["lastname"].ToString();
                cust_dataGridView1.Rows[n].Cells[2].Value = item["telephone"].ToString();
                cust_dataGridView1.Rows[n].Cells[3].Value = item["city"].ToString();
                cust_dataGridView1.Rows[n].Cells[4].Value = item["kebele"].ToString();
                cust_dataGridView1.Rows[n].Cells[5].Value = item["contract_type"].ToString();
                cust_dataGridView1.Rows[n].Cells[6].Value = item["start_date"].ToString();
                cust_dataGridView1.Rows[n].Cells[7].Value = item["end_date"].ToString();
            }
        }

        private void cust_dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            custFname_textBox.Text = cust_dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            custLname_textBox.Text = cust_dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            custTel_textBox.Text = cust_dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            custCity_comboBox.Text = cust_dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            custKebele_comboBox.Text = cust_dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            custContract_comboBox.Text = cust_dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            custEnd_dateTimePicker.Text = cust_dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }
    }
}
