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
            else if (CallerForm.Name == "BillDetailListForm")
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
                product = Session.ProductRepository.GetByID(ProductId);
                if (product == null)
                {
                    MessageBox.Show("Product not found");
                    EnableControls(false);
                    //Close();
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
            product.Name = txtName.Text;
            product.Code = txtCode.Text;
            product.Color = txtColor.Text;
            product.Remarks = txtRemarks.Text;

            product.ValidateProduct();
            if (product.EntityState.State == ValidationState.SUCCESS)
            {
                Session.ProductRepository.Save(product);
                Close();
            }
            else
            {
                MessageBox.Show(product.EntityState.StateMessage, "Error");
            }
        }
    }
}
