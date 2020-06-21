using Stock_Management.Forms;
using StockEntity;
using StockEntity.Entity;
using StockEntity.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management
{
    public partial class MainForm : Form
    {

        DealerListForm dealerListForm;
        BillListForm billListForm;
        public MainForm()
        {
            InitializeComponent();


            //  //SqliteConnection dd = new SqliteConnection("Data Source = StockDB.sqlite;");
            //  //dd.Open();
            //  //dd.Close();

            //  using (var context = new StockDBContext())
            //  {

            //      context.ProductMasters.Add(new ProductMaster() { Id = 1, Name = "fsdfasf" });
            //      //var police = context.Artists.Single(a => a.Name == "The Police");
            //      //police.Name = "Police, The";

            //      //var avril = context.Artists.Single(a => a.Name == "Avril Lavigne");
            //      //context.Artists.Remove(avril);

            //      context.SaveChanges();
            //      var ddd = context.ProductMasters.ToList();
            //  }
            //  //StockDBContext.RunExample();

            //  //UnitOfWork unitOfWork = new UnitOfWork();
            //  //unitOfWork.ProductMasters.Insert(new ProductMaster() { Id = 1, Name = "Prod1" });
            //  //unitOfWork.Commit();
            ////  var fsdf = unitOfWork.ProductMasters
            ///
            //ProductRepository repo = new ProductRepository();
            //repo.Insert(new ProductMaster() { Id = 1, Name = "This shoyuld work" });
            //var dddddd = repo.GetByID(3);

        }

        private void dealersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void dealerListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dealerListForm == null || dealerListForm.IsDisposed)
            {
                dealerListForm = new DealerListForm();
            }
            OpenForm(dealerListForm);
        }

        private void billListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (billListForm == null || billListForm.IsDisposed)
            {
                billListForm = new BillListForm();
            }
            OpenForm(billListForm);
        }


        //private void OpenDealerListForm()
        //{
        //    if (dealerListForm == null)
        //    {
        //        dealerListForm = new DealerListForm();
        //    }
        //    OpenForm(dealerListForm);


        //    //if (dealerListForm != null)
        //    //{
        //    //    dealerListForm.Close();
        //    //    dealerListForm.Dispose();
        //    //}
        //    //this.IsMdiContainer = true;
        //    //dealerListForm = new DealerListForm();
        //    //dealerListForm.MdiParent = this;
        //    //dealerListForm.FormBorderStyle = FormBorderStyle.None;
        //    //dealerListForm.WindowState = FormWindowState.Maximized;
        //    //dealerListForm.Dock = DockStyle.Fill;
        //    //dealerListForm.Show();
        //}






        //private void OpenBillListForm()
        //{
        //    this.IsMdiContainer = true;
        //    BillListForm dealerListForm = new BillListForm();
        //    dealerListForm.MdiParent = this;
        //    dealerListForm.Show();
        //}

        private void OpenForm(Form form)
        {
            FormCollection fc = Application.OpenForms;
            if (fc != null && fc.Count > 0)
            {
                foreach (Form frm in fc)
                {
                    if (frm.Name != "MainForm" && frm.Name != form.Name)
                    {
                        //frm.Close();
                        //frm.Dispose();
                        frm.Hide();
                        break;
                    }
                }
            }

            IsMdiContainer = true;
            form.MdiParent = this;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Normal;
            form.Dock = DockStyle.Fill;
            form.Show();
            form.Focus();
        }

    }
}
