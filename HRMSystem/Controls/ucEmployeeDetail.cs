using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

namespace HRMSystem.Controls
{
    public partial class ucEmployeeDetail : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler BackButtonClick;
        public string MaNV;
        private BindingSource bindingSource = new BindingSource();
        public ucEmployeeDetail()
        {
            InitializeComponent();
        }
        private void InitializeDataBindings(Employee nhanVien)
        {
            bindingSource.DataSource = nhanVien;

            // TextEdit bindings
            txtCode.DataBindings.Add("Text", bindingSource, nameof(Employee.MaNV), true, DataSourceUpdateMode.OnPropertyChanged);
            txtTenNV.DataBindings.Add("Text", bindingSource, nameof(Employee.TenNV), true, DataSourceUpdateMode.OnPropertyChanged);
            txtBiDanh.DataBindings.Add("Text", bindingSource, nameof(Employee.BiDanh), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNoiOHienTai.DataBindings.Add("Text", bindingSource, nameof(Employee.NoiOHienTai), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNoiSinh.DataBindings.Add("Text", bindingSource, nameof(Employee.NoiSinh), true, DataSourceUpdateMode.OnPropertyChanged);
            txtQueQuan.DataBindings.Add("Text", bindingSource, nameof(Employee.QueQuan), true, DataSourceUpdateMode.OnPropertyChanged);
            txtCCCDNoiCap.DataBindings.Add("Text", bindingSource, nameof(Employee.NoiCap), true, DataSourceUpdateMode.OnPropertyChanged);
            txtCCCD.DataBindings.Add("Text", bindingSource, nameof(Employee.SoCCCD), true, DataSourceUpdateMode.OnPropertyChanged);
            txtEmail.DataBindings.Add("Text", bindingSource, nameof(Employee.Email), true, DataSourceUpdateMode.OnPropertyChanged);
            txtSDT.DataBindings.Add("Text", bindingSource, nameof(Employee.SoDienThoai), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNoiVaoDoan.DataBindings.Add("Text", bindingSource, nameof(Employee.NoiVaoDoan), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNoiVaoDang.DataBindings.Add("Text", bindingSource, nameof(Employee.NoiVaoDang), true, DataSourceUpdateMode.OnPropertyChanged);
            txtSoTheNganHang.DataBindings.Add("Text", bindingSource, nameof(Employee.SoThe), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNganHangSTK.DataBindings.Add("Text", bindingSource, nameof(Employee.SoTaiKhoan), true, DataSourceUpdateMode.OnPropertyChanged);
            txtBaoHiemNoiCap.DataBindings.Add("Text", bindingSource, nameof(Employee.NoiCapSo), true, DataSourceUpdateMode.OnPropertyChanged);
            txtLiDo.DataBindings.Add("Text", bindingSource, nameof(Employee.LyDo), true, DataSourceUpdateMode.OnPropertyChanged);
            txtTinhTrangSucKhoe.DataBindings.Add("Text", bindingSource, nameof(Employee.TinhTrangSuckhoe), true, DataSourceUpdateMode.OnPropertyChanged);
            cboNganHang.DataBindings.Add("Text", bindingSource, nameof(Employee.NganHang), true, DataSourceUpdateMode.OnPropertyChanged);
            txtChieuCao.DataBindings.Add("Text", bindingSource, nameof(Employee.ChieuCao), true, DataSourceUpdateMode.OnPropertyChanged);
            txtCanNang.DataBindings.Add("Text", bindingSource, nameof(Employee.CanNang), true, DataSourceUpdateMode.OnPropertyChanged);

            // TextEdit binding with nullable int (SoSocBH)
            txtSoSoBH.DataBindings.Add("Text", bindingSource, nameof(Employee.SoSocBH), true, DataSourceUpdateMode.OnPropertyChanged);

            // ComboBoxEdit bindings
            cboGioiTinh.DataBindings.Add("Text", bindingSource, nameof(Employee.GioiTinh), true, DataSourceUpdateMode.OnPropertyChanged);
            cboTTHonNhan.DataBindings.Add("SelectedIndex", bindingSource, nameof(Employee.TinhTrangHonNhan), true, DataSourceUpdateMode.OnPropertyChanged);
            cboNhomMau.DataBindings.Add("Text", bindingSource, nameof(Employee.NhomMau), true, DataSourceUpdateMode.OnPropertyChanged);
            cboQuanHamCaoNhat.DataBindings.Add("Text", bindingSource, nameof(Employee.QuanHamCaoNhat), true, DataSourceUpdateMode.OnPropertyChanged);
            cboChuyenMon.DataBindings.Add("EditValue", bindingSource, nameof(Employee.MaCM), true, DataSourceUpdateMode.OnPropertyChanged);
            cboXepLoaiNhanVien.DataBindings.Add("EditValue", bindingSource, nameof(Employee.MaXL), true, DataSourceUpdateMode.OnPropertyChanged);
            cboChucvu.DataBindings.Add("EditValue", bindingSource, nameof(Employee.MaChucVu), true, DataSourceUpdateMode.OnPropertyChanged);
            cboTrinhDoVanHoa.DataBindings.Add("EditValue", bindingSource, nameof(Employee.MaTDVH), true, DataSourceUpdateMode.OnPropertyChanged);
            cboNgoaiNgu.DataBindings.Add("EditValue", bindingSource, nameof(Employee.MaNN), true, DataSourceUpdateMode.OnPropertyChanged);
            cboTrangThaiLamViec.DataBindings.Add("EditValue", bindingSource, nameof(Employee.MaTTLV), true, DataSourceUpdateMode.OnPropertyChanged);

            // DateEdit bindings with nullable DateTime
            txtNgaySinh.DataBindings.Add("Text", bindingSource, nameof(Employee.NgaySinh), true, DataSourceUpdateMode.OnPropertyChanged);
            txtCCCDNgayCap.DataBindings.Add("Text", bindingSource, nameof(Employee.NgayCap), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNgayVaoDoan.DataBindings.Add("Text", bindingSource, nameof(Employee.NgayVaoDoan), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNgayVaoLam.DataBindings.Add("Text", bindingSource, nameof(Employee.NgayVaoLam), true, DataSourceUpdateMode.OnPropertyChanged);
            txtNgayVaoDang.DataBindings.Add("Text", bindingSource, nameof(Employee.NgayVaoDang), true, DataSourceUpdateMode.OnPropertyChanged);
            txtBaoHiemNgayCap.DataBindings.Add("Text", bindingSource, nameof(Employee.NgayCapSo), true, DataSourceUpdateMode.OnPropertyChanged);

            // Nullable DateTime for exit dates
            txtNgayRoiCoQuan.DataBindings.Add("Text", bindingSource, nameof(Employee.NgayRoiCoQuan), true, DataSourceUpdateMode.OnPropertyChanged);

            txtNgayNhapNgu.DataBindings.Add("Text", bindingSource, nameof(Employee.NgayNhapNgu), true, DataSourceUpdateMode.OnPropertyChanged);

            txtNgayXuatNgu.DataBindings.Add("Text", bindingSource, nameof(Employee.NgayXuatNgu), true, DataSourceUpdateMode.OnPropertyChanged);

            // SpinEdit bindings for nullable float (HeSoLuong, HeSoPhuCap, etc.)
            txtHeSoLuong.DataBindings.Add("EditValue", bindingSource, nameof(Employee.MaTL), true, DataSourceUpdateMode.OnPropertyChanged);

            txtHeSoPhuCap.DataBindings.Add("Text", bindingSource, nameof(Employee.HeSoPhuCap), true, DataSourceUpdateMode.OnPropertyChanged);

            txtTNVK.DataBindings.Add("Text", bindingSource, nameof(Employee.HeSoTNVK), true, DataSourceUpdateMode.OnPropertyChanged);

            txtHSL.DataBindings.Add("Text", bindingSource, nameof(Employee.ThoiGianNangBacHSL), true, DataSourceUpdateMode.OnPropertyChanged);

            txtLuongCoSo.DataBindings.Add("EditValue", bindingSource, nameof(Employee.MaMLTT), true, DataSourceUpdateMode.OnPropertyChanged);

            txtHotroXangXe.DataBindings.Add("EditValue", bindingSource, nameof(Employee.MaDMXX), true, DataSourceUpdateMode.OnPropertyChanged);

            // ToggleSwitch bindings for nullable bool (RoiCoQuan, NghiHuu, etc.)
            rdRoiCoQuan.DataBindings.Add("IsOn", bindingSource, nameof(Employee.RoiCoQuan), true, DataSourceUpdateMode.OnPropertyChanged);
            //rdNghiHuu.DataBindings.Add("IsOn", bindingSource, nameof(Employee.NghiHuu), true, DataSourceUpdateMode.OnPropertyChanged);
            rdNangLuong.DataBindings.Add("IsOn", bindingSource, nameof(Employee.KhongChoPhepNangLuong), true, DataSourceUpdateMode.OnPropertyChanged);

            // SearchLookUpEdit bindings for nullable foreign keys
            cboTinhThanh.DataBindings.Add("EditValue", bindingSource, nameof(Employee.MaTT), true, DataSourceUpdateMode.OnPropertyChanged);
            cboDanToc.DataBindings.Add("EditValue", bindingSource, nameof(Employee.MaDT), true, DataSourceUpdateMode.OnPropertyChanged);
            pictureEdit1.DataBindings.Add("EditValue", bindingSource, nameof(Employee.Anh), true, DataSourceUpdateMode.OnPropertyChanged);
        }


        private void initialValue(string tableName, string valueMember, string displayMember, GridView grv, SearchLookUpEdit cbo, List<GridColumnModel> lst)
        {
            try
            {
                grv.InitialGridColumn(lst);
                cbo.Properties.DataSource = clsSQLAllValue.GetAllValueFromTable(tableName);
                cbo.Properties.ValueMember = valueMember;
                cbo.Properties.DisplayMember = displayMember;
                grv.SetGridControlProperties();

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucEmployeeDetail", ex.ToString()); }
        }

        private void ucEmployeeDetail_Load(object sender, EventArgs e)
        {
            try
            {
                //Master Data
                initialValue("TinhThanh", "MaTT", "TenTT", grvProvince, cboTinhThanh, clsInitialGridColumn.InitialProvince());
                initialValue("DanToc", "MaDT", "TenDT", grvEthnic, cboDanToc, clsInitialGridColumn.InitialEthnic());
                initialValue("NganHang", "MaNH", "VietTat", grvBank, cboNganHang, clsInitialGridColumn.InitialBank());
                initialValue("ChucVu", "MaChucVu", "TenChucVu", grvChucVu, cboChucvu, clsInitialGridColumn.InitialChucVu());
                initialValue("XepLoai", "MaXL", "TenXL", grvXepLoai, cboXepLoaiNhanVien, clsInitialGridColumn.InitialXepLoai());
                initialValue("ChuyenMon", "MaCM", "TenCM", grvChuyenMon, cboChuyenMon, clsInitialGridColumn.InitialExpertise());
                initialValue("TrinhDoVanHoa", "MaTDVH", "TenTDVH", grvTrinhDoVanHoa, cboTrinhDoVanHoa, clsInitialGridColumn.InitialLevelEducational());
                initialValue("NgoaiNgu", "MaNN", "TenNN", grvNgoaiNgu, cboNgoaiNgu, clsInitialGridColumn.InitialLanguage());
                initialValue("TrangThaiLamViec", "MaTTLV", "TenTTLV", grvTrangThaiLamViec, cboTrangThaiLamViec, clsInitialGridColumn.InitialWorkStatus());
                initialValue("MucLuongToiThieu", "MaMLTT", "MLTTC",txtLuongView , txtLuongCoSo, clsInitialGridColumn.InitialMinSalary());
                initialValue("ThangLuong", "MaTL", "HeSo", txtHeSoLuongView, txtHeSoLuong, clsInitialGridColumn.InitialSalaryScale());
                initialValue("DinhMucXangXe", "MaDMXX", "DMXX", txtHotroXangXeView, txtHotroXangXe, clsInitialGridColumn.InitialDinhMucXangXe());

                if (string.IsNullOrEmpty(MaNV))
                {
                    InitializeDataBindings(new Employee());
                }
                else
                {
                    string[] lstParam = new string[3] { "@TableName", "@PrimaryKeyColumn", "@PrimaryKeyValue" };
                    object[] lstValue = new object[3] { "NhanVien", "MaNV", $"{MaNV}" };
                    DataTable dt = SQLHelper.GetDataTableFromSP("GetRecordByKey", lstParam, lstValue);
                    Employee newModel = dt.ToList<Employee>()[0];
                    InitializeDataBindings(newModel);
                }

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucEmployeeDetail", ex.ToString()); }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackButtonClick?.Invoke(sender, e);
        }

        public bool ValidateUser(Employee user)
        {
            if (user == null)
            {
                return false;
            }

          

            // Kiểm tra TenNV
            if (string.IsNullOrEmpty(user.TenNV))
            {
                return false;
            }

            // Kiểm tra BiDanh
            if (string.IsNullOrEmpty(user.BiDanh))
            {
                return false;
            }

            // Kiểm tra GioiTinh
            if (string.IsNullOrEmpty(user.GioiTinh))
            {
                return false;
            }

            // Kiểm tra NgaySinh
            if (user.NgaySinh == DateTime.MinValue)
            {
                return false;
            }

            // Kiểm tra QueQuan
            if (string.IsNullOrEmpty(user.QueQuan))
            {
                return false;
            }

            // Kiểm tra NoiSinh
            if (string.IsNullOrEmpty(user.NoiSinh))
            {
                return false;
            }

            // Kiểm tra SoCCCD
            if (string.IsNullOrEmpty(user.SoCCCD))
            {
                return false;
            }

            // Kiểm tra NgayCap
            if (user.NgayCap == DateTime.MinValue)
            {
                return false;
            }

            // Kiểm tra NoiCap
            if (string.IsNullOrEmpty(user.NoiCap))
            {
                return false;
            }

            // Kiểm tra Email
            if (string.IsNullOrEmpty(user.Email))
            {
                return false;
            }

            // Kiểm tra SoDienThoai
            if (string.IsNullOrEmpty(user.SoDienThoai))
            {
                return false;
            }

            // Kiểm tra NgayVaoDoan
            if (user.NgayVaoDoan == DateTime.MinValue)
            {
                return false;
            }

            // Kiểm tra NgayVaoDang
            if (user.NgayVaoDang == DateTime.MinValue)
            {
                return false;
            }

            // Kiểm tra NgayVaoLam
            if (user.NgayVaoLam == DateTime.MinValue)
            {
                return false;
            }

            // Kiểm tra SoSocBH
            if (user.SoSocBH <= 0)
            {
                return false;
            }

            // Kiểm tra NgayCapSo
            if (user.NgayCapSo == DateTime.MinValue)
            {
                return false;
            }

            // Kiểm tra NoiCapSo
            if (string.IsNullOrEmpty(user.NoiCapSo))
            {
                return false;
            }

            // Kiểm tra SoThe
            if (string.IsNullOrEmpty(user.SoThe))
            {
                return false;
            }

            // Kiểm tra SoTaiKhoan
            if (string.IsNullOrEmpty(user.SoTaiKhoan))
            {
                return false;
            }

            // Kiểm tra NganHang
            if (string.IsNullOrEmpty(user.NganHang))
            {
                return false;
            }

            // Kiểm tra TinhTrangHonNhan
            if (user.TinhTrangHonNhan == null)
            {
                return false;
            }

            // Kiểm tra TinhTrangSuckhoe
            if (string.IsNullOrEmpty(user.TinhTrangSuckhoe))
            {
                return false;
            }

            // Kiểm tra NhomMau
            if (string.IsNullOrEmpty(user.NhomMau))
            {
                return false;
            }

            return true;
        }


        private async void btnSave_ItemClickAsync(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {

                this.groupControl1.Focus();
                Employee nhanVien = (Employee)bindingSource.Current;
                if (!ValidateUser(nhanVien))
                {
                    MessageBox.Show("Nhập đầy đủ thông tin.");
                    return;
                }

                using (var context = new AppDbContext())
                {
                    context.NhanViens.AddOrUpdate(nhanVien);

                    await context.SaveChangesAsync();
                }

                MessageBox.Show("Thông tin đã được lưu thành công.");

            }
            catch (Exception ex)
            {
                SQLiteHelper.SaveToLog(ex.Message, "ucEmployeeDetail", ex.ToString());
            }
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BackButtonClick?.Invoke(sender, e);
        }
    }
}
