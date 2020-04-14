using Bussiness;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_Products : Form
    {
        ProductBUS productBUS = new ProductBUS();
        DataTable dtProdcut;
        public frm_Products()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }
        private void loadData()
        {
             dtProdcut = productBUS.GetDataTableProducts();
            bsProducts.DataSource = dtProdcut;
            dgvProducts.DataSource = bsProducts;
            bnProducts.BindingSource = bsProducts;
            dgvProducts.Columns["Image"].Visible = false;
            dgvProducts.Columns["Description"].Visible = false;

        }
        private void frm_Products_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm_MaintainProduct maintain = new frm_MaintainProduct(null, false);
            maintain.ShowDialog();
            loadData();
        }
        private ProductDTO GetSelectedProduct()
        {
            int index = dgvProducts.CurrentCell.RowIndex;
            ProductDTO product = new ProductDTO
            {
                ID = int.Parse(dgvProducts.Rows[index].Cells["ID"].Value.ToString()),
                Title = dgvProducts.Rows[index].Cells["Title"].Value.ToString(),
                Description = dgvProducts.Rows[index].Cells["Description"].Value.ToString(),
                Price = float.Parse(dgvProducts.Rows[index].Cells["Price"].Value.ToString()),
                Category = new CategoryDTO
                {
                    ID = int.Parse(dgvProducts.Rows[index].Cells["CategoryID"].Value.ToString())
                },
                Quantity = int.Parse(dgvProducts.Rows[index].Cells["Quantity"].Value.ToString()),
                Status = bool.Parse(dgvProducts.Rows[index].Cells["Status"].Value.ToString()),

                Image = dgvProducts.Rows[index].Cells["Image"].Value.ToString()
            };
            return product;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            frm_MaintainProduct maintain = new frm_MaintainProduct(GetSelectedProduct(), false);
            maintain.ShowDialog();
            loadData();
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            frm_MaintainProduct maintain = new frm_MaintainProduct(GetSelectedProduct(), true);
            maintain.ShowDialog();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dgvProducts.CurrentCell.RowIndex;
            ProductDTO product = new ProductDTO
            {
                ID = int.Parse(dgvProducts.Rows[index].Cells["ID"].Value.ToString())
            };
            if (MessageBox.Show("Do you want to delete Product-" + product.ID + "?", "Delete Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (productBUS.DeleteProduct(product))
                {
                    MessageBox.Show("Delete products was successfull!", "Delete Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadData();
                }
                else
                {
                    MessageBox.Show("Delete products was fail!", "Delete Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search")
            {
                txtSearch.Text = "";
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Search";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtProdcut.DefaultView.RowFilter = string.Format("Title LIKE '%{0}%'", txtSearch.Text);
        }
     
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dtProdcut.DefaultView.RowFilter = string.Format("Title LIKE '%{0}%'", txtSearch.Text);
        }

        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {
            dtProdcut.DefaultView.RowFilter = string.Format("Status = {0}", chkStatus.Checked);
        }
    }
}
