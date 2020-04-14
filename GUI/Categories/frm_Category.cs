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

namespace GUI.Categories
{
    public partial class frm_Category : Form
    {
        DataTable dtCategories;
        CategoryBUS categoryBUS = new CategoryBUS();
        public frm_Category()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            dtCategories = categoryBUS.GetDataTableCategory();
            bsCategories.DataSource = dtCategories;
            bnCategories.BindingSource = bsCategories;
            dgvCategoryList.DataSource = bsCategories;
       
        }
        private void frm_Category_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private bool ValidData(bool isInsert)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Category name must be required!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            if (isInsert)
            {
                if (categoryBUS.IsExistsCategory(txtName.Text))
                {
                    MessageBox.Show("Category name was exists!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();
                    return false;
                }
            }
            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidData(true))
            {
                return;
            }
            int rowIndex = dgvCategoryList.CurrentCell.RowIndex;
            CategoryDTO category = new CategoryDTO { Name = txtName.Text, ID = int.Parse(dtCategories.Rows[rowIndex]["ID"].ToString()) };
            if (MessageBox.Show("Do you want to add new Category?", "Add Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (categoryBUS.InsertCategory(category))
                {
                    MessageBox.Show("Add category was successfull!", "Add Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Add category was fail!", "Add Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dgvCategoryList.CurrentCell.RowIndex;
            CategoryDTO category = new CategoryDTO {ID=int.Parse(dtCategories.Rows[rowIndex]["ID"].ToString()) };
            if (MessageBox.Show("Do you want to delete Category-" + category.ID + "?", "Delete Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (categoryBUS.DeleteCategory(category))
                {
                    MessageBox.Show("Delete category was successfull!", "Delete Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Delete category was fail!", "Delete Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidData(false))
            {
                return;
            }
            int rowIndex = dgvCategoryList.CurrentCell.RowIndex;
            CategoryDTO category = new CategoryDTO { Name=txtName.Text, ID = int.Parse(dtCategories.Rows[rowIndex]["ID"].ToString()) };
            if (MessageBox.Show("Do you want to Update Category-" + dtCategories.Rows[rowIndex]["Name"].ToString() + "?", "Update Category", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (categoryBUS.UpdateCategory(category))
                {
                    MessageBox.Show("Update category was successfull!", "Update Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Update category was fail!", "Update Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
          
            txtName.Text = "";
        }

        private void dgvCategoryList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Change");
        }

        private void dgvCategoryList_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            MessageBox.Show("Change");
        }

        private void bindingNavigatorPositionItem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = dgvCategoryList.CurrentCell.RowIndex;
                txtName.Text = dtCategories.Rows[rowIndex]["Name"].ToString();
            }
            catch (Exception)
            {

               
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
        }
    }
}
