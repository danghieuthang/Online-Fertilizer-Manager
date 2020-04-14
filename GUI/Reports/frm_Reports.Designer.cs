namespace GUI
{
    partial class frm_Reports
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.char_order = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnReportWeek = new System.Windows.Forms.Button();
            this.btnReportMonth = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.char_order)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select Chart";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnReportMonth);
            this.panel2.Controls.Add(this.btnReportWeek);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnProduct);
            this.panel2.Controls.Add(this.btnCategory);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(759, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 561);
            this.panel2.TabIndex = 6;
            // 
            // btnProduct
            // 
            this.btnProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnProduct.Location = new System.Drawing.Point(30, 178);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(200, 33);
            this.btnProduct.TabIndex = 4;
            this.btnProduct.Text = "Report Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnCategory.Location = new System.Drawing.Point(30, 102);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(200, 33);
            this.btnCategory.TabIndex = 3;
            this.btnCategory.Text = "Report Category";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Report";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(759, 48);
            this.panel3.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.char_order);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 561);
            this.panel1.TabIndex = 5;
            // 
            // char_order
            // 
            this.char_order.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.char_order.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.char_order.Legends.Add(legend2);
            this.char_order.Location = new System.Drawing.Point(30, 74);
            this.char_order.Name = "char_order";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Number Of Product";
            this.char_order.Series.Add(series2);
            this.char_order.Size = new System.Drawing.Size(696, 455);
            this.char_order.TabIndex = 5;
            this.char_order.Text = "chart1";
            // 
            // btnReportWeek
            // 
            this.btnReportWeek.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportWeek.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnReportWeek.Location = new System.Drawing.Point(30, 250);
            this.btnReportWeek.Name = "btnReportWeek";
            this.btnReportWeek.Size = new System.Drawing.Size(200, 33);
            this.btnReportWeek.TabIndex = 7;
            this.btnReportWeek.Text = "Top 5 P/Week";
            this.btnReportWeek.UseVisualStyleBackColor = true;
            this.btnReportWeek.Click += new System.EventHandler(this.btnReportWeek_Click);
            // 
            // btnReportMonth
            // 
            this.btnReportMonth.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportMonth.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnReportMonth.Location = new System.Drawing.Point(30, 321);
            this.btnReportMonth.Name = "btnReportMonth";
            this.btnReportMonth.Size = new System.Drawing.Size(200, 33);
            this.btnReportMonth.TabIndex = 8;
            this.btnReportMonth.Text = "Top 5 P/Month";
            this.btnReportMonth.UseVisualStyleBackColor = true;
            this.btnReportMonth.Click += new System.EventHandler(this.btnReportMonth_Click);
            // 
            // frm_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1024, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Reports";
            this.Text = "frm_Reports";
            this.Load += new System.EventHandler(this.frm_Reports_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.char_order)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart char_order;
        private System.Windows.Forms.Button btnReportMonth;
        private System.Windows.Forms.Button btnReportWeek;
    }
}