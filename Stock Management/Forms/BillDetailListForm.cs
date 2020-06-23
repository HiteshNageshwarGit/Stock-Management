﻿using StockEntity.Entity;
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

namespace Stock_Management.Forms
{
    public partial class BillDetailListForm : Form
    {

        public Form CallerForm { get; set; }
        public Bill Bill = new Bill();
        BillDetailRepository billDetailRepo = new BillDetailRepository();
        List<BillDetail> billDetailsList;
        BillDetail selectedBillDetail = new BillDetail();
        public BillDetailListForm()
        {
            InitializeComponent();

            loadBillDetailList();
        }

        private void loadBillDetailList()
        {
            billDetailsList = billDetailRepo.GetBillDetailList(Bill.Id);
            dgvBillDetailList.DataSource = billDetailsList;
        }
    }
}
