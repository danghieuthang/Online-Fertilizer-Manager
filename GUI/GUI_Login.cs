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
    public partial class GUI_Login : Form
    {
        private bool isLogin = false;

        public bool IsLogin { get => isLogin; set => isLogin = value; }

        public GUI_Login()
        {
            InitializeComponent();
        }
      

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { Application.Exit(); }
        }

        private void btnMinisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "Employee Email")
            {
                txtID.Text = "";
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                txtID.Text = "Employee Email";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountBUS accountBUS = new AccountBUS();
            AccountDTO account = accountBUS.checkLogin(txtID.Text, txtPassword.Text);
            if (account == null)
            {
                MessageBox.Show("Account not found!");
            }else if (account.Role.Name.Equals("admin"))
            {
                this.Hide();
                IsLogin = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Account not permit!");
            }
        }
    }
}
