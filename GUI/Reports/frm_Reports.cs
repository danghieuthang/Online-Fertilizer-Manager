using Bussiness;
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
    public partial class frm_Reports : Form
    {
        OrderBUS orderBUS = new OrderBUS();
        public frm_Reports()
        {
            InitializeComponent();
        }

        private void LoadDataCategory()
        {
            char_order.Series.Clear();
            char_order.Titles.Clear();
            // char_order = new System.Windows.Forms.DataVisualization.Charting.Chart();
            char_order.Series.Add("Number Of Product");
            char_order.DataSource = orderBUS.GetDataTableNumberPOfCategory();
            char_order.Series["Number Of Product"].XValueMember = "Name";
            char_order.Series["Number Of Product"].YValueMembers = "Number Of Product";
            char_order.Titles.Add("Number product sell by Category Chart");
        }
        private void LoadDataProduct()
        {
            char_order.Series.Clear();
            char_order.Titles.Clear();
           // char_order = new System.Windows.Forms.DataVisualization.Charting.Chart();
            char_order.Series.Add("Number Of Product");
            char_order.DataSource = orderBUS.GetDataTableNumberProductSell();
            char_order.Series["Number Of Product"].XValueMember = "ProductID";
            char_order.Series["Number Of Product"].YValueMembers = "Number Of Product";
            char_order.Titles.Add("Number product sell Chart");
            char_order.Show();
        }
        private void frm_Reports_Load(object sender, EventArgs e)
        {
            LoadDataCategory();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            LoadDataProduct();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            LoadDataCategory();
        }

        private void btnReportWeek_Click(object sender, EventArgs e)
        {
            char_order.Series.Clear();
            char_order.Titles.Clear();
            // char_order = new System.Windows.Forms.DataVisualization.Charting.Chart();
            char_order.Series.Add("Number Of Product");
            char_order.DataSource = orderBUS.GetTopProductSellByWeek();
            char_order.Series["Number Of Product"].XValueMember = "ProductID";
            char_order.Series["Number Of Product"].YValueMembers = "Number Of Product";
            char_order.Titles.Add("Number product sell Chart");
            char_order.Show();
        }

        private void btnReportMonth_Click(object sender, EventArgs e)
        {
            char_order.Series.Clear();
            char_order.Titles.Clear();
            // char_order = new System.Windows.Forms.DataVisualization.Charting.Chart();
            char_order.Series.Add("Number Of Product");
            char_order.DataSource = orderBUS.GetTopProductSellByMonth();
            char_order.Series["Number Of Product"].XValueMember = "ProductID";
            char_order.Series["Number Of Product"].YValueMembers = "Number Of Product";
            char_order.Titles.Add("Number product sell Chart");
            char_order.Show();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
