using Bussiness;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_MaintainAccount : Form
    {
        AccountBUS accountBus = new AccountBUS();
        AccountDTO account;
        RoleBUS roleBUS = new RoleBUS();
        DataTable dtRole;
        bool isView;
        bool isUpdate;
        public frm_MaintainAccount(AccountDTO acount, bool view)
        {
            InitializeComponent();
            this.account = acount;
            LoadData();
            isView = view;
            SetupData();
            txtPassword.UseSystemPasswordChar = true;
        }
        private void LoadData()
        {
            dtRole = roleBUS.GetAllRoles();
            cbRole.DataSource = dtRole;
            cbRole.DisplayMember = "Name";
        }
        private void SetupData()
        {
            if (account != null)
            {
                txtEmail.Text = account.Email;
                txtName.Text = account.Name;
                txtPassword.Text = account.Password;

                txtCreateDate.Text = account.CreateDate.ToString();
                chkStatus.Checked = account.Status;

                string filter = " ID= '" + account.Role.ID + "'";
                DataRow[] rows = dtRole.Select(filter);
                BindingSource bs = new BindingSource();
                bs.DataSource = dtRole;
                int rowIndex = bs.Find("ID", account.Role.ID);
                cbRole.SelectedIndex = rowIndex;
                if (isView)
                {
                    btnAdd.Hide();
                    btnUpdate.Hide();
                    this.Text = "View Account";
                }
                else
                {
                    btnAdd.Hide();
                    this.Text = "Update Account";
                    isUpdate = true;
                }
            }
            else
            {
                btnUpdate.Hide();
                this.Text = "Add Account";
                txtEmail.ReadOnly = false;
                txtCreateDate.Text = DateTime.Now.ToString();
            }
        }
        private bool ValidData()
        {
            if (!isUpdate)
            {
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Email must be required!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return false;
                }
                Regex re = new Regex(@"^[a-z][a-z0-9_]{2,32}@[a-z0-9]{2,}([.][a-z0-9]{2,4}){1,2}$");
                if (!re.IsMatch(txtEmail.Text))
                {
                    MessageBox.Show("Email must be valid email!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return false;
                }
                if (accountBus.IsExistsEmail(txtEmail.Text))
                {
                    MessageBox.Show("Email was exists!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return false;
                }
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name must be required!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password must be required!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            return true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidData())
            {
                return;
            }
            int index = cbRole.SelectedIndex;
            account = new AccountDTO
            {
                Email = txtEmail.Text,
                Name = txtName.Text,
                Password = txtPassword.Text,
                CreateDate = DateTime.Now,
                Status = chkStatus.Checked,
                Role = new RoleDTO
                {
                    ID = int.Parse(dtRole.Rows[index]["ID"].ToString())
                }
            };
            if (accountBus.InsertAccount(account))
            {
                MessageBox.Show("Add Account was successfull!", "Insert Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Add Account was fail!", "Insert Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidData())
            {
                return;
            }
            int index = cbRole.SelectedIndex;
            account = new AccountDTO
            {
                Email = txtEmail.Text,
                Name = txtName.Text,
                Password = txtPassword.Text,
                CreateDate = DateTime.Now,
                Status = chkStatus.Checked,
                Role = new RoleDTO
                {
                    ID = int.Parse(dtRole.Rows[index]["ID"].ToString())
                }

            };
            if (accountBus.UpdateAccount(account))
            {
                MessageBox.Show("Update account was successfull!", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Update account was fail!", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
