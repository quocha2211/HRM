using DevExpress.XtraEditors;
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
    public partial class frmThanNhan : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler BackButtonClick;
        public string MaTN;
        public int MaNV;
        private BindingSource bindingSource = new BindingSource();

        public frmThanNhan()
        {
            InitializeComponent();
        }


        private void InitializeDataBindings(ThanNhan model)
        {
            bindingSource.DataSource = model;
            if (model.MaNV == null)
            {
                model.MaNV = MaNV;
            }
            txtNote.DataBindings.Add("Text", bindingSource, nameof(ThanNhan.GhiChu), true, DataSourceUpdateMode.OnPropertyChanged);
            cboEmployee.DataBindings.Add("EditValue", bindingSource, nameof(ThanNhan.MaNV), true, DataSourceUpdateMode.OnPropertyChanged);
            txtMaQHTN.DataBindings.Add("EditValue", bindingSource, nameof(ThanNhan.MaQHTN), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNgaySinh.DataBindings.Add("Text", bindingSource, nameof(ThanNhan.NgaySinh), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNgheNghiep.DataBindings.Add("Text", bindingSource, nameof(ThanNhan.NgheNghiep), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNoiO.DataBindings.Add("Text", bindingSource, nameof(ThanNhan.NoiO), true, DataSourceUpdateMode.OnPropertyChanged);
            txtName.DataBindings.Add("Text", bindingSource, nameof(ThanNhan.HoVaTen), true, DataSourceUpdateMode.OnPropertyChanged);
        }


        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.groupControl1.Focus();
                ThanNhan model = (ThanNhan)bindingSource.Current;


                if (model == null)
                {
                    MessageBox.Show("Lưu thất bại.");
                    return;
                }

                using (var context = new AppDbContext())
                {
                    context.ThanNhans.AddOrUpdate(model);

                    context.SaveChanges();
                }

                DialogResult = MessageBox.Show("Thông tin đã được lưu thành công.");

                this.Close();

            }
            catch (Exception ex) { MessageBox.Show("Lưu thất bại."); SQLiteHelper.SaveToLog(ex.Message, "ucChungChiDetail", ex.ToString()); }

        }




        private void frmEmployeeRankingDetail_Load(object sender, EventArgs e)
        {
            try
            {
                clsCommon.initialValue("NhanVien", "MaNV", "TenNV", cboEmployeeView, cboEmployee, clsInitialGridColumn.InitialComboEmployee());
                clsCommon.initialValue("QuanHeThanNhan", "MaQHTN", "TenQHTN", txtMaQHTNView, txtMaQHTN, clsInitialGridColumn.InitialComboQHTN());
                if (string.IsNullOrEmpty(MaTN))
                {
                    InitializeDataBindings(new ThanNhan());
                }
                else
                {
                    using (var context = new AppDbContext())
                    {
                        var model = context.ThanNhans.Find(Convert.ToInt32(MaTN));

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