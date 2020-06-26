using Stock_Management.Forms;
using Stock_Management.Shared;
using System;

namespace Stock_Management
{
    public partial class MainForm : BaseForm
    {

        DealerListForm dealerListForm;
        ProductListForm productListForm;
        public MainForm()
        {
            InitializeComponent();
            Session.InitializeSession();
        }

        private void dealerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dealerListForm == null || dealerListForm.IsDisposed)
            {
                dealerListForm = new DealerListForm();
            }
            ShowFormAsMDIChild(this, dealerListForm);
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (productListForm == null || productListForm.IsDisposed)
            {
                productListForm = new ProductListForm();
            }
            ShowFormAsMDIChild(this, productListForm);
        }
    }
}
