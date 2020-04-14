using Bussiness;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_MaintainProduct : Form
    {
        private CategoryBUS categoryBUS = new CategoryBUS();
        private ProductDTO product;
        private DataTable dtCategory;
        private ProductBUS productBUS = new ProductBUS();
        bool isView;
        private readonly string targetImagePath = @"C:\Users\dhtha\OneDrive\Documents\Visual Studio 2019\Project Final\OnlineFertilizerWeb\OnlineFertilizerWeb\Content\images";
        public frm_MaintainProduct()
        {
            InitializeComponent();
        }
        public frm_MaintainProduct(ProductDTO product, bool view)
        {
            InitializeComponent();
            this.product = product;
            isView = view;
            LoadData();
            SetValue();
        }
        private void SetValue()
        {
            if (product != null)
            {
                if (!isView) { 
                    this.Text = "Update Product";
                    btnAdd.Hide();
                }
                else
                {
                    this.Text = "View Product Detail";
                    //btnAdd.Enabled = false;
                    //btnUpdate.Enabled = false;
                    //btnImage.Enabled = false;
                    btnAdd.Hide();
                    btnUpdate.Hide();
                    btnImage.Hide();

                }
                txtTitle.Text = product.Title;
                txtQuantity.Text = product.Quantity + "";
                txtDescription.Text = product.Description;
                txtPrice.Text = product.Price + "";
                string filter = " ID= '" + product.Category.ID + "'";
                DataRow[] rows = dtCategory.Select(filter);
                BindingSource bs = new BindingSource();
                bs.DataSource = dtCategory;

                int rowIndex = bs.Find("ID", product.Category.ID);
                cbCategory.SelectedIndex = rowIndex;
                chkStatus.Checked = product.Status;
                pcImage.Image = new Bitmap(product.Image);
                txtImage.Text = product.Image;
                pcImage.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                this.Text = "Add New Product";
                //btnUpdate.Enabled = false;
                btnUpdate.Hide();

            }

        }
        private void LoadData()
        {
            dtCategory = categoryBUS.GetDataTableCategory();
            cbCategory.DataSource = dtCategory;
            cbCategory.DisplayMember = "Name";
        }
        private void frm_MaintainProduct_Load(object sender, EventArgs e)
        {


        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.' && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }


        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image file(*.jpg;*.png;*.jpeg;*.bmp;)|*.jpg;*.png;*.jpeg;*.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtImage.Text = open.FileName;
                pcImage.Image = new Bitmap(open.FileName);
            }
        }
        private bool ValidData(bool insert)
        {
            if (txtTitle.TextLength == 0)
            {
                MessageBox.Show("Title must be required!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return false;
            }
            if (insert)
            {
                if (productBUS.IsExistsInsert(new ProductDTO { Title = txtTitle.Text }))
                {
                    MessageBox.Show("Title was exists!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTitle.Focus();
                    return false;
                }
            }
            else
            {
                if (productBUS.IsExistsUpdate(new ProductDTO { ID = product.ID, Title = txtTitle.Text }))
                {
                    MessageBox.Show("Title was exists!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTitle.Focus();
                    return false;
                }
            }
           
            if (txtDescription.TextLength == 0)
            {
                MessageBox.Show("Description must be required!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescription.Focus();
                return false;
            }
            
            if (txtPrice.TextLength == 0)
            {
                MessageBox.Show("Price must be required!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return false;
            }
            if (txtQuantity.TextLength == 0)
            {
                MessageBox.Show("Quantity must be required!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return false;
            }
            if (txtImage.TextLength == 0)
            {
                MessageBox.Show("Image must be required!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtImage.Focus();
                return false;
            }


            return true;
        }
        private ProductDTO GetProductFromForm()
        {
            if (product == null)
            {
                product = new ProductDTO();
            }
            product.Title = txtTitle.Text;
            product.Description = txtDescription.Text;
            product.Price = float.Parse(txtPrice.Text);
            product.Quantity = int.Parse(txtQuantity.Text);
            product.Image = txtImage.Text;
            product.Status = chkStatus.Checked;
            int index = cbCategory.SelectedIndex;
            product.Category = new CategoryDTO { ID = int.Parse(dtCategory.Rows[index]["ID"].ToString()) };
            return product;
        }
        private void CopyImage()
        {
            string sourceImage = txtImage.Text;
            string destFile = System.IO.Path.Combine(targetImagePath, Path.GetFileName(sourceImage));
            if (!File.Exists(destFile))
            {
                File.Copy(sourceImage, destFile);
            }
            //MessageBox.Show(
            //    sourceImage.Substring(sourceImage.LastIndexOf('\\')));
        }
           
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidData(true))
            {
                if (productBUS.InsertProduct(GetProductFromForm()))
                {
                    MessageBox.Show("Add product was successfull!", "Insert Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CopyImage();
                }
                else
                {
                    MessageBox.Show("Add product was fail!", "Insert Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidData(false))
            {
                if (productBUS.UpdateProduct(GetProductFromForm()))
                {
                    MessageBox.Show("Update product was successfull!","Update Status",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CopyImage();
                }
                else
                {
                    MessageBox.Show("Update product was fail!", "Update Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
