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
    public partial class frm_Accounts : Form
    {
        DataTable dtAccounts;
        AccountBUS accountBUS = new AccountBUS();
        
        public frm_Accounts()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dtAccounts = accountBUS.GetAllAccounts();
            bsProducts.DataSource = dtAccounts;
            bnProducts.BindingSource = bsProducts;
            dgvAccountList.DataSource = bsProducts;
        }
      
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dgvAccountList.CurrentCell.RowIndex;
            AccountDTO account = new AccountDTO { Email = dtAccounts.Rows[index]["Email"].ToString() };
            if (MessageBox.Show("Do you want to delete Account-" + account.Email + "?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (accountBUS.DeleteAccount(account))
                {
                    MessageBox.Show("Delete account was successfull!", "Delete Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Delete account was fail!", "Delete Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
        private AccountDTO GetSelectAccount()
        {
            int rowIndex = dgvAccountList.CurrentCell.RowIndex;
            AccountDTO account = new AccountDTO
            {
                Email = dgvAccountList.Rows[rowIndex].Cells["Email"].Value.ToString(),
                Name = dgvAccountList.Rows[rowIndex].Cells["Name"].Value.ToString(),
                Password = dgvAccountList.Rows[rowIndex].Cells["Password"].Value.ToString(),
                Role = new RoleDTO { ID = int.Parse(dgvAccountList.Rows[rowIndex].Cells["RoleID"].Value.ToString()) },
                Status = bool.Parse(dgvAccountList.Rows[rowIndex].Cells["Status"].Value.ToString())
            };
            return account;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frm_MaintainAccount frm_MaintainAccount = new frm_MaintainAccount(GetSelectAccount(), false);
            frm_MaintainAccount.ShowDialog();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm_MaintainAccount frm_MaintainAccount = new frm_MaintainAccount(null, false);
            frm_MaintainAccount.ShowDialog();
            LoadData();
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            frm_MaintainAccount frm_MaintainAccount = new frm_MaintainAccount(GetSelectAccount(), true);
            frm_MaintainAccount.ShowDialog();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            dtAccounts.DefaultView.RowFilter = "Name LIKE '%" + txtName.Text + "%'";
        }
    }
}
