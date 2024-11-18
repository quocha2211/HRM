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
    public partial class frmContract : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler BackButtonClick;
        public string MaXLCB;
        public int MaNV;
        private BindingSource bindingSource = new BindingSource();

        public frmContract()
        {
            InitializeComponent();
        }


        private void InitializeDataBindings(Contract model)
        {
            bindingSource.DataSource = model;
            if (model.MaNV == null)
            {
                model.MaNV = MaNV;
            }
            txtNote.DataBindings.Add("Text", bindingSource, nameof(Contract.GhiChu), true, DataSourceUpdateMode.OnPropertyChanged);
            cboEmployee.DataBindings.Add("EditValue", bindingSource, nameof(Contract.MaNV), true, DataSourceUpdateMode.OnPropertyChanged);
            txtMaLoaiHD.DataBindings.Add("EditValue", bindingSource, nameof(Contract.MaLoaiHD), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNgayky.DataBindings.Add("Text", bindingSource, nameof(Contract.NgayKy), true, DataSourceUpdateMode.OnPropertyChanged);
            txtThoiHan.DataBindings.Add("EditValue", bindingSource, nameof(Contract.ThoiHan), true, DataSourceUpdateMode.OnPropertyChanged);
        }


        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.groupControl1.Focus();
                Contract model = (Contract)bindingSource.Current;
                if (model == null)
                {
                    MessageBox.Show("Lưu thất bại.");
                    return;
                }

                using (var context = new AppDbContext())
                {
                    context.HopDongs.AddOrUpdate(model);

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
                clsCommon.initialValue("LoaiHopDong", "MaLoaiHD", "TenLoaiHD", txtMaLoaiHDView, txtMaLoaiHD, clsInitialGridColumn.InitialComboLoaiHopDong());
                if (string.IsNullOrEmpty(MaXLCB))
                {
                    InitializeDataBindings(new Contract());
                }
                else
                {
                    using (var context = new AppDbContext())
                    {
                        var model = context.HopDongs.Find(Convert.ToInt32(MaXLCB));
                       
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