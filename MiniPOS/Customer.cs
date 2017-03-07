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
        Connection connection = new Connection();
        DateTime date = System.DateTime.Today;
        public Customer()
        {
            InitializeComponent();
        }

        private void ClearCustomer()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtTelephone.Clear();
            cboKebele.SelectedIndex = 0;
            cboCity.SelectedIndex = 0;
            cboContract.SelectedIndex = 0;
            txtCustomerType.Text = "Contract";
            txtFirstName.Focus();
        }

        private void DisplayCustomer()
        {
            ClearCustomer();
            var dataAdapter = new SqlDataAdapter("select * from customer", connection.ActiveConn());
            var dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgvCustomerInfo.Rows.Clear();
            foreach (DataRow item in dataTable.Rows)
            {
                int n = dgvCustomerInfo.Rows.Add();
                dgvCustomerInfo.Rows[n].Cells[0].Value = item["firstname"].ToString();
                dgvCustomerInfo.Rows[n].Cells[1].Value = item["lastname"].ToString();
                dgvCustomerInfo.Rows[n].Cells[2].Value = item["telephone"].ToString();
                dgvCustomerInfo.Rows[n].Cells[3].Value = item["city"].ToString();
                dgvCustomerInfo.Rows[n].Cells[4].Value = item["kebele"].ToString();
                dgvCustomerInfo.Rows[n].Cells[5].Value = item["contract_type"].ToString();
                dgvCustomerInfo.Rows[n].Cells[6].Value = item["start_date"].ToString();
                dgvCustomerInfo.Rows[n].Cells[7].Value = item["end_date"].ToString();
            }
        }

        private void btnClearCustomerInfo_Click(object sender, EventArgs e)
        {
            ClearCustomer();
        }

        private void btnSaveNewCustomer_Click(object sender, EventArgs e)
        {
            
            var command = new SqlCommand(@"Insert into customer (firstname,lastname,city,kebele,telephone,cust_type,start_date,end_date,contract_type) 
            values ('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + cboCity.Text + "','" + cboKebele.Text + "','" + txtTelephone.Text + "','" + txtCustomerType.Text + "','" + date + "','" + custEnd_dateTimePicker.Value + "','" + cboContract.Text + "')", connection.ActiveConn());

            command.ExecuteNonQuery();
            MessageBox.Show("The Customer Information is saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearCustomer();
            DisplayCustomer();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            var command = new SqlCommand("update customer set firstname = '" + txtFirstName.Text + "', lastname = '" + txtLastName.Text + "', city = '" + cboCity.Text + "', kebele = '" + cboKebele.Text + "', telephone = '" + txtTelephone.Text + "', start_date = '" + date + "', end_date = '" + custEnd_dateTimePicker.Value + "', contract_type = '" + cboContract.Text + "' where firstname = '" + txtFirstName.Text + "' ", connection.ActiveConn());
            command.ExecuteNonQuery();
            MessageBox.Show("The Customer Information is updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearCustomer();
            DisplayCustomer();
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            var command = new SqlCommand(@"delete from customer where firstname = '" + txtFirstName.Text + "' ", connection.ActiveConn());
            DialogResult msg = MessageBox.Show("Are you sure you want to delete this information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == System.Windows.Forms.DialogResult.Yes)
            {
                command.ExecuteNonQuery();
                MessageBox.Show("The Customer Information is deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearCustomer();
                DisplayCustomer();
            }
            else
            {
                MessageBox.Show("Customer information is not deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearCustomer();
            }
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            DisplayCustomer();
        }

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            //no need to open and close connection when using sql data adapter
            var dataAdapter = new SqlDataAdapter("select * from customer where (firstname like '%" + txtSearchCustomer.Text + "%' or lastname like '%" + txtSearchCustomer.Text + "%' or telephone like '%" + txtSearchCustomer.Text + "%' or city like '%" + txtSearchCustomer.Text + "%' or kebele like '%" + txtSearchCustomer.Text + "%')", connection.ActiveConn());
            var dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dgvCustomerInfo.Rows.Clear();
            foreach (DataRow item in dataTable.Rows)
            {
                int n = dgvCustomerInfo.Rows.Add();
                dgvCustomerInfo.Rows[n].Cells[0].Value = item["firstname"].ToString();
                dgvCustomerInfo.Rows[n].Cells[1].Value = item["lastname"].ToString();
                dgvCustomerInfo.Rows[n].Cells[2].Value = item["telephone"].ToString();
                dgvCustomerInfo.Rows[n].Cells[3].Value = item["city"].ToString();
                dgvCustomerInfo.Rows[n].Cells[4].Value = item["kebele"].ToString();
                dgvCustomerInfo.Rows[n].Cells[5].Value = item["contract_type"].ToString();
                dgvCustomerInfo.Rows[n].Cells[6].Value = item["start_date"].ToString();
                dgvCustomerInfo.Rows[n].Cells[7].Value = item["end_date"].ToString();
            }
        }

        private void dgvCustomerInfo_MouseClick(object sender, MouseEventArgs e)
        {
            txtFirstName.Text = dgvCustomerInfo.SelectedRows[0].Cells[0].Value.ToString();
            txtLastName.Text = dgvCustomerInfo.SelectedRows[0].Cells[1].Value.ToString();
            txtTelephone.Text = dgvCustomerInfo.SelectedRows[0].Cells[2].Value.ToString();
            cboCity.Text = dgvCustomerInfo.SelectedRows[0].Cells[3].Value.ToString();
            cboKebele.Text = dgvCustomerInfo.SelectedRows[0].Cells[4].Value.ToString();
            cboContract.Text = dgvCustomerInfo.SelectedRows[0].Cells[5].Value.ToString();
            custEnd_dateTimePicker.Text = dgvCustomerInfo.SelectedRows[0].Cells[7].Value.ToString();
        }
    }
}
