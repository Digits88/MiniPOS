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
    public partial class Supplier : Form
    {
        Connection conn = new Connection();
        public Supplier()
        {
            InitializeComponent();
        }

        private void Clear_Supplier()
        {
            firstName_textBox.Clear();
            lastName_textBox.Clear();
            tel_textBox.Clear();
            city_comboBox.SelectedIndex = -1; //to clear the combobox
            kebele_comboBox.SelectedIndex = -1;
            firstName_textBox.Focus();
        }

        private void Display_Supplier()
        {

            SqlDataAdapter sda = new SqlDataAdapter("select * from supplier", conn.ActiveConn());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["sup_fname"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["sup_lname"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["sup_telephone"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["sup_city"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["sup_kebele"].ToString();
            }
        }

        private void sup_save_button_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand(@"Insert into supplier (sup_fname,sup_lname,sup_city,sup_telephone,sup_kebele) 
            values ('" + firstName_textBox.Text + "','" + lastName_textBox.Text + "','" + city_comboBox.Text + "','" + tel_textBox.Text + "','" + kebele_comboBox.Text + "')", conn.ActiveConn());

            cmd.ExecuteNonQuery();
            MessageBox.Show("The Supplier Information is saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear_Supplier();
            Display_Supplier();
        }

        private void sup_new_button_Click(object sender, EventArgs e)
        {
            Clear_Supplier();
        }

        private void sup_update_button_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand(@"update supplier set sup_lname = '" + lastName_textBox.Text + "',  sup_city = '" + city_comboBox.Text + "', sup_telephone = '" + tel_textBox.Text + "', sup_kebele = ' " + kebele_comboBox.Text + "' where (sup_fname = '" + firstName_textBox.Text + "')", conn.ActiveConn());
            //sup_fname = '" + firstName_textBox.Text + "',
            cmd.ExecuteNonQuery();
            MessageBox.Show("The Supplier Information is updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear_Supplier();
            Display_Supplier();
        }

        private void sup_delete_button_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand(@"delete from supplier where sup_fname = '" + firstName_textBox.Text + "' ", conn.ActiveConn());
            DialogResult msg = MessageBox.Show("Are you sure you want to delete this information","Information",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (msg == System.Windows.Forms.DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("The Supplier Information is deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Supplier();
                Display_Supplier();
            }
            else
            {
                MessageBox.Show("Supplier information is not deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Supplier();
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            firstName_textBox.Text = dataGridView1.SelectedRows[0].Cells["Column1"].Value.ToString();
            lastName_textBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            tel_textBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            city_comboBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            kebele_comboBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void sup_search_textBox_TextChanged(object sender, EventArgs e)
        {
            //no need to open and close connection when using sqldata adapter
            SqlDataAdapter sda = new SqlDataAdapter("select * from supplier where (sup_fname like '%" + sup_search_textBox.Text + "%' or sup_lname like '%" + sup_search_textBox.Text + "%' or sup_telephone like '%" + sup_search_textBox.Text + "%' or sup_city like '%" + sup_search_textBox.Text + "%' or sup_kebele like '%" + sup_search_textBox.Text + "%')", conn.ActiveConn());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["sup_fname"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["sup_lname"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["sup_telephone"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["sup_city"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["sup_kebele"].ToString();
            }
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            Display_Supplier();
        }


    }
}
