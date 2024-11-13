﻿namespace HRMSystem.Forms
{
    partial class frmEmployeeTranfer
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
            this.components = new System.ComponentModel.Container();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.txtDepartment = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.txtDepartmentView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtSoQD = new DevExpress.XtraEditors.TextEdit();
            this.cboEmployee = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.cboEmployeeView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnBack = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.txtHopDong = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.txtHopDongView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtBacLuong = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.txtBacLuongView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtChucVu = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.txtChucVuView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtStartDate = new DevExpress.XtraEditors.DateEdit();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoQD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEmployee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEmployeeView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHopDong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHopDongView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBacLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBacLuongView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChucVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChucVuView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(555, 354);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Thông tin chi tiết";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.txtStartDate);
            this.layoutControl1.Controls.Add(this.txtChucVu);
            this.layoutControl1.Controls.Add(this.txtBacLuong);
            this.layoutControl1.Controls.Add(this.txtHopDong);
            this.layoutControl1.Controls.Add(this.txtDepartment);
            this.layoutControl1.Controls.Add(this.txtSoQD);
            this.layoutControl1.Controls.Add(this.cboEmployee);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 23);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(551, 329);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(12, 126);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Properties.AdvancedModeOptions.Label = "Chọn phòng ban";
            this.txtDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDepartment.Properties.NullText = "";
            this.txtDepartment.Properties.PopupView = this.txtDepartmentView;
            this.txtDepartment.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtDepartment.Size = new System.Drawing.Size(527, 34);
            this.txtDepartment.StyleController = this.layoutControl1;
            this.txtDepartment.TabIndex = 11;
            // 
            // txtDepartmentView
            // 
            this.txtDepartmentView.DetailHeight = 227;
            this.txtDepartmentView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.txtDepartmentView.Name = "txtDepartmentView";
            this.txtDepartmentView.OptionsEditForm.PopupEditFormWidth = 533;
            this.txtDepartmentView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.txtDepartmentView.OptionsView.ShowGroupPanel = false;
            // 
            // txtSoQD
            // 
            this.txtSoQD.Location = new System.Drawing.Point(12, 50);
            this.txtSoQD.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoQD.Name = "txtSoQD";
            this.txtSoQD.Properties.AdvancedModeOptions.Label = "Số quyết định";
            this.txtSoQD.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtSoQD.Size = new System.Drawing.Size(527, 34);
            this.txtSoQD.StyleController = this.layoutControl1;
            this.txtSoQD.TabIndex = 5;
            // 
            // cboEmployee
            // 
            this.cboEmployee.Location = new System.Drawing.Point(12, 88);
            this.cboEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.cboEmployee.Name = "cboEmployee";
            this.cboEmployee.Properties.AdvancedModeOptions.Label = "Chọn Nhân viên";
            this.cboEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboEmployee.Properties.NullText = "";
            this.cboEmployee.Properties.PopupView = this.cboEmployeeView;
            this.cboEmployee.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.cboEmployee.Size = new System.Drawing.Size(527, 34);
            this.cboEmployee.StyleController = this.layoutControl1;
            this.cboEmployee.TabIndex = 8;
            // 
            // cboEmployeeView
            // 
            this.cboEmployeeView.DetailHeight = 227;
            this.cboEmployeeView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.cboEmployeeView.Name = "cboEmployeeView";
            this.cboEmployeeView.OptionsEditForm.PopupEditFormWidth = 533;
            this.cboEmployeeView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.cboEmployeeView.OptionsView.ShowGroupPanel = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(551, 329);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtSoQD;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 38);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(531, 38);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.cboEmployee;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 76);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(531, 38);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtDepartment;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 114);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(531, 38);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnSave,
            this.btnBack});
            this.barManager1.MaxItemId = 2;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBack)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.Id = 0;
            this.btnSave.ImageOptions.SvgImage = global::HRMSystem.Properties.Resources.save3;
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnBack
            // 
            this.btnBack.Caption = "Quay lại";
            this.btnBack.Id = 1;
            this.btnBack.ImageOptions.SvgImage = global::HRMSystem.Properties.Resources.ChromeBackMirrored1;
            this.btnBack.Name = "btnBack";
            this.btnBack.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBack_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlTop.Size = new System.Drawing.Size(555, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 354);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlBottom.Size = new System.Drawing.Size(555, 26);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 354);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(555, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 354);
            // 
            // txtHopDong
            // 
            this.txtHopDong.Location = new System.Drawing.Point(12, 164);
            this.txtHopDong.Margin = new System.Windows.Forms.Padding(2);
            this.txtHopDong.Name = "txtHopDong";
            this.txtHopDong.Properties.AdvancedModeOptions.Label = "Chọn hợp đồng";
            this.txtHopDong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHopDong.Properties.NullText = "";
            this.txtHopDong.Properties.PopupView = this.txtHopDongView;
            this.txtHopDong.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtHopDong.Size = new System.Drawing.Size(527, 34);
            this.txtHopDong.StyleController = this.layoutControl1;
            this.txtHopDong.TabIndex = 12;
            // 
            // txtHopDongView
            // 
            this.txtHopDongView.DetailHeight = 227;
            this.txtHopDongView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.txtHopDongView.Name = "txtHopDongView";
            this.txtHopDongView.OptionsEditForm.PopupEditFormWidth = 533;
            this.txtHopDongView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.txtHopDongView.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtHopDong;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 152);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(531, 38);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // txtBacLuong
            // 
            this.txtBacLuong.Location = new System.Drawing.Point(12, 202);
            this.txtBacLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtBacLuong.Name = "txtBacLuong";
            this.txtBacLuong.Properties.AdvancedModeOptions.Label = "Chọn bậc lương";
            this.txtBacLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtBacLuong.Properties.NullText = "";
            this.txtBacLuong.Properties.PopupView = this.txtBacLuongView;
            this.txtBacLuong.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtBacLuong.Size = new System.Drawing.Size(527, 34);
            this.txtBacLuong.StyleController = this.layoutControl1;
            this.txtBacLuong.TabIndex = 13;
            // 
            // txtBacLuongView
            // 
            this.txtBacLuongView.DetailHeight = 227;
            this.txtBacLuongView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.txtBacLuongView.Name = "txtBacLuongView";
            this.txtBacLuongView.OptionsEditForm.PopupEditFormWidth = 533;
            this.txtBacLuongView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.txtBacLuongView.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtBacLuong;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 190);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(531, 38);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(12, 240);
            this.txtChucVu.Margin = new System.Windows.Forms.Padding(2);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Properties.AdvancedModeOptions.Label = "Chọn chức vụ";
            this.txtChucVu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtChucVu.Properties.NullText = "";
            this.txtChucVu.Properties.PopupView = this.txtChucVuView;
            this.txtChucVu.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtChucVu.Size = new System.Drawing.Size(527, 34);
            this.txtChucVu.StyleController = this.layoutControl1;
            this.txtChucVu.TabIndex = 14;
            // 
            // txtChucVuView
            // 
            this.txtChucVuView.DetailHeight = 227;
            this.txtChucVuView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.txtChucVuView.Name = "txtChucVuView";
            this.txtChucVuView.OptionsEditForm.PopupEditFormWidth = 533;
            this.txtChucVuView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.txtChucVuView.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtChucVu;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 228);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(531, 81);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // txtStartDate
            // 
            this.txtStartDate.EditValue = new System.DateOnly(2024, 11, 13);
            this.txtStartDate.Location = new System.Drawing.Point(12, 12);
            this.txtStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtStartDate.Name = "txtStartDate";
            this.txtStartDate.Properties.AdvancedModeOptions.Label = "Ngày chuyển";
            this.txtStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStartDate.Properties.DisplayFormat.FormatString = "";
            this.txtStartDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtStartDate.Properties.EditFormat.FormatString = "";
            this.txtStartDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtStartDate.Properties.MaskSettings.Set("mask", "");
            this.txtStartDate.Properties.UseAdvancedMode = DevExpress.Utils.DefaultBoolean.True;
            this.txtStartDate.Size = new System.Drawing.Size(527, 34);
            this.txtStartDate.StyleController = this.layoutControl1;
            this.txtStartDate.TabIndex = 15;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtStartDate;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(531, 38);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // frmEmployeeTranfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 380);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.SvgImage = global::HRMSystem.Properties.Resources.Icon;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(600, 380);
            this.MinimumSize = new System.Drawing.Size(400, 247);
            this.Name = "frmEmployeeTranfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thông tin chi tiết";
            this.Load += new System.EventHandler(this.frmEmployeeTransferDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDepartmentView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoQD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEmployee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboEmployeeView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHopDong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHopDongView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBacLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBacLuongView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChucVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChucVuView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtSoQD;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SearchLookUpEdit cboEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView cboEmployeeView;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnBack;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.SearchLookUpEdit txtDepartment;
        private DevExpress.XtraGrid.Views.Grid.GridView txtDepartmentView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SearchLookUpEdit txtChucVu;
        private DevExpress.XtraGrid.Views.Grid.GridView txtChucVuView;
        private DevExpress.XtraEditors.SearchLookUpEdit txtBacLuong;
        private DevExpress.XtraGrid.Views.Grid.GridView txtBacLuongView;
        private DevExpress.XtraEditors.SearchLookUpEdit txtHopDong;
        private DevExpress.XtraGrid.Views.Grid.GridView txtHopDongView;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.DateEdit txtStartDate;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}