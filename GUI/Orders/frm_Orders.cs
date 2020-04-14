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

namespace GUI.Reports
{
    public partial class frm_Orders : Form
    {
        DataTable dtReport=new DataTable();
        OrderBUS orderBUS = new OrderBUS();
        public frm_Orders()
        {
            InitializeComponent();
        }
        private void LoadData() {
            dtReport = orderBUS.GetDataTableAllOrder();
            bsOrders.DataSource = dtReport;
            bnOrders.BindingSource = bsOrders;
            dgvReport.DataSource = bsOrders;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void frm_Orders_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string dFrom = dateFrom.Value.ToString("MM/dd/yyyy");
            string dTo = dateTo.Value.ToString("MM/dd/yyyy");
            
            if (dTo.CompareTo(dFrom)<0)
            {
                MessageBox.Show("Date To must be greater than DateFrom", "Warming", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //bsOrders.DataSource = orderBUS.GetDataTableSearch(dFrom, dTo);
            //bnOrders.BindingSource = bsOrders;
            //dgvReport.DataSource = bsOrders;
            dtReport.DefaultView.RowFilter = "CreateDate >= '" +dFrom + "' AND CreateDate<='"+dTo+"'";
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (dgvReport.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp = new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);
                for(int i = 1; i < dgvReport.Columns.Count+1; i++)
                {
                    xcelApp.Cells[1, i] = dgvReport.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dgvReport.Rows.Count-1; i++)
                {
                    for(int j=0; j<dgvReport.Columns.Count; j++)
                    {
                        xcelApp.Cells[i+2, j+1] = dgvReport.Rows[i].Cells[j].Value.ToString();
                    }
                    xcelApp.Columns.AutoFit();
                    xcelApp.Visible = true;
                   
                }
            }
            else
            {
                MessageBox.Show("Orders List is empty!", "Warming", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
