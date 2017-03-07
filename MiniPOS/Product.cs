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

        private void Clear_Product()
        {
            itemProdName_textBox.Clear();
            ItemProdType_comboBox.SelectedIndex = 0;
            itemProdName_textBox.Focus();
        }

        private void Clear_Inventory()
        {
            decimal unit_price = 0.00M;
            inv_Product_comboBox.SelectedIndex = -1;
            inv_Qty_numericUpDown.Value = 0;
            inv_UPrice_textBox.Text = unit_price.ToString();
        }

        private void Retrieve_Product()
        {
            SqlCommand cmd = new SqlCommand("select product_type from product", con.ActiveConn());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                inv_Product_comboBox.Items.Add(reader["product_type"].ToString());
            }
            reader.Close();
        }

        private string Retrieve_ProdId()
        {
            string tmp = "";
            SqlCommand cmd = new SqlCommand("select product_Id from product where product_type = '" + inv_Product_comboBox.Text + "' ", con.ActiveConn());
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                tmp = rdr["product_Id"].ToString();
            }
            rdr.Close();
            return tmp;
        }

        private void Display_Inventory()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from prod_inventory I, product P where I.pr_id=P.product_Id and I.prod_type=P.product_type", con.ActiveConn());
            DataTable dt = new DataTable();
            da.Fill(dt);
            inv_dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = inv_dataGridView1.Rows.Add();
                inv_dataGridView1.Rows[n].Cells[0].Value = item["product_name"].ToString();
                inv_dataGridView1.Rows[n].Cells[1].Value = item["prod_type"].ToString();
                inv_dataGridView1.Rows[n].Cells[2].Value = item["expiry_date"].ToString();
                inv_dataGridView1.Rows[n].Cells[3].Value = item["qty"].ToString();
                inv_dataGridView1.Rows[n].Cells[4].Value = item["unit_price"].ToString();
            }
        }

        private void item_new_button_Click(object sender, EventArgs e)
        {
            Clear_Product();
        }

        private void item_save_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(@"Insert into product (product_name,product_type) values ('" + itemProdName_textBox.Text + "','" + ItemProdType_comboBox.Text + "')", con.ActiveConn());

            cmd.ExecuteNonQuery();
            MessageBox.Show("The Product Information is saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear_Product();
        }

        private void Product_Load(object sender, EventArgs e)
        {
            Clear_Product();
            Clear_Inventory();
            Retrieve_Product();
            Display_Inventory();
        }

        private void inv_new_button_Click(object sender, EventArgs e)
        {
            Clear_Inventory();
        }

        private void inv_save_button_Click(object sender, EventArgs e)
        {
            string prod_id = Retrieve_ProdId();
            SqlCommand cmd1 = new SqlCommand(@"Insert into prod_inventory (pr_id,prod_type,expiry_date,qty,unit_price) 
                        values ('" + prod_id + "','" + inv_Product_comboBox.Text + "','" + inv_dateTimePicker.Value + "','" + inv_Qty_numericUpDown.Value + "','" + inv_UPrice_textBox.Text + "')", con.ActiveConn());
            cmd1.ExecuteNonQuery();
            MessageBox.Show("The Product-Inventory Information is saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Retrieve_Product();
            Clear_Inventory();
            Display_Inventory();
        }

        private void inv_search_textBox_TextChanged(object sender, EventArgs e)
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

        private void inv_delete_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from prod_inventory where prod_type = '" + inv_Product_comboBox.Text + "' ", con.ActiveConn());
            DialogResult msg = MessageBox.Show("Are you sure you want to delete this information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == System.Windows.Forms.DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("The Product-Inventory Information is deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Inventory();
                Display_Inventory();
            }
            else
            {
                MessageBox.Show("Product-Inventory information is not deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Inventory();
            }
        }

        private void inv_update_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update prod_inventory set expiry_date = '" + inv_dateTimePicker.Value + "', qty = '" + inv_Qty_numericUpDown.Value + "', unit_price = '" + inv_UPrice_textBox.Text + "' where prod_type = '" + inv_Product_comboBox.Text + "' ", con.ActiveConn());
            //prod_type = '" + inv_Product_comboBox.Text + "',
            cmd.ExecuteNonQuery();
            MessageBox.Show("The Product-Inventory Information is updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear_Inventory();
            Display_Inventory();
        }

        private void inv_dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            inv_Product_comboBox.Text = inv_dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            inv_dateTimePicker.Text = inv_dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            inv_Qty_numericUpDown.Value = Convert.ToDecimal(inv_dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
            inv_UPrice_textBox.Text = inv_dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
