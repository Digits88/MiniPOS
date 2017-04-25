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

        private void ClearSupplier()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtTele.Clear();
            cboCity.SelectedIndex = 0; 
            cboKebele.SelectedIndex = 0;
            txtFirstName.Focus();
        }

        private void DisplaySupplier()
        {
            ClearSupplier();
            SqlDataAdapter sda = new SqlDataAdapter("select * from supplier", conn.ActiveConn());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvSupplierInfo.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dgvSupplierInfo.Rows.Add();
                dgvSupplierInfo.Rows[n].Cells[0].Value = item["sup_fname"].ToString();
                dgvSupplierInfo.Rows[n].Cells[1].Value = item["sup_lname"].ToString();
                dgvSupplierInfo.Rows[n].Cells[2].Value = item["sup_telephone"].ToString();
                dgvSupplierInfo.Rows[n].Cells[3].Value = item["sup_city"].ToString();
                dgvSupplierInfo.Rows[n].Cells[4].Value = item["sup_kebele"].ToString();
            }
        }

        private void btnSaveNewSupplier_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand(@"Insert into supplier (sup_fname,sup_lname,sup_city,sup_telephone,sup_kebele) 
            values ('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + cboCity.Text + "','" + txtTele.Text + "','" + cboKebele.Text + "')", conn.ActiveConn());

            cmd.ExecuteNonQuery();
            MessageBox.Show("The Supplier Information is saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearSupplier();
            DisplaySupplier();
        }

        private void btnClearSupplierInfo_Click(object sender, EventArgs e)
        {
            ClearSupplier();
        }

        private void btnUpdateSupplier_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand(@"update supplier set sup_lname = '" + txtLastName.Text + "',  sup_city = '" + cboCity.Text + "', sup_telephone = '" + txtTele.Text + "', sup_kebele = ' " + cboKebele.Text + "' where (sup_fname = '" + txtFirstName.Text + "')", conn.ActiveConn());
            //sup_fname = '" + firstName_textBox.Text + "',
            cmd.ExecuteNonQuery();
            MessageBox.Show("The Supplier Information is updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearSupplier();
            DisplaySupplier();
        }

        private void btnDeleteSupplier_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand(@"delete from supplier where sup_fname = '" + txtFirstName.Text + "' ", conn.ActiveConn());
            DialogResult msg = MessageBox.Show("Are you sure you want to delete this information","Information",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (msg == System.Windows.Forms.DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("The Supplier Information is deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearSupplier();
                DisplaySupplier();
            }
            else
            {
                MessageBox.Show("Supplier information is not deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearSupplier();
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtFirstName.Text = dgvSupplierInfo.SelectedRows[0].Cells[0].Value.ToString();
            txtLastName.Text = dgvSupplierInfo.SelectedRows[0].Cells[1].Value.ToString();
            txtTele.Text = dgvSupplierInfo.SelectedRows[0].Cells[2].Value.ToString();
            cboCity.Text = dgvSupplierInfo.SelectedRows[0].Cells[3].Value.ToString();
            cboKebele.Text = dgvSupplierInfo.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void txtSearchSupplier_TextChanged(object sender, EventArgs e)
        {
            //no need to open and close connection when using sqldata adapter
            SqlDataAdapter sda = new SqlDataAdapter("select * from supplier where (sup_fname like '%" + txtSearchSupplier.Text + "%' or sup_lname like '%" + txtSearchSupplier.Text + "%' or sup_telephone like '%" + txtSearchSupplier.Text + "%' or sup_city like '%" + txtSearchSupplier.Text + "%' or sup_kebele like '%" + txtSearchSupplier.Text + "%')", conn.ActiveConn());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgvSupplierInfo.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dgvSupplierInfo.Rows.Add();
                dgvSupplierInfo.Rows[n].Cells[0].Value = item["sup_fname"].ToString();
                dgvSupplierInfo.Rows[n].Cells[1].Value = item["sup_lname"].ToString();
                dgvSupplierInfo.Rows[n].Cells[2].Value = item["sup_telephone"].ToString();
                dgvSupplierInfo.Rows[n].Cells[3].Value = item["sup_city"].ToString();
                dgvSupplierInfo.Rows[n].Cells[4].Value = item["sup_kebele"].ToString();
            }
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            DisplaySupplier();
        }


    }
}
