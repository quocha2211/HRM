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
    public partial class frmCongTac : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler BackButtonClick;
        public string MaCCT;
        public int MaNV;
        private BindingSource bindingSource = new BindingSource();
        public int nam;
        public int thang;
        public frmCongTac()
        {
            InitializeComponent();
        }


        private void InitializeDataBindings(EmployeeTransfer model)
        {
            bindingSource.DataSource = model;
            if (model.MaNV == null)
            {
                model.MaNV = MaNV;
            }
            txtNote.DataBindings.Add("Text", bindingSource, nameof(EmployeeTransfer.GhiChu), true, DataSourceUpdateMode.OnPropertyChanged);
            cboEmployee.DataBindings.Add("EditValue", bindingSource, nameof(EmployeeTransfer.MaNV), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNgayChuyen.DataBindings.Add("Text", bindingSource, nameof(EmployeeTransfer.NgayChuyen), true, DataSourceUpdateMode.OnPropertyChanged);
            txtSoQD.DataBindings.Add("Text", bindingSource, nameof(EmployeeTransfer.SoQD), true, DataSourceUpdateMode.OnPropertyChanged);
            txtThangLuong.DataBindings.Add("EditValue", bindingSource, nameof(EmployeeTransfer.MaTL), true, DataSourceUpdateMode.OnPropertyChanged);
            txtchucVu.DataBindings.Add("EditValue", bindingSource, nameof(EmployeeTransfer.MaChucVu), true, DataSourceUpdateMode.OnPropertyChanged);
        }


        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.groupControl1.Focus();
                EmployeeTransfer model = (EmployeeTransfer)bindingSource.Current;
               

                if (model == null)
                {
                    MessageBox.Show("Lưu thất bại.");
                    return;
                }

                using (var context = new AppDbContext())
                {
                    if(model.MaCCT == null)
                        context.DieuChuyenCongTacs.Add(model);
                    else
                        context.DieuChuyenCongTacs.AddOrUpdate(model);

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
                clsCommon.initialValue("ThangLuong", "MaTL", "TenTL", txtThangLuongView, txtThangLuong, clsInitialGridColumn.InitialComboThangLuong());
                clsCommon.initialValue("ChucVu", "MaChucVu", "TenChucVu", txtChucVuView, txtchucVu, clsInitialGridColumn.InitialComboChucVu());
                if (string.IsNullOrEmpty(MaCCT))
                {
                    InitializeDataBindings(new EmployeeTransfer());
                }
                else
                {
                    using (var context = new AppDbContext())
                    {
                        var model = context.DieuChuyenCongTacs.Find(Convert.ToInt32(MaCCT));
                       
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