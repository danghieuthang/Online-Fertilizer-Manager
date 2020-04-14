namespace GUI
{
    partial class GUI_Manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.btnOrder = new FontAwesome.Sharp.IconButton();
            this.btnReport = new FontAwesome.Sharp.IconButton();
            this.btnCategory = new FontAwesome.Sharp.IconButton();
            this.btnProduct = new FontAwesome.Sharp.IconButton();
            this.btnAccount = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnTitle = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconUser = new FontAwesome.Sharp.IconPictureBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconCurrentMenu = new FontAwesome.Sharp.IconPictureBox();
            this.pnChild = new System.Windows.Forms.Panel();
            this.lbTime = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnTitle.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentMenu)).BeginInit();
            this.pnChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(58)))));
            this.pnMenu.Controls.Add(this.btnSetting);
            this.pnMenu.Controls.Add(this.btnOrder);
            this.pnMenu.Controls.Add(this.btnReport);
            this.pnMenu.Controls.Add(this.btnCategory);
            this.pnMenu.Controls.Add(this.btnProduct);
            this.pnMenu.Controls.Add(this.btnAccount);
            this.pnMenu.Controls.Add(this.btnDashboard);
            this.pnMenu.Controls.Add(this.panel1);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(220, 673);
            this.pnMenu.TabIndex = 0;
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSetting.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btnSetting.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSetting.IconSize = 32;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 480);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnSetting.Rotation = 0D;
            this.btnSetting.Size = new System.Drawing.Size(220, 60);
            this.btnSetting.TabIndex = 10;
            this.btnSetting.Text = "Setting";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnOrder.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOrder.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnOrder.IconColor = System.Drawing.Color.Gainsboro;
            this.btnOrder.IconSize = 32;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(0, 420);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnOrder.Rotation = 0D;
            this.btnOrder.Size = new System.Drawing.Size(220, 60);
            this.btnOrder.TabIndex = 9;
            this.btnOrder.Text = "Orders";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReport
            // 
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnReport.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReport.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnReport.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReport.IconSize = 32;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 360);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnReport.Rotation = 0D;
            this.btnReport.Size = new System.Drawing.Size(220, 60);
            this.btnReport.TabIndex = 8;
            this.btnReport.Text = "Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCategory.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCategory.IconChar = FontAwesome.Sharp.IconChar.CreativeCommonsPd;
            this.btnCategory.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCategory.IconSize = 32;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(0, 300);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnCategory.Rotation = 0D;
            this.btnCategory.Size = new System.Drawing.Size(220, 60);
            this.btnCategory.TabIndex = 7;
            this.btnCategory.Text = "Category";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnProduct.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProduct.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            this.btnProduct.IconColor = System.Drawing.Color.Gainsboro;
            this.btnProduct.IconSize = 32;
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(0, 240);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnProduct.Rotation = 0D;
            this.btnProduct.Size = new System.Drawing.Size(220, 60);
            this.btnProduct.TabIndex = 4;
            this.btnProduct.Text = "Products";
            this.btnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAccount.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAccount.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.btnAccount.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAccount.IconSize = 32;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(0, 180);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnAccount.Rotation = 0D;
            this.btnAccount.Size = new System.Drawing.Size(220, 60);
            this.btnAccount.TabIndex = 3;
            this.btnAccount.Text = "Accounts";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.btnDashboard.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDashboard.IconSize = 32;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 120);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnDashboard.Rotation = 0D;
            this.btnDashboard.Size = new System.Drawing.Size(220, 60);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 120);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(58)))));
            this.pictureBox1.Image = global::GUI.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pnTitle.Controls.Add(this.panel2);
            this.pnTitle.Controls.Add(this.label1);
            this.pnTitle.Controls.Add(this.iconCurrentMenu);
            this.pnTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitle.Location = new System.Drawing.Point(220, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(1042, 65);
            this.pnTitle.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconUser);
            this.panel2.Controls.Add(this.lbUserName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(852, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 65);
            this.panel2.TabIndex = 4;
            // 
            // iconUser
            // 
            this.iconUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconUser.ForeColor = System.Drawing.Color.DarkViolet;
            this.iconUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconUser.IconColor = System.Drawing.Color.DarkViolet;
            this.iconUser.IconSize = 47;
            this.iconUser.Location = new System.Drawing.Point(3, 12);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(50, 47);
            this.iconUser.TabIndex = 2;
            this.iconUser.TabStop = false;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.ForeColor = System.Drawing.Color.Cyan;
            this.lbUserName.Location = new System.Drawing.Point(59, 21);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(73, 23);
            this.lbUserName.TabIndex = 3;
            this.lbUserName.Text = "Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(81, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Home";
            // 
            // iconCurrentMenu
            // 
            this.iconCurrentMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentMenu.ForeColor = System.Drawing.Color.BlueViolet;
            this.iconCurrentMenu.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentMenu.IconColor = System.Drawing.Color.BlueViolet;
            this.iconCurrentMenu.IconSize = 47;
            this.iconCurrentMenu.Location = new System.Drawing.Point(28, 12);
            this.iconCurrentMenu.Name = "iconCurrentMenu";
            this.iconCurrentMenu.Size = new System.Drawing.Size(47, 50);
            this.iconCurrentMenu.TabIndex = 0;
            this.iconCurrentMenu.TabStop = false;
            // 
            // pnChild
            // 
            this.pnChild.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnChild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnChild.Controls.Add(this.lbTime);
            this.pnChild.Controls.Add(this.pictureBox2);
            this.pnChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnChild.Location = new System.Drawing.Point(220, 65);
            this.pnChild.Name = "pnChild";
            this.pnChild.Size = new System.Drawing.Size(1042, 608);
            this.pnChild.TabIndex = 2;
            // 
            // lbTime
            // 
            this.lbTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbTime.Location = new System.Drawing.Point(259, 479);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(91, 40);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "Now";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::GUI.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(320, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(396, 304);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GUI_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.pnChild);
            this.Controls.Add(this.pnTitle);
            this.Controls.Add(this.pnMenu);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "GUI_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Online Fertilizer Manager";
            this.pnMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnTitle.ResumeLayout(false);
            this.pnTitle.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentMenu)).EndInit();
            this.pnChild.ResumeLayout(false);
            this.pnChild.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnMenu;
        private FontAwesome.Sharp.IconButton btnProduct;
        private FontAwesome.Sharp.IconButton btnAccount;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnTitle;
        private FontAwesome.Sharp.IconPictureBox iconCurrentMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnChild;
        private System.Windows.Forms.Label lbUserName;
        private FontAwesome.Sharp.IconPictureBox iconUser;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnCategory;
        private FontAwesome.Sharp.IconButton btnOrder;
        private FontAwesome.Sharp.IconButton btnReport;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton btnSetting;
    }
}