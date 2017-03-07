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
    public partial class Sale : Form
    {
        Connection con = new Connection();
        public Sale()
        {
            InitializeComponent();
        }

        private void Clear_Sale()
        {
            decimal tot_price = 0.00M;
            sale_product_comboBox.SelectedIndex = -1;
            sale_type_comboBox.SelectedIndex = -1;
            sale_qty_numericUpDown.Value = 0;
            sale_price_textBox.Text = tot_price.ToString();
            sale_totPrice_Label.Text = tot_price.ToString();
            label13.Text = "";
            sale_TotalPrice_Label.Text = "0.00";
        }

        private void Retrieve_ProductType()
        {
            SqlCommand cmd = new SqlCommand("select prod_type from prod_inventory", con.ActiveConn());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                sale_product_comboBox.Items.Add(reader["prod_type"].ToString());
            }
            reader.Close();
        }

        private string Retrieve_InvProdId()
        {
            string temp = "";
            SqlCommand cmd = new SqlCommand("select inv_Id from prod_inventory where prod_type = '" + sale_product_comboBox.Text + "' ", con.ActiveConn());
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                temp = rdr["inv_Id"].ToString();
            }
            rdr.Close();
            return temp;
        }

        private void Display_Sale()
        {
            Clear_Sale();
            //string tmp = Retrieve_InvProdId();
            SqlDataAdapter da = new SqlDataAdapter("select * from prod_inventory P, sale S where P.inv_Id = S.invSale_Id", con.ActiveConn());
            DataTable dt = new DataTable();
            da.Fill(dt);
            sale_dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = sale_dataGridView1.Rows.Add();
                sale_dataGridView1.Rows[n].Cells[0].Value = item["sales_Id"].ToString();
                //sale_dataGridView1.Rows[n].Cells[0].Value = tmp;
                sale_dataGridView1.Rows[n].Cells[1].Value = item["prod_type"].ToString();
                sale_dataGridView1.Rows[n].Cells[2].Value = item["expiry_date"].ToString();
                sale_dataGridView1.Rows[n].Cells[3].Value = item["sales_type"].ToString();
                sale_dataGridView1.Rows[n].Cells[4].Value = item["quantity"].ToString();
                sale_dataGridView1.Rows[n].Cells[5].Value = item["price_unit"].ToString();
                sale_dataGridView1.Rows[n].Cells[6].Value = item["total_price"].ToString();
            }
        }

        private decimal CalculateTotalPrice(decimal quantity, decimal unit_price)
        {
            decimal total = 0;
            quantity = sale_qty_numericUpDown.Value;
            unit_price = Convert.ToDecimal(sale_price_textBox.Text);
            total = quantity * unit_price;
            sale_totPrice_Label.Text = total.ToString();
            return total;
        }

        private void ChangeValue()
        {
            if (sale_price_textBox.Text == "")
            {
                MessageBox.Show("This field can not be empty, please enter a valid number", "POS Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sale_price_textBox.Focus();
            }
            else
            {
                decimal price_given = Convert.ToDecimal(sale_price_textBox.Text);
                decimal qty = sale_qty_numericUpDown.Value;
                decimal total = CalculateTotalPrice(qty, price_given);
            }
        }

        private void AddToGrid()
        {
            string tmp = Retrieve_InvProdId();
            string theDate = sale__dateTimePicker.Value.ToShortDateString();
            //sale_dataGridView1.Rows[0].Cells[0].Value = tmp;
            sale_dataGridView1.Rows.Add(tmp, sale_product_comboBox.Text, theDate, sale_type_comboBox.Text, sale_qty_numericUpDown.Value, sale_price_textBox.Text, sale_totPrice_Label.Text);
        }

        private void RemoveFromGrid()
        {
            int selectedIndex = sale_dataGridView1.CurrentCell.RowIndex;
            if (selectedIndex > -1)
            {
                sale_dataGridView1.Rows.RemoveAt(selectedIndex);
                sale_dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Unable to remove the data from the gridview", "POS Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CalculateSumTotal()
        {
            decimal sumTotal = 0.00M;
            decimal total = 0.00M;
            foreach (DataGridViewRow dgv in sale_dataGridView1.Rows)
            {
                total = Convert.ToDecimal(dgv.Cells[6].Value.ToString());
                sumTotal += total;
            }
            sale_TotalPrice_Label.Text = sumTotal.ToString();
            //MessageBox.Show("sum" +sumTotal);
        }

        private int CalculateDifference()
        {
            int diff = 0;
            int temp = 0;
            string inv_id = Retrieve_InvProdId();
            SqlCommand cmd = new SqlCommand("select qty from prod_inventory where inv_Id = '" + inv_id + "' ", con.ActiveConn());
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                temp = Convert.ToInt32(rdr["qty"].ToString());
            }
            diff = Convert.ToInt32(temp - sale_qty_numericUpDown.Value);
            rdr.Close();
            return diff;
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            /*DataGridViewCheckBoxColumn dg_chk = new DataGridViewCheckBoxColumn();
            sale_dataGridView1.Columns.Add(dg_chk);
            dg_chk.HeaderText = "Filter";
            dg_chk.Name = "chkBox";*/
            Clear_Sale();
            Retrieve_ProductType();
            //Display_Sale();
            CalculateSumTotal();
        }

        private void sale_new_button_Click(object sender, EventArgs e)
        {
            Clear_Sale();
        }

        private void sale_qty_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ChangeValue();
        }

        private void sale_price_textBox_TextChanged(object sender, EventArgs e)
        {
            ChangeValue();
        }

        private void sale_addToList_button_Click(object sender, EventArgs e)
        {
            AddToGrid();
            CalculateSumTotal();
        }

        private void sale_remove_button_Click(object sender, EventArgs e)
        {
            RemoveFromGrid();
            CalculateSumTotal();
        }

        private void sale_purchase_button_Click(object sender, EventArgs e)
        {
            string inv_id = Retrieve_InvProdId();
            int difference = CalculateDifference();
            string theDate = sale__dateTimePicker.Value.ToShortDateString();
            SqlCommand cmd1 = new SqlCommand(@"Insert into sale (invSale_Id,sales_date,quantity,price_unit,total_price,sales_type) 
                        values ('" + inv_id + "','" + theDate + "','" + sale_qty_numericUpDown.Value + "','" + sale_price_textBox.Text + "','" + sale_totPrice_Label.Text + "','" + sale_type_comboBox.Text + "')", con.ActiveConn());
            cmd1.ExecuteNonQuery();
            MessageBox.Show("The Sales Information is saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear_Sale();
            sale_dataGridView1.Rows.Clear();

            //update information
            SqlCommand cmd2 = new SqlCommand("update prod_inventory set qty = '" + difference + "' where inv_Id = '" + inv_id + "' ", con.ActiveConn());
            cmd2.ExecuteNonQuery();
        }

        private void sale_product_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string unit_price = "";
            SqlCommand cmd3 = new SqlCommand("select unit_price from prod_inventory where prod_type = '" + sale_product_comboBox.Text + "' ", con.ActiveConn());
            SqlDataReader rdr = cmd3.ExecuteReader();
            if (rdr.Read())
            {
                unit_price = rdr["unit_price"].ToString();
            }
            sale_price_textBox.Text = unit_price;
            rdr.Close();
        }
    }
}
