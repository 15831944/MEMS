﻿namespace MEMS.Client.Sale
{
    partial class SaleOrderListForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.gcSaleOrder = new DevExpress.XtraGrid.GridControl();
            this.gvSaleOrder = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkupOrderState = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cmborderstate = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSaleNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).BeginInit();
            this.searchgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSaleOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSaleOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupOrderState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmborderstate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // searchgroup
            // 
            this.searchgroup.Controls.Add(this.labelControl4);
            this.searchgroup.Controls.Add(this.dateEdit2);
            this.searchgroup.Controls.Add(this.dateEdit1);
            this.searchgroup.Controls.Add(this.labelControl2);
            this.searchgroup.Controls.Add(this.txtSaleNo);
            this.searchgroup.Controls.Add(this.labelControl1);
            this.searchgroup.Size = new System.Drawing.Size(805, 100);
            this.searchgroup.Controls.SetChildIndex(this.labelControl1, 0);
            this.searchgroup.Controls.SetChildIndex(this.txtSaleNo, 0);
            this.searchgroup.Controls.SetChildIndex(this.labelControl2, 0);
            this.searchgroup.Controls.SetChildIndex(this.dateEdit1, 0);
            this.searchgroup.Controls.SetChildIndex(this.dateEdit2, 0);
            this.searchgroup.Controls.SetChildIndex(this.labelControl4, 0);
            // 
            // ribboncontrol
            // 
            this.ribboncontrol.ExpandCollapseItem.Id = 0;
            this.ribboncontrol.Size = new System.Drawing.Size(805, 125);
            this.ribboncontrol.Toolbar.ShowCustomizeItem = false;
            // 
            // gcSaleOrder
            // 
            this.gcSaleOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcSaleOrder.Location = new System.Drawing.Point(0, 225);
            this.gcSaleOrder.MainView = this.gvSaleOrder;
            this.gcSaleOrder.MenuManager = this.ribboncontrol;
            this.gcSaleOrder.Name = "gcSaleOrder";
            this.gcSaleOrder.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmborderstate,
            this.lkupOrderState});
            this.gcSaleOrder.Size = new System.Drawing.Size(805, 258);
            this.gcSaleOrder.TabIndex = 3;
            this.gcSaleOrder.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSaleOrder});
            // 
            // gvSaleOrder
            // 
            this.gvSaleOrder.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn10,
            this.gridColumn9,
            this.gridColumn4,
            this.gridColumn8,
            this.gridColumn5,
            this.gridColumn6});
            this.gvSaleOrder.GridControl = this.gcSaleOrder;
            this.gvSaleOrder.Name = "gvSaleOrder";
            this.gvSaleOrder.OptionsBehavior.Editable = false;
            this.gvSaleOrder.OptionsView.ShowGroupPanel = false;
            this.gvSaleOrder.OptionsView.ShowViewCaption = true;
            this.gvSaleOrder.ViewCaption = "销售单列表";
            this.gvSaleOrder.DoubleClick += new System.EventHandler(this.gvSaleOrder_DoubleClick);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "id";
            this.gridColumn1.FieldName = "so.id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "销售单号";
            this.gridColumn2.FieldName = "so.saleno";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "销售日期";
            this.gridColumn3.FieldName = "so.saledate";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "gridColumn10";
            this.gridColumn10.FieldName = "so.customerid";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "客户名称";
            this.gridColumn9.FieldName = "customername";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "报价单id";
            this.gridColumn4.FieldName = "so.quotationid";
            this.gridColumn4.Name = "gridColumn4";
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "报价单号";
            this.gridColumn8.FieldName = "qtno";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "订单金额";
            this.gridColumn5.FieldName = "so.saletotalamount";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "订单状态";
            this.gridColumn6.ColumnEdit = this.lkupOrderState;
            this.gridColumn6.FieldName = "so.orderstate";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // lkupOrderState
            // 
            this.lkupOrderState.AutoHeight = false;
            this.lkupOrderState.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkupOrderState.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("value", "Name1"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("key", "Name2", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.lkupOrderState.Name = "lkupOrderState";
            // 
            // cmborderstate
            // 
            this.cmborderstate.AutoHeight = false;
            this.cmborderstate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmborderstate.Name = "cmborderstate";
            this.cmborderstate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(266, 66);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(12, 14);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "—";
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(284, 63);
            this.dateEdit2.MenuManager = this.ribboncontrol;
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.dateEdit2.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dateEdit2.Size = new System.Drawing.Size(114, 22);
            this.dateEdit2.TabIndex = 15;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(145, 63);
            this.dateEdit1.MenuManager = this.ribboncontrol;
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.dateEdit1.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dateEdit1.Size = new System.Drawing.Size(114, 22);
            this.dateEdit1.TabIndex = 12;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(82, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "销售日期";
            // 
            // txtSaleNo
            // 
            this.txtSaleNo.Location = new System.Drawing.Point(145, 32);
            this.txtSaleNo.MenuManager = this.ribboncontrol;
            this.txtSaleNo.Name = "txtSaleNo";
            this.txtSaleNo.Size = new System.Drawing.Size(253, 22);
            this.txtSaleNo.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(82, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "销售单号";
            // 
            // SaleOrderListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.ClientSize = new System.Drawing.Size(805, 483);
            this.Controls.Add(this.gcSaleOrder);
            this.Name = "SaleOrderListForm";
            this.Text = "销售订单";
            this.Controls.SetChildIndex(this.ribboncontrol, 0);
            this.Controls.SetChildIndex(this.searchgroup, 0);
            this.Controls.SetChildIndex(this.gcSaleOrder, 0);
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).EndInit();
            this.searchgroup.ResumeLayout(false);
            this.searchgroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSaleOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSaleOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkupOrderState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmborderstate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSaleNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcSaleOrder;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSaleOrder;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox cmborderstate;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkupOrderState;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtSaleNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
    }
}
