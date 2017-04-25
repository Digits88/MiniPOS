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

        private void ClearProduct_Supplier()
        {
            decimal tot_price = 0.00M;
            cboProdMapSupplierName.SelectedIndex = -1;
            numericProdMapQty.Value = 0;
            txtProdMapGivenPrice.Text = tot_price.ToString();
            lblProdMapTotalPrice.Text = tot_price.ToString();
            txtProdMapProduct.Text = "Milk";
            lblSupplierId.Text = "";
        }

        private void RetrieveSupplier()
        {
            SqlCommand cmd = new SqlCommand("select sup_fname from supplier", con.ActiveConn());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //string.Format("{0} {1}")
                cboProdMapSupplierName.Items.Add(reader["sup_fname"].ToString());
                cboProdMapSearchSupplier.Items.Add(reader["sup_fname"].ToString());
            }
            reader.Close();
        }

        private string RetrieveSupplierId()
        {
            string tmp = "";
            SqlCommand cmd = new SqlCommand("select sup_Id from supplier where sup_fname = '" + cboProdMapSupplierName.Text + "' ", con.ActiveConn());
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                tmp = rdr["sup_Id"].ToString();
            }
            rdr.Close();
            return tmp;
        }

        private void DisplayProd_SuppMap()
        {
            ClearProduct_Supplier();
            SqlDataAdapter da = new SqlDataAdapter("select * from product_supplier P, supplier S where P.supp_id = S.sup_Id", con.ActiveConn());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvProdMapInformation.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dgvProdMapInformation.Rows.Add();
                dgvProdMapInformation.Rows[n].Cells[0].Value = item["ps_Id"].ToString();
                dgvProdMapInformation.Rows[n].Cells[1].Value = item["sup_fname"].ToString();
                dgvProdMapInformation.Rows[n].Cells[2].Value = item["sup_lname"].ToString();
                dgvProdMapInformation.Rows[n].Cells[3].Value = item["sup_telephone"].ToString();
                dgvProdMapInformation.Rows[n].Cells[4].Value = item["product"].ToString();
                dgvProdMapInformation.Rows[n].Cells[5].Value = item["supplied_date"].ToString();
                dgvProdMapInformation.Rows[n].Cells[6].Value = item["total_amount"].ToString();
                dgvProdMapInformation.Rows[n].Cells[7].Value = item["price_unit"].ToString();
                dgvProdMapInformation.Rows[n].Cells[8].Value = item["total_price"].ToString();
            }
        }

        private void btnProdMapClearForm_Click(object sender, EventArgs e)
        {
            ClearProduct_Supplier();
        }

        private void Product_Supplier_Load(object sender, EventArgs e)
        {
            ClearProduct_Supplier();
            lblSupplierId.Hide();
            RetrieveSupplier();
            DisplayProd_SuppMap();
            CalculateTotalSum();
            /*DataGridViewCheckBoxColumn dg_chk = new DataGridViewCheckBoxColumn();
            prMap_dataGridView1.Columns.Add(dg_chk);
            dg_chk.HeaderText = "Filter";
            dg_chk.Name = "chkBox";*/
        }

        private decimal CalculateDue(decimal quantity,decimal unit_price)
        {
            decimal total = 0;
            quantity = numericProdMapQty.Value;
            unit_price = Convert.ToDecimal(txtProdMapGivenPrice.Text);
            total = quantity * unit_price;
            lblProdMapTotalPrice.Text = total.ToString();
            return total;
        }

        private void btnProdMapSaveNewInfo_Click(object sender, EventArgs e)
        {
            string supp_id = RetrieveSupplierId();
            //TODO - calculation of the total amount in another function
            //decimal total = CalculateDue();
            //prMap_totPrice_Label.Text = total.ToString();
            string theDate = dateTimePickerProdMap.Value.ToShortDateString();
            SqlCommand cmd1 = new SqlCommand(@"Insert into product_supplier (supp_id,supplied_date,total_amount,price_unit,total_price,product) 
                        values ('" + supp_id + "','" + theDate + "','" + numericProdMapQty.Value + "','" + txtProdMapGivenPrice.Text + "','" + lblProdMapTotalPrice.Text + "','" + txtProdMapProduct.Text + "')", con.ActiveConn());
            //prMap_totPrice_Label.Text
            cmd1.ExecuteNonQuery();
            MessageBox.Show("The Product-Supplier Information is saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearProduct_Supplier();
            DisplayProd_SuppMap();
            CalculateTotalSum();
        }

        private void btnProdMapUpdateInfo_Click(object sender, EventArgs e)
        {
            string suppp_id = RetrieveSupplierId();
            // TODO - calculation of the total amount in another function

            SqlCommand cmd = new SqlCommand("update product_supplier set supplied_date = '" + dateTimePickerProdMap.Value + "', total_amount = '" + numericProdMapQty.Value + "', price_unit = '" + txtProdMapGivenPrice.Text + "', total_price = '" + lblProdMapTotalPrice.Text + "' where supp_id = '" + suppp_id + "' and ps_Id = '"+ lblSupplierId.Text +"' ", con.ActiveConn());
            cmd.ExecuteNonQuery();
            MessageBox.Show("The Product-Inventory Information is updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearProduct_Supplier();
            DisplayProd_SuppMap();
            CalculateTotalSum();
        }

        private void btnProdMapDeleteInfo_Click(object sender, EventArgs e)
        {
            string sp_id = RetrieveSupplierId();
            SqlCommand cmd = new SqlCommand("delete from product_supplier where supp_id = '" + sp_id + "' and ps_Id = '" + lblSupplierId.Text + "' ", con.ActiveConn());
            DialogResult msg = MessageBox.Show("Are you sure you want to delete this information", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (msg == System.Windows.Forms.DialogResult.Yes)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("The Product-Supplier Information is deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearProduct_Supplier();
                DisplayProd_SuppMap();
                CalculateTotalSum();
            }
            else
            {
                MessageBox.Show("Product-Supplier information is not deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearProduct_Supplier();
                //Display_Prod_Supp_Map();
            }
        }

        private void DisplayProdSuppBasedOnName()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from product_supplier P, supplier S where P.supp_id = S.sup_Id and sup_fname = '" + cboProdMapSearchSupplier.Text + "' ", con.ActiveConn());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvProdMapInformation.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dgvProdMapInformation.Rows.Add();
                dgvProdMapInformation.Rows[n].Cells[0].Value = item["ps_Id"].ToString();
                dgvProdMapInformation.Rows[n].Cells[1].Value = item["sup_fname"].ToString();
                dgvProdMapInformation.Rows[n].Cells[2].Value = item["sup_lname"].ToString();
                dgvProdMapInformation.Rows[n].Cells[3].Value = item["sup_telephone"].ToString();
                dgvProdMapInformation.Rows[n].Cells[4].Value = item["product"].ToString();
                dgvProdMapInformation.Rows[n].Cells[5].Value = item["supplied_date"].ToString();
                dgvProdMapInformation.Rows[n].Cells[6].Value = item["total_amount"].ToString();
                dgvProdMapInformation.Rows[n].Cells[7].Value = item["price_unit"].ToString();
                dgvProdMapInformation.Rows[n].Cells[8].Value = item["total_price"].ToString();
            }
            CalculateTotalSum();
        }

        private void DisplayProdSuppBasedOnDate()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from product_supplier P, supplier S where P.supp_id = S.sup_Id and P.supplied_date = '" + Convert.ToDateTime(datePickerProdMapByDate.Text) + "' ", con.ActiveConn());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvProdMapInformation.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dgvProdMapInformation.Rows.Add();
                dgvProdMapInformation.Rows[n].Cells[0].Value = item["ps_Id"].ToString();
                dgvProdMapInformation.Rows[n].Cells[1].Value = item["sup_fname"].ToString();
                dgvProdMapInformation.Rows[n].Cells[2].Value = item["sup_lname"].ToString();
                dgvProdMapInformation.Rows[n].Cells[3].Value = item["sup_telephone"].ToString();
                dgvProdMapInformation.Rows[n].Cells[4].Value = item["product"].ToString();
                dgvProdMapInformation.Rows[n].Cells[5].Value = item["supplied_date"].ToString();
                dgvProdMapInformation.Rows[n].Cells[6].Value = item["total_amount"].ToString();
                dgvProdMapInformation.Rows[n].Cells[7].Value = item["price_unit"].ToString();
                dgvProdMapInformation.Rows[n].Cells[8].Value = item["total_price"].ToString();
            }
            CalculateTotalSum();
        }

        private void ChangeValue()
        {
            if (txtProdMapGivenPrice.Text == "")
            {
                MessageBox.Show("This field can not be empty, please enter a valid number", "POS Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProdMapGivenPrice.Focus();
            }
            else
            {
                decimal price_given = Convert.ToDecimal(txtProdMapGivenPrice.Text);
                decimal qty = numericProdMapQty.Value;
                decimal total = CalculateDue(qty, price_given);
            }
        }

        private void txtProdMapGivenPrice_TextChanged(object sender, EventArgs e)
        {
            ChangeValue();
        }

        private void numericProdMapQty_ValueChanged(object sender, EventArgs e)
        {
            ChangeValue();
        }

        private void dgvProdMapInformation_MouseClick(object sender, MouseEventArgs e)
        {
            lblSupplierId.Text = dgvProdMapInformation.SelectedRows[0].Cells[0].Value.ToString();
            cboProdMapSupplierName.Text = dgvProdMapInformation.SelectedRows[0].Cells[1].Value.ToString();
            txtProdMapProduct.Text = dgvProdMapInformation.SelectedRows[0].Cells[4].Value.ToString();
            dateTimePickerProdMap.Text = dgvProdMapInformation.SelectedRows[0].Cells[5].Value.ToString();
            numericProdMapQty.Value = Convert.ToInt32(dgvProdMapInformation.SelectedRows[0].Cells[6].Value.ToString());
            txtProdMapGivenPrice.Text = dgvProdMapInformation.SelectedRows[0].Cells[7].Value.ToString();
            lblProdMapTotalPrice.Text = dgvProdMapInformation.SelectedRows[0].Cells[8].Value.ToString();

        }

        private void cboProdMapSearchSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayProdSuppBasedOnName();
        }

        private void datePickerProdMapByDate_ValueChanged(object sender, EventArgs e)
        {
            DisplayProdSuppBasedOnDate();
        }

        private void CalculateTotalSum()
        {
            decimal sumTotal = 0.00M;
            decimal total = 0.00M;
            foreach (DataGridViewRow dgv in dgvProdMapInformation.Rows)
            {
                total = Convert.ToDecimal(dgv.Cells[8].Value.ToString());
                sumTotal += total;
            }
            lblProdMapSumTotalPrice.Text = sumTotal.ToString();
            //MessageBox.Show("sum" +sumTotal);
        }
    }
}
