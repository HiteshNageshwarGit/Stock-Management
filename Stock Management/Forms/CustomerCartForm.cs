using Stock_Management.Shared;
using StockEntity.EntityX;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class CustomerCartForm : BaseForm
    {
        private CustomerCartDetailForm customerBillBreakListForm = new CustomerCartDetailForm();
        public CustomerCartForm()
        {
            InitializeComponent();

            dgvProductList.AutoGenerateColumns = false;
            ColAddToCart.UseColumnTextForButtonValue = true;
            SetDataGridViewProperties(dgvProductList);
            ShowFormInPanel(this, pnlCustomerBillBreakup, customerBillBreakListForm);
        }

        private void SellForm_Load(object sender, System.EventArgs e)
        {

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F))
            {
                customerBillBreakListForm.OpenPersonFindForm();
                return true;
            }
            else if (keyData == (Keys.Control | Keys.S))
            {
                customerBillBreakListForm.FinalizeCustomerBill();
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void SellForm_Shown(object sender, System.EventArgs e)
        {
            LoadProductListWithPrice();
        }

        private void txtProductName_KeyUp(object sender, KeyEventArgs e)
        {
            LoadProductListWithPrice();
        }

        private void dgvProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                return;
            }

            if (dgvProductList.Columns[e.ColumnIndex].Name == ColAddToCart.Name)
            {
                ProductInCart selectedProduct = (ProductInCart)dgvProductList.Rows[e.RowIndex].DataBoundItem;
                customerBillBreakListForm.AddProductToCart(selectedProduct.ShallowCopy());
            }
        }

        private void LoadProductListWithPrice()
        {
            List<ProductInCart> list = SharedRepo.DBRepo.GetProductListForSelling(txtProductName.Text.Trim());
            dgvProductList.DataSource = list;
            dgvProductList.ClearSelection();
        }

        internal void OnCustomerBillingFinish()
        {
            LoadProductListWithPrice();
            customerBillBreakListForm = new CustomerCartDetailForm();
            ShowFormInPanel(this, pnlCustomerBillBreakup, customerBillBreakListForm);
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvProductList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView_Selected_Cell_CellFormatting(sender, e);
        }
    }
}
