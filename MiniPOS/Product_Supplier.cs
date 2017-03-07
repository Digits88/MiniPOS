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
    public partial class Product_Supplier : Form
    {
        Connection con = new Connection();
        public Product_Supplier()
        {
            InitializeComponent();
        }

        private void Clear_Product_Supplier()
        {
            decimal tot_price = 0.00M;
            prMap_supp_comboBox.SelectedIndex = -1;
            prMap_Qty_numericUpDown.Value = 0;
            prMap_Price_textBox.Text = tot_price.ToString();
            prMap_totPrice_Label.Text = tot_price.ToString();
            prMap_prod_textBox.Text = "Milk";
            label13.Text = "";
        }

        private void Retrieve_Supplier()
        {
            SqlCommand cmd = new SqlCommand("select sup_fname from supplier", con.ActiveConn());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //string.Format("{0} {1}")
                prMap_supp_comboBox.Items.Add(reader["sup_fname"].ToString());
                PrMap_search_supplier.Items.Add(reader["sup_fname"].ToString());
            }
            reader.Close();
        }

        private string Retrieve_SuppId()
        {
            string tmp = "";
            SqlCommand cmd = new SqlCommand("select sup_Id from supplier where sup_fname = '" + prMap_supp_comboBox.Text + "' ", con.ActiveConn());
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                tmp = rdr["sup_Id"].ToString();
            }
            rdr.Close();
            return tmp;
        }

        private void Display_Prod_Supp_Map()
        {
            Clear_Product_Supplier();
            SqlDataAdapter da = new SqlDataAdapter("select * from product_supplier P, supplier S where P.supp_id = S.sup_Id", con.ActiveConn());
            DataTable dt = new DataTable();
            da.Fill(dt);
            prMap_dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = prMap_dataGridView1.Rows.Add();
                prMap_dataGridView1.Rows[n].Cells[0].Value = item["ps_Id"].ToString();
                prMap_dataGridView1.Rows[n].Cells[1].Value = item["sup_fname"].ToString();
                prMap_dataGridView1.Rows[n].Cells[2].Value = item["sup_lname"].ToString();
                prMap_dataGridView1.Rows[n].Cells[3].Value = item["sup_telephone"].ToString();
                prMap_dataGridView1.Rows[n].Cells[4].Value = item["product"].ToString();
                prMap_dataGridView1.Rows[n].Cells[5].Value = item["supplied_date"].ToString();
                prMap_dataGridView1.Rows[n].Cells[6].Value = item["total_amount"].ToString();
                prMap_dataGridView1.Rows[n].Cells[7].Value = item["price_unit"].ToString();
                prMap_dataGridView1.Rows[n].Cells[8].Value = item["total_price"].ToString();
            }
        }

        private void prMap_new_button_Click(object sender, EventArgs e)
        {
            Clear_Product_Supplier();
        }

        private void Product_Supplier_Load(object sender, EventArgs e)
        {
            Clear_Product_Supplier();
            label13.Hide();
            Retrieve_Supplier();
            Display_Prod_Supp_Map();
            CalculateTotalSum();
            /*DataGridViewCheckBoxColumn dg_chk = new DataGridViewCheckBoxColumn();
            prMap_dataGridView1.Columns.Add(dg_chk);
            dg_chk.HeaderText = "Filter";
            dg_chk.Name = "chkBox";*/
        }

        private decimal CalculateDue(decimal quantity,decimal unit_price)
        {
            decimal total = 0;
            quantity = prMap_Qty_numericUpDown.Value;
            unit_price = Convert.ToDecimal(prMap_Price_textBox.Text);
            total = quantity * unit_price;
            prMap_totPrice_Label.Text = total.ToString();
            return total;
        }

        private void prMap_save_button_Click(object sender, EventArgs e)
        {
            string supp_id = Retrieve_SuppId();
            //TODO - calculation of the total amount in another function
            //decimal total = CalculateDue();
            //prMap_totPrice_Label.Text = total.ToString();
            string theDate = prMap_dateTimePicker.Value.ToShortDateString();
            SqlCommand cmd1 = new SqlCommand(@"Insert into product_supplier (supp_id,supplied_date,total_amount,price_unit,total_price,product) 
                        values ('" + supp_id + "','" + theDate + "','" + prMap_Qty_numericUpDown.Value + "','" + prMap_Price_textBox.Text + "','" + prMap_totPrice_Label.Text + "','" + prMap_prod_textBox.Text + "')", con.ActiveConn());
            //prMap_totPrice_Label.Text
            cmd1.ExecuteNonQuery();
            MessageBox.Show("The Product-Supplier Information is saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear_Product_Supplier();
            Display_Prod_Supp_Map();
            CalculateTotalSum();
        }

        private void prMap_update_button_Click(object sender, EventArgs e)
        {
            string suppp_id = Retrieve_SuppId();
            // TODO - calculation of the total amount in another function

            SqlCommand cmd = new SqlCommand("update product_supplier set supplied_date = '" + prMap_dateTimePicker.Value + "', total_amount = '" + prMap_Qty_numericUpDown.Value + "', price_unit = '" + prMap_Price_textBox.Text + "', total_price = '" + prMap_totPrice_Label.Text + "' where supp_id = '" + suppp_id + "' and ps_Id = '"+ label13.Text +"' ", con.ActiveConn());
            cmd.ExecuteNonQuery();
            MessageBox.Show("The Product-Inventory Information is updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear_Product_Supplier();
            Display_Prod_Supp_Map();
            CalculateTotalSum();
        }

        private void prMap_delete_button_Click(object sender, EventArgs e)
        {
            string sp_id = Retrieve_SuppId();
            SqlCommand cmd = new SqlCommand("delete from product_supplier where supp_id = '" + sp_id + "' and ps_Id = '" + label13.Text + "' ", con.ActiveConn());
            DialogResult msg = MessageBox.Show("Are you sure you want to delete this information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == System.Windows.Forms.DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("The Product-Supplier Information is deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Product_Supplier();
                Display_Prod_Supp_Map();
                CalculateTotalSum();
            }
            else
            {
                MessageBox.Show("Product-Supplier information is not deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Product_Supplier();
                //Display_Prod_Supp_Map();
            }
        }

        private void Display_PS_BasedOnName()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from product_supplier P, supplier S where P.supp_id = S.sup_Id and sup_fname = '" + PrMap_search_supplier.Text + "' ", con.ActiveConn());
            DataTable dt = new DataTable();
            da.Fill(dt);
            prMap_dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = prMap_dataGridView1.Rows.Add();
                prMap_dataGridView1.Rows[n].Cells[0].Value = item["ps_Id"].ToString();
                prMap_dataGridView1.Rows[n].Cells[1].Value = item["sup_fname"].ToString();
                prMap_dataGridView1.Rows[n].Cells[2].Value = item["sup_lname"].ToString();
                prMap_dataGridView1.Rows[n].Cells[3].Value = item["sup_telephone"].ToString();
                prMap_dataGridView1.Rows[n].Cells[4].Value = item["product"].ToString();
                prMap_dataGridView1.Rows[n].Cells[5].Value = item["supplied_date"].ToString();
                prMap_dataGridView1.Rows[n].Cells[6].Value = item["total_amount"].ToString();
                prMap_dataGridView1.Rows[n].Cells[7].Value = item["price_unit"].ToString();
                prMap_dataGridView1.Rows[n].Cells[8].Value = item["total_price"].ToString();
            }
            CalculateTotalSum();
        }

        private void Display_PS_BasedOnDate()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from product_supplier P, supplier S where P.supp_id = S.sup_Id and P.supplied_date = '" + Convert.ToDateTime(PrMap_search_dateTimePicker.Text) + "' ", con.ActiveConn());
            DataTable dt = new DataTable();
            da.Fill(dt);
            prMap_dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = prMap_dataGridView1.Rows.Add();
                prMap_dataGridView1.Rows[n].Cells[0].Value = item["ps_Id"].ToString();
                prMap_dataGridView1.Rows[n].Cells[1].Value = item["sup_fname"].ToString();
                prMap_dataGridView1.Rows[n].Cells[2].Value = item["sup_lname"].ToString();
                prMap_dataGridView1.Rows[n].Cells[3].Value = item["sup_telephone"].ToString();
                prMap_dataGridView1.Rows[n].Cells[4].Value = item["product"].ToString();
                prMap_dataGridView1.Rows[n].Cells[5].Value = item["supplied_date"].ToString();
                prMap_dataGridView1.Rows[n].Cells[6].Value = item["total_amount"].ToString();
                prMap_dataGridView1.Rows[n].Cells[7].Value = item["price_unit"].ToString();
                prMap_dataGridView1.Rows[n].Cells[8].Value = item["total_price"].ToString();
            }
            CalculateTotalSum();
        }

        private void ChangeValue()
        {
            if (prMap_Price_textBox.Text == "")
            {
                MessageBox.Show("This field can not be empty, please enter a valid number", "POS Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                prMap_Price_textBox.Focus();
            }
            else
            {
                decimal price_given = Convert.ToDecimal(prMap_Price_textBox.Text);
                decimal qty = prMap_Qty_numericUpDown.Value;
                decimal total = CalculateDue(qty, price_given);
            }
        }

        private void prMap_Price_textBox_TextChanged(object sender, EventArgs e)
        {
            ChangeValue();
        }

        private void prMap_Qty_numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ChangeValue();
        }

        private void prMap_dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            label13.Text = prMap_dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            prMap_supp_comboBox.Text = prMap_dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            prMap_prod_textBox.Text = prMap_dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            prMap_dateTimePicker.Text = prMap_dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            prMap_Qty_numericUpDown.Value = Convert.ToInt32(prMap_dataGridView1.SelectedRows[0].Cells[6].Value.ToString());
            prMap_Price_textBox.Text = prMap_dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            prMap_totPrice_Label.Text = prMap_dataGridView1.SelectedRows[0].Cells[8].Value.ToString();

        }

        private void PrMap_search_supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            Display_PS_BasedOnName();
        }

        private void PrMap_search_dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            Display_PS_BasedOnDate();
        }

        private void CalculateTotalSum()
        {
            decimal sumTotal = 0.00M;
            decimal total = 0.00M;
            foreach (DataGridViewRow dgv in prMap_dataGridView1.Rows)
            {
                total = Convert.ToDecimal(dgv.Cells[8].Value.ToString());
                sumTotal += total;
            }
            Pr_Map_TotalPrice_Label.Text = sumTotal.ToString();
            //MessageBox.Show("sum" +sumTotal);
        }
    }
}
