using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPOS
{
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
        }

        private void POS_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void supplierInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier sup = new Supplier();
            sup.MdiParent = this;
            sup.StartPosition = FormStartPosition.CenterScreen;
            sup.Show();
        }

        private void customerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer();
            cust.MdiParent = this;
            cust.StartPosition = FormStartPosition.CenterScreen;
            cust.Show();
        }

        private void productRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product prod = new Product();
            prod.MdiParent = this;
            prod.StartPosition = FormStartPosition.CenterScreen;
            prod.Show();
        }

        private void productSupplierMapToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Product_Supplier pr_map = new Product_Supplier();
            pr_map.MdiParent = this;
            pr_map.StartPosition = FormStartPosition.CenterScreen;
            pr_map.Show();
        }

        private void salesInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale sales = new Sale();
            sales.MdiParent = this;
            sales.StartPosition = FormStartPosition.CenterScreen;
            sales.Show();
        }

        private void POS_Load(object sender, EventArgs e)
        {
            //here get the expiry dates of items
            //and load it when the form is loaded
        }
    }
}
