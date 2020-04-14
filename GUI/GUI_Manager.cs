using FontAwesome.Sharp;
using GUI.Categories;
using GUI.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
  
    public partial class GUI_Manager : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public GUI_Manager()
        {
            InitializeComponent();
            this.Hide();
            GUI_Login gui_LOGIN = new GUI_Login();
            gui_LOGIN.ShowDialog();
            if (gui_LOGIN.IsLogin)
            {
                this.Show();
            }
          
            
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            pnMenu.Controls.Add(leftBorderBtn);
            this.Text = string.Empty;
           // this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
  
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DiableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
               
                iconCurrentMenu.IconChar = currentBtn.IconChar;
                iconCurrentMenu.IconColor = color;
            }
        }
        private void DiableButton()
        {
            if (currentBtn != null)
            {

                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
       
        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            pnChild.Controls.Add(childForm);
            childForm.Dock = DockStyle.Fill;
            pnChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();   
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Green);
            openChildForm(new frm_Products());
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Green);
            openChildForm(new frm_Reports());
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Green);
            frm_Accounts frm_Accounts = new frm_Accounts();
            openChildForm(frm_Accounts);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Green);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Green);
            
        }
        private void reset()
        {
            DiableButton();
            leftBorderBtn.Visible = false;
            iconCurrentMenu.IconChar = IconChar.Home;
            iconCurrentMenu.IconColor = Color.BlueViolet;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            reset();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Green);
            openChildForm(new  frm_Category());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss  dddd,MMMM mm, yyy");
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, Color.Green);
            frm_Orders frm_Orders = new frm_Orders();
            openChildForm(frm_Orders);
        }
    }
}
