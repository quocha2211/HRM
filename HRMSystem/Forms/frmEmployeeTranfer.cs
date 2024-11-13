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
    public partial class frmEmployeeTranfer : DevExpress.XtraEditors.XtraForm
    {
        public event EventHandler BackButtonClick;
        public string MaCCT;
        private BindingSource bindingSource = new BindingSource();

        public frmEmployeeTranfer()
        {
            InitializeComponent();
        }


        private void InitializeDataBindings(EmployeeTransfer model)
        {
            bindingSource.DataSource = model;
            txtSoQD.DataBindings.Add("Text", bindingSource, nameof(EmployeeTransfer.SoQD));
            txtStartDate.DataBindings.Add("Text", bindingSource, nameof(EmployeeTransfer.NgayChuyen));
            txtDepartment.DataBindings.Add("EditValue", bindingSource, nameof(EmployeeTransfer.MaPB), true, DataSourceUpdateMode.OnPropertyChanged);
            txtChucVu.DataBindings.Add("EditValue", bindingSource, nameof(EmployeeTransfer.MaChucVu), true, DataSourceUpdateMode.OnPropertyChanged);
            txtHopDong.DataBindings.Add("EditValue", bindingSource, nameof(EmployeeTransfer.MaHD), true, DataSourceUpdateMode.OnPropertyChanged);
            txtBacLuong.DataBindings.Add("EditValue", bindingSource, nameof(EmployeeTransfer.MaBL), true, DataSourceUpdateMode.OnPropertyChanged);
            cboEmployee.DataBindings.Add("EditValue", bindingSource, nameof(EmployeeTransfer.MaNV), true, DataSourceUpdateMode.OnPropertyChanged);
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
                    context.DieuChuyenCongTacs.AddOrUpdate(model);

                    context.SaveChanges();
                }

                DialogResult = MessageBox.Show("Thông tin đã được lưu thành công.");

                this.Close();

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucChungChiDetail", ex.ToString()); }

        }


    

        private void frmEmployeeTransferDetail_Load(object sender, EventArgs e)
        {
            try
            {
                clsCommon.initialValue("NhanVien", "MaNV", "TenNV", cboEmployeeView, cboEmployee, clsInitialGridColumn.InitialComboEmployee());
                clsCommon.initialValue("PhongBan", "MaPB", "TenPB", txtDepartmentView, txtDepartment, clsInitialGridColumn.InitialComboDepartment());
                clsCommon.initialValue("ChucVu", "MaChucVu", "TenChucVu", txtDepartmentView, txtDepartment, clsInitialGridColumn.InitialComboDuty());
                //clsCommon.initialValue("PhongBan", "MaPB", "TenPB", txtDepartmentView, txtDepartment, clsInitialGridColumn.InitialComboHopDong());
                //clsCommon.initialValue("BangLuong", "MaPB", "TenPB", txtDepartmentView, txtDepartment, clsInitialGridColumn.InitialComboSalary());
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