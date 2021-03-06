﻿namespace MEMS.Client.Common
{
    partial class BaseListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseListForm));
            this.ribboncontrol = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barClose = new DevExpress.XtraBars.BarButtonItem();
            this.barsearchCheck = new DevExpress.XtraBars.BarCheckItem();
            this.barbtn1 = new DevExpress.XtraBars.BarButtonItem();
            this.barbtn2 = new DevExpress.XtraBars.BarButtonItem();
            this.barbtn3 = new DevExpress.XtraBars.BarButtonItem();
            this.barbtn4 = new DevExpress.XtraBars.BarButtonItem();
            this.barbtn5 = new DevExpress.XtraBars.BarButtonItem();
            this.barbtn6 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonImageCollectionLarge = new DevExpress.Utils.ImageCollection();
            this.ribbonMenu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.searchgroup = new DevExpress.XtraEditors.GroupControl();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection();
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).BeginInit();
            this.searchgroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribboncontrol
            // 
            this.ribboncontrol.ExpandCollapseItem.Id = 0;
            this.ribboncontrol.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribboncontrol.ExpandCollapseItem,
            this.barAdd,
            this.barEdit,
            this.barDelete,
            this.barClose,
            this.barsearchCheck,
            this.barbtn1,
            this.barbtn2,
            this.barbtn3,
            this.barbtn4,
            this.barbtn5,
            this.barbtn6});
            this.ribboncontrol.LargeImages = this.ribbonImageCollectionLarge;
            this.ribboncontrol.Location = new System.Drawing.Point(0, 0);
            this.ribboncontrol.MaxItemId = 13;
            this.ribboncontrol.Name = "ribboncontrol";
            this.ribboncontrol.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonMenu});
            this.ribboncontrol.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribboncontrol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ribboncontrol.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribboncontrol.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribboncontrol.ShowToolbarCustomizeItem = false;
            this.ribboncontrol.Size = new System.Drawing.Size(717, 125);
            this.ribboncontrol.Toolbar.ShowCustomizeItem = false;
            this.ribboncontrol.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barAdd
            // 
            this.barAdd.Caption = "添加";
            this.barAdd.Id = 1;
            this.barAdd.LargeImageIndex = 15;
            this.barAdd.Name = "barAdd";
            this.barAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barAdd_ItemClick);
            // 
            // barEdit
            // 
            this.barEdit.Caption = "修改";
            this.barEdit.Id = 2;
            this.barEdit.LargeImageIndex = 13;
            this.barEdit.Name = "barEdit";
            this.barEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barEdit_ItemClick);
            // 
            // barDelete
            // 
            this.barDelete.Caption = "删除";
            this.barDelete.Id = 3;
            this.barDelete.LargeImageIndex = 16;
            this.barDelete.Name = "barDelete";
            this.barDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDelete_ItemClick);
            // 
            // barClose
            // 
            this.barClose.Caption = "关闭";
            this.barClose.Id = 5;
            this.barClose.LargeImageIndex = 6;
            this.barClose.Name = "barClose";
            this.barClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barClose_ItemClick);
            // 
            // barsearchCheck
            // 
            this.barsearchCheck.Caption = "查询";
            this.barsearchCheck.Id = 6;
            this.barsearchCheck.LargeImageIndex = 3;
            this.barsearchCheck.Name = "barsearchCheck";
            this.barsearchCheck.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barsearchCheck_CheckedChanged);
            // 
            // barbtn1
            // 
            this.barbtn1.Caption = "自定义";
            this.barbtn1.Id = 7;
            this.barbtn1.LargeImageIndex = 0;
            this.barbtn1.Name = "barbtn1";
            this.barbtn1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barbtn1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn1_ItemClick);
            // 
            // barbtn2
            // 
            this.barbtn2.Caption = "自定义";
            this.barbtn2.Id = 8;
            this.barbtn2.LargeImageIndex = 0;
            this.barbtn2.Name = "barbtn2";
            this.barbtn2.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barbtn2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn2_ItemClick);
            // 
            // barbtn3
            // 
            this.barbtn3.Caption = "自定义";
            this.barbtn3.Id = 9;
            this.barbtn3.LargeImageIndex = 0;
            this.barbtn3.Name = "barbtn3";
            this.barbtn3.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barbtn3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn3_ItemClick);
            // 
            // barbtn4
            // 
            this.barbtn4.Caption = "自定义";
            this.barbtn4.Glyph = ((System.Drawing.Image)(resources.GetObject("barbtn4.Glyph")));
            this.barbtn4.Id = 10;
            this.barbtn4.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barbtn4.LargeGlyph")));
            this.barbtn4.Name = "barbtn4";
            this.barbtn4.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barbtn4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn4_ItemClick);
            // 
            // barbtn5
            // 
            this.barbtn5.Caption = "自定义";
            this.barbtn5.Glyph = ((System.Drawing.Image)(resources.GetObject("barbtn5.Glyph")));
            this.barbtn5.Id = 11;
            this.barbtn5.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barbtn5.LargeGlyph")));
            this.barbtn5.Name = "barbtn5";
            this.barbtn5.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barbtn5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn5_ItemClick);
            // 
            // barbtn6
            // 
            this.barbtn6.Caption = "自定义";
            this.barbtn6.Glyph = ((System.Drawing.Image)(resources.GetObject("barbtn6.Glyph")));
            this.barbtn6.Id = 12;
            this.barbtn6.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barbtn6.LargeGlyph")));
            this.barbtn6.Name = "barbtn6";
            this.barbtn6.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barbtn6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtn6_ItemClick);
            // 
            // ribbonImageCollectionLarge
            // 
            this.ribbonImageCollectionLarge.ImageSize = new System.Drawing.Size(32, 32);
            this.ribbonImageCollectionLarge.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("ribbonImageCollectionLarge.ImageStream")));
            this.ribbonImageCollectionLarge.Images.SetKeyName(0, "Ribbon_New_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(1, "Ribbon_Open_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(2, "Ribbon_Close_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(3, "Ribbon_Find_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(4, "Ribbon_Save_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(5, "Ribbon_SaveAs_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(6, "Ribbon_Exit_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(7, "Ribbon_Content_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(8, "Ribbon_Info_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(9, "BO_MyDetails_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(10, "Action_Security_ChangePassword_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(11, "BO_Employee_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(12, "Action_Delete_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(13, "Action_Edit_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(14, "Action_New_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(15, "Action_LinkUnlink_Link_32x32.png");
            this.ribbonImageCollectionLarge.Images.SetKeyName(16, "Action_LinkUnlink_Unlink_32x32.png");
            // 
            // ribbonMenu
            // 
            this.ribbonMenu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonMenu.Name = "ribbonMenu";
            this.ribbonMenu.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barAdd);
            this.ribbonPageGroup1.ItemLinks.Add(this.barEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.barDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.barsearchCheck);
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtn1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtn2);
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtn3);
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtn4);
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtn5);
            this.ribbonPageGroup1.ItemLinks.Add(this.barbtn6);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "基本操作";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barClose);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "退出";
            // 
            // searchgroup
            // 
            this.searchgroup.Controls.Add(this.searchButton);
            this.searchgroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchgroup.Location = new System.Drawing.Point(0, 125);
            this.searchgroup.Name = "searchgroup";
            this.searchgroup.Size = new System.Drawing.Size(717, 100);
            this.searchgroup.TabIndex = 1;
            this.searchgroup.Text = "查询条件";
            // 
            // searchButton
            // 
            this.searchButton.ImageIndex = 3;
            this.searchButton.ImageList = this.ribbonImageCollectionLarge;
            this.searchButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.searchButton.Location = new System.Drawing.Point(12, 29);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(49, 60);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "检索";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "Ribbon_New_32x32.png");
            this.imageCollection1.Images.SetKeyName(1, "Ribbon_Open_32x32.png");
            this.imageCollection1.Images.SetKeyName(2, "Ribbon_Close_32x32.png");
            this.imageCollection1.Images.SetKeyName(3, "Ribbon_Find_32x32.png");
            this.imageCollection1.Images.SetKeyName(4, "Ribbon_Save_32x32.png");
            this.imageCollection1.Images.SetKeyName(5, "Ribbon_SaveAs_32x32.png");
            this.imageCollection1.Images.SetKeyName(6, "Ribbon_Exit_32x32.png");
            this.imageCollection1.Images.SetKeyName(7, "Ribbon_Content_32x32.png");
            this.imageCollection1.Images.SetKeyName(8, "Ribbon_Info_32x32.png");
            this.imageCollection1.Images.SetKeyName(9, "BO_MyDetails_32x32.png");
            this.imageCollection1.Images.SetKeyName(10, "Action_Security_ChangePassword_32x32.png");
            this.imageCollection1.Images.SetKeyName(11, "BO_Employee_32x32.png");
            this.imageCollection1.Images.SetKeyName(12, "Action_Delete_32x32.png");
            this.imageCollection1.Images.SetKeyName(13, "Action_Edit_32x32.png");
            this.imageCollection1.Images.SetKeyName(14, "Action_New_32x32.png");
            this.imageCollection1.Images.SetKeyName(15, "Action_LinkUnlink_Link_32x32.png");
            this.imageCollection1.Images.SetKeyName(16, "Action_LinkUnlink_Unlink_32x32.png");
            // 
            // BaseListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 391);
            this.Controls.Add(this.searchgroup);
            this.Controls.Add(this.ribboncontrol);
            this.Name = "BaseListForm";
            this.Ribbon = this.ribboncontrol;
            this.Text = "BaseListForm";
            this.Load += new System.EventHandler(this.BaseListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribboncontrol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonImageCollectionLarge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchgroup)).EndInit();
            this.searchgroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        internal DevExpress.Utils.ImageCollection ribbonImageCollectionLarge;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        protected DevExpress.XtraEditors.GroupControl searchgroup;
        public DevExpress.XtraBars.Ribbon.RibbonControl ribboncontrol;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribbonMenu;
        internal DevExpress.Utils.ImageCollection imageCollection1;
        protected internal DevExpress.XtraBars.BarButtonItem barAdd;
        protected internal DevExpress.XtraBars.BarButtonItem barEdit;
        protected internal DevExpress.XtraBars.BarButtonItem barDelete;
        protected internal DevExpress.XtraBars.BarButtonItem barClose;
        protected internal DevExpress.XtraBars.BarCheckItem barsearchCheck;
        protected internal DevExpress.XtraBars.BarButtonItem barbtn1;
        protected internal DevExpress.XtraBars.BarButtonItem barbtn2;
        protected internal DevExpress.XtraBars.BarButtonItem barbtn3;
        protected internal DevExpress.XtraBars.BarButtonItem barbtn4;
        protected internal DevExpress.XtraBars.BarButtonItem barbtn5;
        protected internal DevExpress.XtraBars.BarButtonItem barbtn6;
    }
}