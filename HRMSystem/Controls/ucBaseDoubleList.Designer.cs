﻿namespace HRMSystem.Controls
{
    partial class ucBaseDoubleList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.grdData = new DevExpress.XtraGrid.GridControl();
            this.grvData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnLoad = new DevExpress.XtraBars.BarButtonItem();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnExport = new DevExpress.XtraBars.BarButtonItem();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcTitle = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.grdData);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.standaloneBarDockControl1);
            this.layoutControl1.Controls.Add(this.lblTitle);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(944, 549);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // grdData
            // 
            this.grdData.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.grdData.Location = new System.Drawing.Point(12, 75);
            this.grdData.MainView = this.grvData;
            this.grdData.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grdData.Name = "grdData";
            this.grdData.Size = new System.Drawing.Size(920, 212);
            this.grdData.TabIndex = 10;
            this.grdData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvData});
            this.grdData.FocusedViewChanged += new DevExpress.XtraGrid.ViewFocusEventHandler(this.grdData_FocusedViewChanged);
            this.grdData.DoubleClick += new System.EventHandler(this.grdData_DoubleClick);
            // 
            // grvData
            // 
            this.grvData.DetailHeight = 284;
            this.grvData.GridControl = this.grdData;
            this.grvData.Name = "grvData";
            this.grvData.OptionsEditForm.PopupEditFormWidth = 600;
            this.grvData.OptionsFind.AlwaysVisible = true;
            this.grvData.OptionsFind.FindDelay = 100;
            this.grvData.OptionsFind.FindNullPrompt = "Nhập nội dung muốn tìm kiếm ....";
            this.grvData.OptionsView.ShowGroupPanel = false;
            this.grvData.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.grvData_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.gridControl1.Location = new System.Drawing.Point(12, 291);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(920, 202);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsEditForm.PopupEditFormWidth = 600;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindDelay = 100;
            this.gridView1.OptionsFind.FindNullPrompt = "Nhập nội dung muốn tìm kiếm ....";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(12, 47);
            this.standaloneBarDockControl1.Manager = this.barManager1;
            this.standaloneBarDockControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(920, 24);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnLoad,
            this.btnEdit,
            this.btnDelete,
            this.btnExport});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Standalone;
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar2.FloatLocation = new System.Drawing.Point(109, 224);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLoad),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete)});
            this.bar2.OptionsBar.DrawBorder = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.StandaloneBarDockControl = this.standaloneBarDockControl1;
            this.bar2.Text = "Main menu";
            // 
            // btnLoad
            // 
            this.btnLoad.Caption = "Tải dữ liệu";
            this.btnLoad.Id = 1;
            this.btnLoad.ImageOptions.SvgImage = global::HRMSystem.Properties.Resources.SyncBadge12;
            this.btnLoad.Name = "btnLoad";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.SvgImage = global::HRMSystem.Properties.Resources.Add1;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Sửa";
            this.btnEdit.Id = 2;
            this.btnEdit.ImageOptions.SvgImage = global::HRMSystem.Properties.Resources.Edit;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.Id = 3;
            this.btnDelete.ImageOptions.SvgImage = global::HRMSystem.Properties.Resources.Cancel;
            this.btnDelete.Name = "btnDelete";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlTop.Size = new System.Drawing.Size(944, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 549);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlBottom.Size = new System.Drawing.Size(944, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 549);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(944, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 549);
            // 
            // btnExport
            // 
            this.btnExport.Caption = "Xuất dữ liệu";
            this.btnExport.Id = 4;
            this.btnExport.ImageOptions.Image = global::HRMSystem.Properties.Resources.excel18;
            this.btnExport.Name = "btnExport";
            // 
            // lblTitle
            // 
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(80, 27);
            this.lblTitle.StyleController = this.layoutControl1;
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Tiêu đề";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcTitle,
            this.emptySpaceItem2,
            this.simpleSeparator1,
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(944, 549);
            this.Root.TextVisible = false;
            // 
            // lcTitle
            // 
            this.lcTitle.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lcTitle.AppearanceItemCaption.Options.UseFont = true;
            this.lcTitle.Control = this.lblTitle;
            this.lcTitle.Location = new System.Drawing.Point(0, 0);
            this.lcTitle.Name = "lcTitle";
            this.lcTitle.Size = new System.Drawing.Size(924, 31);
            this.lcTitle.TextSize = new System.Drawing.Size(0, 0);
            this.lcTitle.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 32);
            this.emptySpaceItem2.MaxSize = new System.Drawing.Size(7, 3);
            this.emptySpaceItem2.MinSize = new System.Drawing.Size(7, 3);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(924, 3);
            this.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 31);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(924, 1);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.standaloneBarDockControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 35);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(924, 28);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 485);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(924, 44);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 279);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(924, 206);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.grdData;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 63);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(924, 216);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // ucBaseDoubleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ucBaseDoubleList";
            this.Size = new System.Drawing.Size(944, 549);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraLayout.LayoutControlItem lcTitle;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnLoad;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnExport;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.GridControl grdData;
        private DevExpress.XtraGrid.Views.Grid.GridView grvData;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
