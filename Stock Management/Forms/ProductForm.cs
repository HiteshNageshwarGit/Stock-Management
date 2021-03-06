﻿using Stock_Management.Shared;
using StockEntity.Entity;
using StockEntity.Helper;
using System;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class ProductForm : BaseForm
    {
        private Product product;
        private int _productId;
        public ProductForm(int productId)
        {
            InitializeComponent();
            _productId = productId;
            PrepareTooltips(this);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                SaveProduct();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            EditProduct();
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            ToTitleCase(txtName);
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            SaveProduct();
        }

        private void EditProduct()
        {
            if (_productId == 0)
            {
                SetFormBehaviour(CRUD_OP_ADD);
                product = new Product();
            }
            else
            {
                product = SharedRepo.DBRepo.GetProductByID(_productId);
                if (product == null)
                {
                    MessageBox.Show("Product not found");
                    SetFormBehaviour(CRUD_OP_VIEW);
                }
                else
                {
                    SetFormBehaviour(CRUD_OP_VIEW);
                    txtName.Text = product.Name;
                    numLowerLimit.Value = product.LowerLimit;
                    numUpperLimit.Value = product.UpperLimit;
                    txtRemarks.Text = product.Remarks;
                }
            }
        }

        private void SaveProduct()
        {
            if (btnSaveProduct.Text == CRUD_OP_EDIT)
            {
                SetFormBehaviour(CRUD_OP_EDIT);
                return;
            }

            product.ResetValidationError();
            product.Name = txtName.Text.Trim();
            product.LowerLimit = (int)numLowerLimit.Value;
            product.UpperLimit = (int)numUpperLimit.Value;
            product.Remarks = txtRemarks.Text.Trim();

            product.ValidateProduct();
            if (product.EntityState.State != ValidationState.SUCCESS)
            {
                MessageBox.Show(product.EntityState.StateMessage, "Error");
                return;
            }
            if (SharedRepo.DBRepo.DoesProductNameExists(product))
            {
                MessageBox.Show("Product name already exists", "Error");
                return;
            }
            SharedRepo.DBRepo.SaveProduct(product);
            if (CallerForm == null || CallerForm.Name == null)
            {
                return;
            }
            else if (CallerForm.Name == "ProductListForm")
            {
                ((ProductListForm)CallerForm).LoadProductList();
            }
            Close();
        }

        private void EnableControls(bool enalbleInputs)
        {
            txtName.Enabled = enalbleInputs;
            numLowerLimit.Enabled = enalbleInputs;
            numUpperLimit.Enabled = enalbleInputs;
            txtRemarks.Enabled = enalbleInputs;
        }

        private void SetFormBehaviour(string CRUD_OP)
        {
            switch (CRUD_OP)
            {
                case CRUD_OP_ADD:
                    Text = "Add Product";
                    EnableControls(true);
                    btnSaveProduct.Text = CRUD_OP_ADD;
                    break;
                case CRUD_OP_EDIT:
                    Text = "Edit Product";
                    EnableControls(true);
                    btnSaveProduct.Text = CRUD_OP_UPDATE;
                    break;
                case CRUD_OP_VIEW:
                    Text = "View Product";
                    EnableControls(false);
                    btnSaveProduct.Text = CRUD_OP_EDIT;
                    break;
            }
        }
    }
}
