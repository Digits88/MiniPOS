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

        private void ClearSalesInfo()
        {
            decimal tot_price = 0.00M;
            cboSaleProductName.SelectedIndex = -1;
            cboSaleType.SelectedIndex = -1;
            numericSaleQty.Value = 0;
            txtSaleUnitPrice.Text = tot_price.ToString();
            lblSaleTotalPrice.Text = tot_price.ToString();
            lblProductId.Text = "";
            lblSaleSumTotalPrice.Text = "0.00";
        }

        private void RetrieveProductType()
        {
            SqlCommand cmd = new SqlCommand("select prod_type from prod_inventory", con.ActiveConn());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cboSaleProductName.Items.Add(reader["prod_type"].ToString());
            }
            reader.Close();
        }

        private string RetrieveInventoryProdId()
        {
            string temp = "";
            SqlCommand cmd = new SqlCommand("select inv_Id from prod_inventory where prod_type = '" + cboSaleProductName.Text + "' ", con.ActiveConn());
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                temp = rdr["inv_Id"].ToString();
            }
            rdr.Close();
            return temp;
        }

        private void DisplaySale()
        {
            ClearSalesInfo();
            //string tmp = Retrieve_InvProdId();
            SqlDataAdapter da = new SqlDataAdapter("select * from prod_inventory P, sale S where P.inv_Id = S.invSale_Id", con.ActiveConn());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSalePurchaseList.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dgvSalePurchaseList.Rows.Add();
                dgvSalePurchaseList.Rows[n].Cells[0].Value = item["sales_Id"].ToString();
                //sale_dataGridView1.Rows[n].Cells[0].Value = tmp;
                dgvSalePurchaseList.Rows[n].Cells[1].Value = item["prod_type"].ToString();
                dgvSalePurchaseList.Rows[n].Cells[2].Value = item["expiry_date"].ToString();
                dgvSalePurchaseList.Rows[n].Cells[3].Value = item["sales_type"].ToString();
                dgvSalePurchaseList.Rows[n].Cells[4].Value = item["quantity"].ToString();
                dgvSalePurchaseList.Rows[n].Cells[5].Value = item["price_unit"].ToString();
                dgvSalePurchaseList.Rows[n].Cells[6].Value = item["total_price"].ToString();
            }
        }

        private decimal CalculateTotalPrice(decimal quantity, decimal unit_price)
        {
            decimal total = 0;
            quantity = numericSaleQty.Value;
            unit_price = Convert.ToDecimal(txtSaleUnitPrice.Text);
            total = quantity * unit_price;
            lblSaleTotalPrice.Text = total.ToString();
            return total;
        }

        private void ChangeValue()
        {
            if (txtSaleUnitPrice.Text == "")
            {
                MessageBox.Show("This field can not be empty, please enter a valid number", "POS Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSaleUnitPrice.Focus();
            }
            else
            {
                decimal price_given = Convert.ToDecimal(txtSaleUnitPrice.Text);
                decimal qty = numericSaleQty.Value;
                decimal total = CalculateTotalPrice(qty, price_given);
            }
        }

        private void AddToGrid()
        {
            string tmp = RetrieveInventoryProdId();
            string theDate = datePickerSaleDate.Value.ToShortDateString();
            //sale_dataGridView1.Rows[0].Cells[0].Value = tmp;
            dgvSalePurchaseList.Rows.Add(tmp, cboSaleProductName.Text, theDate, cboSaleType.Text, numericSaleQty.Value, txtSaleUnitPrice.Text, lblSaleTotalPrice.Text);
        }

        private void RemoveFromGrid()
        {
            int selectedIndex = dgvSalePurchaseList.CurrentCell.RowIndex;
            if (selectedIndex > -1)
            {
                dgvSalePurchaseList.Rows.RemoveAt(selectedIndex);
                dgvSalePurchaseList.Refresh();
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
            foreach (DataGridViewRow dgv in dgvSalePurchaseList.Rows)
            {
                total = Convert.ToDecimal(dgv.Cells[6].Value.ToString());
                sumTotal += total;
            }
            lblSaleSumTotalPrice.Text = sumTotal.ToString();
            //MessageBox.Show("sum" +sumTotal);
        }

        private int CalculateDifference()
        {
            int diff = 0;
            int temp = 0;
            string inv_id = RetrieveInventoryProdId();
            SqlCommand cmd = new SqlCommand("select qty from prod_inventory where inv_Id = '" + inv_id + "' ", con.ActiveConn());
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                temp = Convert.ToInt32(rdr["qty"].ToString());
            }
            diff = Convert.ToInt32(temp - numericSaleQty.Value);
            rdr.Close();
            return diff;
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            /*DataGridViewCheckBoxColumn dg_chk = new DataGridViewCheckBoxColumn();
            sale_dataGridView1.Columns.Add(dg_chk);
            dg_chk.HeaderText = "Filter";
            dg_chk.Name = "chkBox";
            DisplaySale();*/
            ClearSalesInfo();
            RetrieveProductType();
            CalculateSumTotal();
        }

        private void btnSaleClearNew_Click(object sender, EventArgs e)
        {
            ClearSalesInfo();
        }

        private void numericSaleQty_ValueChanged(object sender, EventArgs e)
        {
            ChangeValue();
        }

        private void txtSaleUnitPrice_TextChanged(object sender, EventArgs e)
        {
            ChangeValue();
        }

        private void btnSaleAddToList_Click(object sender, EventArgs e)
        {
            AddToGrid();
            CalculateSumTotal();
        }

        private void btnSaleRemoveFromList_Click(object sender, EventArgs e)
        {
            RemoveFromGrid();
            CalculateSumTotal();
        }

        private void btnSalePurchase_Click(object sender, EventArgs e)
        {
            string inv_id = RetrieveInventoryProdId();
            int difference = CalculateDifference();
            string theDate = datePickerSaleDate.Value.ToShortDateString();
            SqlCommand cmd1 = new SqlCommand(@"Insert into sale (invSale_Id,sales_date,quantity,price_unit,total_price,sales_type) 
                        values ('" + inv_id + "','" + theDate + "','" + numericSaleQty.Value + "','" + txtSaleUnitPrice.Text + "','" + lblSaleTotalPrice.Text + "','" + cboSaleType.Text + "')", con.ActiveConn());
            cmd1.ExecuteNonQuery();
            MessageBox.Show("The Sales Information is saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearSalesInfo();
            dgvSalePurchaseList.Rows.Clear();

            //update information
            SqlCommand cmd2 = new SqlCommand("update prod_inventory set qty = '" + difference + "' where inv_Id = '" + inv_id + "' ", con.ActiveConn());
            cmd2.ExecuteNonQuery();
        }

        private void sale_product_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string unit_price = "";
            SqlCommand cmd3 = new SqlCommand("select unit_price from prod_inventory where prod_type = '" + cboSaleProductName.Text + "' ", con.ActiveConn());
            SqlDataReader rdr = cmd3.ExecuteReader();
            if (rdr.Read())
            {
                unit_price = rdr["unit_price"].ToString();
            }
            txtSaleUnitPrice.Text = unit_price;
            rdr.Close();
        }
    }
}
