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
        private void InitializeDataBindings(Users nhanVien)
        {
            bindingSource.DataSource = nhanVien;

            // TextEdit bindings
            txtCode.DataBindings.Add("Text", bindingSource, nameof(Users.MaNV));
            txtTenNV.DataBindings.Add("Text", bindingSource, nameof(Users.TenNV));
            txtBiDanh.DataBindings.Add("Text", bindingSource, nameof(Users.BiDanh));
            txtNoiOHienTai.DataBindings.Add("Text", bindingSource, nameof(Users.NoiOHienTai));
            txtNoiSinh.DataBindings.Add("Text", bindingSource, nameof(Users.NoiSinh));
            txtQueQuan.DataBindings.Add("Text", bindingSource, nameof(Users.QueQuan));
            txtCCCDNoiCap.DataBindings.Add("Text", bindingSource, nameof(Users.NoiCap));
            txtCCCD.DataBindings.Add("Text", bindingSource, nameof(Users.SoCCCD));
            txtEmail.DataBindings.Add("Text", bindingSource, nameof(Users.Email));
            txtSDT.DataBindings.Add("Text", bindingSource, nameof(Users.SoDienThoai));
            txtNoiVaoDoan.DataBindings.Add("Text", bindingSource, nameof(Users.NoiVaoDoan));
            txtNoiVaoDang.DataBindings.Add("Text", bindingSource, nameof(Users.NoiVaoDang));
            txtSoTheNganHang.DataBindings.Add("Text", bindingSource, nameof(Users.SoThe));
            txtNganHangSTK.DataBindings.Add("Text", bindingSource, nameof(Users.SoTaiKhoan));
            txtBaoHiemNoiCap.DataBindings.Add("Text", bindingSource, nameof(Users.NoiCapSo));
            txtLiDo.DataBindings.Add("Text", bindingSource, nameof(Users.LyDo));
            txtTinhTrangSucKhoe.DataBindings.Add("Text", bindingSource, nameof(Users.TinhTrangSuckhoe));
            cboNganHang.DataBindings.Add("Text", bindingSource, nameof(Users.NganHang));
            txtChieuCao.DataBindings.Add("Text", bindingSource, nameof(Users.ChieuCao));
            txtCanNang.DataBindings.Add("Text", bindingSource, nameof(Users.CanNang));

            // TextEdit binding with nullable int (SoSocBH)
            txtSoSoBH.DataBindings.Add("Text", bindingSource, nameof(Users.SoSocBH), true, DataSourceUpdateMode.OnPropertyChanged);

            // ComboBoxEdit bindings
            cboGioiTinh.DataBindings.Add("Text", bindingSource, nameof(Users.GioiTinh));
            cboTTHonNhan.DataBindings.Add("SelectedIndex", bindingSource, nameof(Users.TinhTrangHonNhan));
            cboNhomMau.DataBindings.Add("Text", bindingSource, nameof(Users.NhomMau));
            cboQuanHamCaoNhat.DataBindings.Add("Text", bindingSource, nameof(Users.QuanHamCaoNhat));
            cboChuyenMon.DataBindings.Add("EditValue", bindingSource, nameof(Users.MaCM));
            cboXepLoaiNhanVien.DataBindings.Add("EditValue", bindingSource, nameof(Users.MaXL));
            cboChungChi.DataBindings.Add("EditValue", bindingSource, nameof(Users.MaNN));
            cboChucvu.DataBindings.Add("EditValue", bindingSource, nameof(Users.MaChucVu));
            cboTrinhDoVanHoa.DataBindings.Add("EditValue", bindingSource, nameof(Users.MaTDVH));
            cboNgoaiNgu.DataBindings.Add("EditValue", bindingSource, nameof(Users.MaNN));
            cboTrinhDoLyLuan.DataBindings.Add("EditValue", bindingSource, nameof(Users.MaTDLLCT));
            cboTrangThaiLamViec.DataBindings.Add("EditValue", bindingSource, nameof(Users.MaTTLV));

            // DateEdit bindings with nullable DateTime
            txtNgaySinh.DataBindings.Add("DateTime", bindingSource, nameof(Users.NgaySinh));
            txtCCCDNgayCap.DataBindings.Add("DateTime", bindingSource, nameof(Users.NgayCap));
            txtNgayVaoDoan.DataBindings.Add("DateTime", bindingSource, nameof(Users.NgayVaoDoan));
            txtNgayVaoLam.DataBindings.Add("DateTime", bindingSource, nameof(Users.NgayVaoLam));
            txtNgayVaoDang.DataBindings.Add("DateTime", bindingSource, nameof(Users.NgayVaoDang));
            txtBaoHiemNgayCap.DataBindings.Add("DateTime", bindingSource, nameof(Users.NgayCapSo));

            // Nullable DateTime for exit dates
            txtNgayRoiCoQuan.DataBindings.Add("Text", bindingSource, nameof(Users.NgayRoiCoQuan));
            //txtNgayRoiCoQuan.DataBindings[0].Format += (s, e) => { e.Value = e.Value ?? DateTime.MinValue; };
            //txtNgayRoiCoQuan.DataBindings[0].Parse += (s, e) => { e.Value = e.Value == null || (DateTime)e.Value == DateTime.MinValue ? (DateTime?)null : e.Value; };

            txtNgayNhapNgu.DataBindings.Add("Text", bindingSource, nameof(Users.NgayNhapNgu));
            //txtNgayNhapNgu.DataBindings[0].Format += (s, e) => { e.Value = e.Value ?? DateTime.MinValue; };
            //txtNgayNhapNgu.DataBindings[0].Parse += (s, e) => { e.Value = e.Value == null || (DateTime)e.Value == DateTime.MinValue ? (DateTime?)null : e.Value; };

            txtNgayXuatNgu.DataBindings.Add("Text", bindingSource, nameof(Users.NgayXuatNgu));
            //txtNgayXuatNgu.DataBindings[0].Format += (s, e) => { e.Value = e.Value ?? DateTime.MinValue; };
            //txtNgayXuatNgu.DataBindings[0].Parse += (s, e) => { e.Value = e.Value == null || (DateTime)e.Value == DateTime.MinValue ? (DateTime?)null : e.Value; };

            // SpinEdit bindings for nullable float (HeSoLuong, HeSoPhuCap, etc.)
            txtHeSoLuong.DataBindings.Add("Text", bindingSource, nameof(Users.HeSoLuong), true, DataSourceUpdateMode.OnPropertyChanged);
            //txtHeSoLuong.DataBindings[0].Format += (s, e) => { e.Value = e.Value ?? 0.0f; };
            //txtHeSoLuong.DataBindings[0].Parse += (s, e) => { e.Value = e.Value == null || e.Value.ToString() == "0" ? (float?)null : Convert.ToSingle(e.Value); };

            txtHeSoPhuCap.DataBindings.Add("Text", bindingSource, nameof(Users.HeSoPhuCap), true, DataSourceUpdateMode.OnPropertyChanged);
            //txtHeSoPhuCap.DataBindings[0].Format += (s, e) => { e.Value = e.Value ?? 0.0f; };
            //txtHeSoPhuCap.DataBindings[0].Parse += (s, e) => { e.Value = e.Value == null || e.Value.ToString() == "0" ? (float?)null : Convert.ToSingle(e.Value); };

            txtTNVK.DataBindings.Add("Text", bindingSource, nameof(Users.HeSoTNVK), true, DataSourceUpdateMode.OnPropertyChanged);
            //txtTNVK.DataBindings[0].Format += (s, e) => { e.Value = e.Value ?? 0.0f; };
            //txtTNVK.DataBindings[0].Parse += (s, e) => { e.Value = e.Value == null || e.Value.ToString() == "0" ? (float?)null : Convert.ToSingle(e.Value); };

            txtHSL.DataBindings.Add("Text", bindingSource, nameof(Users.ThoiGianNangBacHSL), true, DataSourceUpdateMode.OnPropertyChanged);
            //txtHSL.DataBindings[0].Format += (s, e) => { e.Value = e.Value ?? 0; };
            //txtHSL.DataBindings[0].Parse += (s, e) => { e.Value = e.Value == null || e.Value.ToString() == "0" ? (int?)null : Convert.ToInt32(e.Value); };

            txtLuongCoSo.DataBindings.Add("Text", bindingSource, nameof(Users.LuongCoSo), true, DataSourceUpdateMode.OnPropertyChanged);
            //txtLuongCoSo.DataBindings[0].Format += (s, e) => { e.Value = e.Value ?? 0.0f; };
            //txtLuongCoSo.DataBindings[0].Parse += (s, e) => { e.Value = e.Value == null || e.Value.ToString() == "0" ? (float?)null : Convert.ToSingle(e.Value); };

            txtHotroXangXe.DataBindings.Add("Text", bindingSource, nameof(Users.MaDMXX), true, DataSourceUpdateMode.OnPropertyChanged);
            //txtHotroXangXe.DataBindings[0].Format += (s, e) => { e.Value = e.Value ?? 0; };
            //txtHotroXangXe.DataBindings[0].Parse += (s, e) => { e.Value = e.Value == null || e.Value.ToString() == "0" ? (int?)null : Convert.ToInt32(e.Value); };

            // ToggleSwitch bindings for nullable bool (RoiCoQuan, NghiHuu, etc.)
            rdRoiCoQuan.DataBindings.Add("IsOn", bindingSource, nameof(Users.RoiCoQuan));
            rdNghiHuu.DataBindings.Add("IsOn", bindingSource, nameof(Users.NghiHuu));
            rdNangLuong.DataBindings.Add("IsOn", bindingSource, nameof(Users.KhongChoPhepNangLuong));

            // SearchLookUpEdit bindings for nullable foreign keys
            cboTinhThanh.DataBindings.Add("EditValue", bindingSource, nameof(Users.MaTT));
            cboDanToc.DataBindings.Add("EditValue", bindingSource, nameof(Users.MaDT));
            cboNganHang.DataBindings.Add("EditValue", bindingSource, nameof(Users.MaDMXX));
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

                if (string.IsNullOrEmpty(MaNV))
                {
                    InitializeDataBindings(new Users());
                }
                else
                {
                    string[] lstParam = new string[3] { "@TableName", "@PrimaryKeyColumn", "@PrimaryKeyValue" };
                    object[] lstValue = new object[3] { "NhanVien", "MaNV", $"{MaNV}" };
                    DataTable dt = SQLHelper.GetDataTableFromSP("GetRecordByKey", lstParam, lstValue);
                    Users newModel = dt.ToList<Users>()[0];
                    //newModel.ConvertDate();
                    InitializeDataBindings(newModel);
                    //PopulateControlsFromNhanVien(newModel);
                }

            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucEmployeeDetail", ex.ToString()); }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackButtonClick?.Invoke(sender, e);
        }

        private async void btnSave_ItemClickAsync(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Users nhanVien = (Users)bindingSource.Current;

                if (nhanVien == null)
                {
                    return;
                }

                using (var context = new AppDbContext())
                {
                    context.NhanViens.AddOrUpdate(nhanVien);

                    await context.SaveChangesAsync();  
                }

                MessageBox.Show("Thông tin nhân viên đã được lưu thành công.");


            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucEmployeeDetail", ex.ToString()); }
        }

        private void btnCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BackButtonClick?.Invoke(sender, e);
        }
    }
}
