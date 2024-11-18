﻿using DevExpress.XtraEditors;
using HRMSystem.Models;
using HRMSystem.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMSystem.Forms
{
    public partial class frmEmployeeRanking : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler BackButtonClick;
        public string MaXLCB;
        public int MaNV;
        private BindingSource bindingSource = new BindingSource();

        public frmEmployeeRanking()
        {
            InitializeComponent();
        }


        private void InitializeDataBindings(EmployeeRanking model)
        {
            bindingSource.DataSource = model;
            if (model.MaNV == null) model.MaNV = MaNV;
            txtRank.DataBindings.Add("Text", bindingSource, nameof(EmployeeRanking.XepLoai));
            txtTitleRank.DataBindings.Add("Text", bindingSource, nameof(EmployeeRanking.DanhHieu));
            txtNote.DataBindings.Add("Text", bindingSource, nameof(EmployeeRanking.GhiChu));
            //txtDepartment.DataBindings.Add("EditValue", bindingSource, nameof(EmployeeRanking.MaPB), true, DataSourceUpdateMode.OnPropertyChanged);
            cboEmployee.DataBindings.Add("EditValue", bindingSource, nameof(EmployeeRanking.MaNV), true, DataSourceUpdateMode.OnPropertyChanged);
        }


        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.groupControl1.Focus();
                EmployeeRanking model = (EmployeeRanking)bindingSource.Current;
                if (model == null)
                {
                    MessageBox.Show("Lưu thất bại.");
                    return;
                }

                using (var context = new AppDbContext())
                {
                    context.XepLoaiNhanViens.AddOrUpdate(model);

                    context.SaveChanges();
                }

                DialogResult = MessageBox.Show("Thông tin đã được lưu thành công.");

                this.Close();

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucChungChiDetail", ex.ToString()); }

        }


    

        private void frmEmployeeRankingDetail_Load(object sender, EventArgs e)
        {
            try
            {
                clsCommon.initialValue("NhanVien", "MaNV", "TenNV", cboEmployeeView, cboEmployee, clsInitialGridColumn.InitialComboEmployee());
                clsCommon.initialValue("PhongBan", "MaPB", "TenPB", txtDepartmentView, txtDepartment, clsInitialGridColumn.InitialComboDepartment());
                if (string.IsNullOrEmpty(MaXLCB))
                {
                    InitializeDataBindings(new EmployeeRanking());
                }
                else
                {
                    using (var context = new AppDbContext())
                    {
                        var model = context.XepLoaiNhanViens.Find(Convert.ToInt32(MaXLCB));
                        if (string.IsNullOrEmpty(model.XepLoai))
                            model.XepLoai = "giỏi";
                        InitializeDataBindings(model);

                    }
                }

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucChungChiDetail", ex.ToString()); }
        }

        private void btnBack_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}