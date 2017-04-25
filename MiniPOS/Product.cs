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
    public partial class Product : Form
    {
        Connection con = new Connection();

        public Product()
        {
            InitializeComponent();
        }

        private void ClearProduct()
        {
            txtItemProdName.Clear();
            cboItemProdType.SelectedIndex = 0;
            txtItemProdName.Focus();
        }

        private void ClearInventory()
        {
            decimal unit_price = 0.00M;
            cboInvProduct.SelectedIndex = -1;
            numericInvQty.Value = 0;
            txtInvUnitPrice.Text = unit_price.ToString();
        }

        private void RetrieveProduct()
        {
            SqlCommand cmd = new SqlCommand("select product_type from product", con.ActiveConn());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cboInvProduct.Items.Add(reader["product_type"].ToString());
            }
            reader.Close();
        }

        private string RetrieveProdId()
        {
            string tmp = "";
            SqlCommand cmd = new SqlCommand("select product_Id from product where product_type = '" + cboInvProduct.Text + "' ", con.ActiveConn());
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                tmp = rdr["product_Id"].ToString();
            }
            rdr.Close();
            return tmp;
        }

        private void DisplayInventory()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from prod_inventory I, product P where I.pr_id=P.product_Id and I.prod_type=P.product_type", con.ActiveConn());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvInventory.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dgvInventory.Rows.Add();
                dgvInventory.Rows[n].Cells[0].Value = item["product_name"].ToString();
                dgvInventory.Rows[n].Cells[1].Value = item["prod_type"].ToString();
                dgvInventory.Rows[n].Cells[2].Value = item["expiry_date"].ToString();
                dgvInventory.Rows[n].Cells[3].Value = item["qty"].ToString();
                dgvInventory.Rows[n].Cells[4].Value = item["unit_price"].ToString();
            }
        }

        private void item_new_button_Click(object sender, EventArgs e)
        {
            ClearProduct();
        }

        private void item_save_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(@"Insert into product (product_name,product_type) values ('" + txtItemProdName.Text + "','" + cboItemProdType.Text + "')", con.ActiveConn());

            cmd.ExecuteNonQuery();
            MessageBox.Show("The Product Information is saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearProduct();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            ClearProduct();
            ClearInventory();
            RetrieveProduct();
            DisplayInventory();
        }

        private void btnInvClearNew_Click(object sender, EventArgs e)
        {
            ClearInventory();
        }

        private void btnInvSave_Click(object sender, EventArgs e)
        {
            string prod_id = RetrieveProdId();
            SqlCommand cmd1 = new SqlCommand(@"Insert into prod_inventory (pr_id,prod_type,expiry_date,qty,unit_price) 
                        values ('" + prod_id + "','" + cboInvProduct.Text + "','" + dateTimePickerInvExpiry.Value + "','" + numericInvQty.Value + "','" + txtInvUnitPrice.Text + "')", con.ActiveConn());
            cmd1.ExecuteNonQuery();
            MessageBox.Show("The Product-Inventory Information is saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Retrieve_Product();
            ClearInventory();
            DisplayInventory();
        }

        private void txtInvSearch_TextChanged(object sender, EventArgs e)
        {
            //SqlDataAdapter sda = new SqlDataAdapter("select * from prod_inventory I, product P where I.pr_id=P.product_Id and I.prod_type=P.product_type or product_name like '%" + inv_search_textBox.Text + "%' or prod_type like '%" + inv_search_textBox.Text + "%' ", con.ActiveConn());
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //inv_dataGridView1.Rows.Clear();
            //foreach (DataRow item in dt.Rows)
            //{
            //    int n = inv_dataGridView1.Rows.Add();
            //    inv_dataGridView1.Rows[n].Cells[0].Value = item["product_name"].ToString();
            //    inv_dataGridView1.Rows[n].Cells[1].Value = item["prod_type"].ToString();
            //    inv_dataGridView1.Rows[n].Cells[2].Value = item["expiry_date"].ToString();
            //    inv_dataGridView1.Rows[n].Cells[3].Value = item["qty"].ToString();
            //    inv_dataGridView1.Rows[n].Cells[4].Value = item["unit_price"].ToString();
            //}
        }

        private void btnInvDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from prod_inventory where prod_type = '" + cboInvProduct.Text + "' ", con.ActiveConn());
            DialogResult msg = MessageBox.Show("Are you sure you want to delete this information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == System.Windows.Forms.DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("The Product-Inventory Information is deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInventory();
                DisplayInventory();
            }
            else
            {
                MessageBox.Show("Product-Inventory information is not deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInventory();
            }
        }

        private void btnInvUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update prod_inventory set expiry_date = '" + dateTimePickerInvExpiry.Value + "', qty = '" + numericInvQty.Value + "', unit_price = '" + txtInvUnitPrice.Text + "' where prod_type = '" + cboInvProduct.Text + "' ", con.ActiveConn());
            //prod_type = '" + inv_Product_comboBox.Text + "',
            cmd.ExecuteNonQuery();
            MessageBox.Show("The Product-Inventory Information is updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearInventory();
            DisplayInventory();
        }

        private void dgvInventory_MouseClick(object sender, MouseEventArgs e)
        {
            cboInvProduct.Text = dgvInventory.SelectedRows[0].Cells[1].Value.ToString();
            dateTimePickerInvExpiry.Text = dgvInventory.SelectedRows[0].Cells[2].Value.ToString();
            numericInvQty.Value = Convert.ToDecimal(dgvInventory.SelectedRows[0].Cells[3].Value.ToString());
            txtInvUnitPrice.Text = dgvInventory.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
