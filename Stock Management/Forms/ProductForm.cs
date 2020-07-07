using Stock_Management.Shared;
using StockEntity.Entity;
using StockEntity.Helper;
using System;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class ProductForm : BaseForm
    {
        Product product;
        public int ProductId;
        public ProductForm()
        {
            InitializeComponent();
            //this.EnumerateChildren();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            EditProduct();
        }

        private void ProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CallerForm == null)
            {
                return;
            }
            else if (CallerForm.Name == "ReportForm")
            {

            }
            else if (CallerForm.Name == "BillBreakupListForm")
            {

            }
            else if (CallerForm.Name == "ProductListForm")
            {
                ((ProductListForm)CallerForm).LoadProductList();
            }
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            SaveProduct();
        }

        private void EnableControls(bool enalble)
        {
            btnSaveProduct.Enabled = enalble;
        }
        private void EditProduct()
        {
            if (ProductId == 0)
            {
                product = new Product();
            }
            else
            {
                product = SharedRepo.ProductRepo.GetByID(ProductId);
                if (product == null)
                {
                    MessageBox.Show("Product not found");
                    EnableControls(false);
                }
                else
                {
                    txtName.Text = product.Name;
                    txtCode.Text = product.Code;
                    txtColor.Text = product.Color;
                    txtRemarks.Text = product.Remarks;
                }
            }
        }

        private void SaveProduct()
        {
            product.ResetValidationError();
            product.Name = txtName.Text.Trim();
            product.Code = txtCode.Text.Trim();
            product.Color = txtColor.Text.Trim();
            product.Remarks = txtRemarks.Text.Trim();

            product.ValidateProduct();
            if (product.EntityState.State != ValidationState.SUCCESS)
            {
                MessageBox.Show(product.EntityState.StateMessage, "Error");
                return;
            }
            if (SharedRepo.ProductRepo.DoesProductNameExists(product))
            {
                MessageBox.Show("Product name already exists", "Error");
                return;
            }
            SharedRepo.ProductRepo.Save(product);
            Close();
        }
    }
}
