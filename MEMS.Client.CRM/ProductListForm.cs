﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using MEMS.Client.CRM.CRMService;
using MEMS.DB.Models;
using MEMS.DB.ExtModels;

namespace MEMS.Client.CRM
{
    public partial class ProductListForm : MEMS.Client.Common.BaseListForm
    {
        public ProductListForm()
        {
            InitializeComponent();
        }
        protected override void SearchObject()
        {
            var procode = txtprocode.Text;
            var proname = txtproname.Text;

            var customerlst = new List<int>();
            //foreach (CheckedListBoxItem item in checkedComboBoxEdit1.Properties.Items)
            //{
            //    if (item.CheckState==CheckState.Checked)
            //    {
            //        customerlst.Add((int)item.Value);
            //    }
            //}
            var checkitems = cmbcustomerlst.Properties.GetCheckedItems().ToString();
            var cidlst = checkitems.Split(new char[] { ',' });
            foreach (var cid in cidlst)
            {
                customerlst.Add(Convert.ToInt32(cid));
            }
            CRMServiceClient client = new CRMServiceClient();
            List<ProductList> plst = client.getProductListbycdt(procode,proname,customerlst);
            gcproduct.DataSource = plst;
        }
        protected override void AddObject()
        {
            var frm = new ProductinfoForm(Common.frmmodetype.add);
            refreshFormData(frm);
        }
        protected override void EditObject()
        {
            if (this.gvproduct.DataRowCount > 0)
            {
                int idx = (int)gvproduct.GetFocusedRowCellValue("id");
                var frm = new ProductinfoForm(Common.frmmodetype.edit, idx);
                refreshFormData(frm);
            }
        }
        protected override void DeleteObject()
        {
            if (this.gvproduct.DataRowCount > 0)
            {
                int idx = (int)gvproduct.GetFocusedRowCellValue("id");
                var frm = new ProductinfoForm(Common.frmmodetype.delete, idx);
                refreshFormData(frm);
            }
        }

        private void gvproduct_DoubleClick(object sender, EventArgs e)
        {
            EditObject();
        }

        protected override void FormLoad()
        {
            base.FormLoad();
            CRMServiceClient client = new CRMServiceClient();
            var customerlst = client.getCustomerList();
            //foreach (var customer in customerlst)
            //{
            //    cmbcustomer.Properties.Items.Add(customer.customername);
            //}
            cmbcustomerlst.Properties.DataSource = customerlst;
            cmbcustomerlst.Properties.DisplayMember = "customername";
            cmbcustomerlst.Properties.ValueMember = "id";
            cmbcustomerlst.Properties.SelectAllItemCaption = "选择全部";
            foreach (CheckedListBoxItem item in cmbcustomerlst.Properties.GetItems())
            {
                item.CheckState = CheckState.Checked;

            }
            base.barbtn1.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            base.barbtn1.LargeImageIndex = 17;
            barbtn1.Caption = "产品报价";
        }
        protected override void custom1()
        {
            if (gvproduct.DataRowCount > 0)
            {
                int pid = (int)gvproduct.GetFocusedRowCellValue("id");
                var frm = new ProductPriceForm(pid);
                frm.StartPosition = FormStartPosition.CenterParent;
                refreshFormData(frm);
            }
        }
    }
}
