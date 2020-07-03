using Stock_Management.Shared;
using StockEntity.EntityX;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Stock_Management.Forms
{
    public partial class SellForm : Form
    {
        public SellForm()
        {
            InitializeComponent();
            dgvProductList.AutoGenerateColumns = false;
            ColAdd.UseColumnTextForButtonValue = true;
            ColRemove.UseColumnTextForButtonValue = true;
            //Shared.SharedRepo.ProductRepo.GetProductListForSelling("p");
        }

        private void SellForm_Load(object sender, System.EventArgs e)
        {
           
        }

        public void LoadProductListWithPrice()
        {
            List<ProductWithPrice> list = SharedRepo.ProductRepo.GetProductListForSelling(txtProductName.Text.Trim());
            dgvProductList.DataSource = list;
            dgvProductList.ClearSelection();
        }

        private void SellForm_Shown(object sender, System.EventArgs e)
        {
            LoadProductListWithPrice();
        }

        private void txtProductName_KeyPress(object sender, KeyPressEventArgs e)
        {
            LoadProductListWithPrice();
        }
    }
}
