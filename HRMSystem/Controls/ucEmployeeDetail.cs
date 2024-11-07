using DevExpress.Xpo.DB.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using HRMSystem.Models;
using HRMSystem.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private void InitializeDataBindings(NhanVienModel nhanVien)
        {
            bindingSource.DataSource = nhanVien;

            // TextEdit bindings
            txtCode.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.MaNV));
            txtTenNV.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.TenNV));
            txtBiDanh.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.BiDanh));
            txtNoiOHienTai.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.NoiOHienTai));
            txtNoiSinh.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.NoiSinh));
            txtQueQuan.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.QueQuan));
            txtCCCDNoiCap.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.NoiCap));
            txtCCCD.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.SoCCCD));
            txtEmail.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.Email));
            txtSDT.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.SoDienThoai));
            txtNoiVaoDoan.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.NoiVaoDoan));
            txtNoiVaoDang.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.NoiVaoDang));
            txtSoTheNganHang.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.SoThe));
            txtNganHangSTK.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.SoTaiKhoan));
            txtBaoHiemNoiCap.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.NoiCapSo));
            txtLiDo.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.LyDo));
            txtTinhTrangSucKhoe.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.TinhTrangSuckhoe));
            cboNganHang.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.NganHang));
            txtChieuCao.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.ChieuCao));
            txtCanNang.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.CanNang));

            // TextEdit binding with nullable int (SoSocBH)
            txtSoSoBH.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.SoSocBH), true, DataSourceUpdateMode.OnPropertyChanged);

            // ComboBoxEdit bindings
            cboGioiTinh.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.GioiTinh));
            cboTTHonNhan.DataBindings.Add("SelectedIndex", bindingSource, nameof(NhanVienModel.TinhTrangHonNhan));
            cboNhomMau.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.NhomMau));
            cboQuanHamCaoNhat.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.QuanHamCaoNhat));
            cboChuyenMon.DataBindings.Add("EditValue", bindingSource, nameof(NhanVienModel.MaCM));
            cboXepLoaiNhanVien.DataBindings.Add("EditValue", bindingSource, nameof(NhanVienModel.MaXL));
            cboChungChi.DataBindings.Add("EditValue", bindingSource, nameof(NhanVienModel.MaNN));
            cboChucvu.DataBindings.Add("EditValue", bindingSource, nameof(NhanVienModel.MaChucVu));
            cboTrinhDoVanHoa.DataBindings.Add("EditValue", bindingSource, nameof(NhanVienModel.MaTDVH));
            cboNgoaiNgu.DataBindings.Add("EditValue", bindingSource, nameof(NhanVienModel.MaNN));
            cboTrinhDoLyLuan.DataBindings.Add("EditValue", bindingSource, nameof(NhanVienModel.MaTDLLCT));
            cboTrangThaiLamViec.DataBindings.Add("EditValue", bindingSource, nameof(NhanVienModel.MaTTLV));

            // DateEdit bindings with nullable DateTime
            txtNgaySinh.DataBindings.Add("DateTime", bindingSource, nameof(NhanVienModel.NgaySinh));
            txtCCCDNgayCap.DataBindings.Add("DateTime", bindingSource, nameof(NhanVienModel.NgayCap));
            txtNgayVaoDoan.DataBindings.Add("DateTime", bindingSource, nameof(NhanVienModel.NgayVaoDoan));
            txtNgayVaoLam.DataBindings.Add("DateTime", bindingSource, nameof(NhanVienModel.NgayVaoLam));
            txtNgayVaoDang.DataBindings.Add("DateTime", bindingSource, nameof(NhanVienModel.NgayVaoDang));
            txtBaoHiemNgayCap.DataBindings.Add("DateTime", bindingSource, nameof(NhanVienModel.NgayCapSo));

            // Nullable DateTime for exit dates
            txtNgayRoiCoQuan.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.NgayRoiCoQuan));
            //txtNgayRoiCoQuan.DataBindings[0].Format += (s, e) => { e.Value = e.Value ?? DateTime.MinValue; };
            //txtNgayRoiCoQuan.DataBindings[0].Parse += (s, e) => { e.Value = e.Value == null || (DateTime)e.Value == DateTime.MinValue ? (DateTime?)null : e.Value; };

            txtNgayNhapNgu.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.NgayNhapNgu));
            //txtNgayNhapNgu.DataBindings[0].Format += (s, e) => { e.Value = e.Value ?? DateTime.MinValue; };
            //txtNgayNhapNgu.DataBindings[0].Parse += (s, e) => { e.Value = e.Value == null || (DateTime)e.Value == DateTime.MinValue ? (DateTime?)null : e.Value; };

            txtNgayXuatNgu.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.NgayXuatNgu));
            //txtNgayXuatNgu.DataBindings[0].Format += (s, e) => { e.Value = e.Value ?? DateTime.MinValue; };
            //txtNgayXuatNgu.DataBindings[0].Parse += (s, e) => { e.Value = e.Value == null || (DateTime)e.Value == DateTime.MinValue ? (DateTime?)null : e.Value; };

            // SpinEdit bindings for nullable float (HeSoLuong, HeSoPhuCap, etc.)
            txtHeSoLuong.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.HeSoLuong), true, DataSourceUpdateMode.OnPropertyChanged);
            //txtHeSoLuong.DataBindings[0].Format += (s, e) => { e.Value = e.Value ?? 0.0f; };
            //txtHeSoLuong.DataBindings[0].Parse += (s, e) => { e.Value = e.Value == null || e.Value.ToString() == "0" ? (float?)null : Convert.ToSingle(e.Value); };

            txtHeSoPhuCap.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.HeSoPhuCap), true, DataSourceUpdateMode.OnPropertyChanged);
            //txtHeSoPhuCap.DataBindings[0].Format += (s, e) => { e.Value = e.Value ?? 0.0f; };
            //txtHeSoPhuCap.DataBindings[0].Parse += (s, e) => { e.Value = e.Value == null || e.Value.ToString() == "0" ? (float?)null : Convert.ToSingle(e.Value); };

            txtTNVK.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.HeSoTNVK), true, DataSourceUpdateMode.OnPropertyChanged);
            //txtTNVK.DataBindings[0].Format += (s, e) => { e.Value = e.Value ?? 0.0f; };
            //txtTNVK.DataBindings[0].Parse += (s, e) => { e.Value = e.Value == null || e.Value.ToString() == "0" ? (float?)null : Convert.ToSingle(e.Value); };

            txtHSL.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.ThoiGianNangBacHSL), true, DataSourceUpdateMode.OnPropertyChanged);
            //txtHSL.DataBindings[0].Format += (s, e) => { e.Value = e.Value ?? 0; };
            //txtHSL.DataBindings[0].Parse += (s, e) => { e.Value = e.Value == null || e.Value.ToString() == "0" ? (int?)null : Convert.ToInt32(e.Value); };

            txtLuongCoSo.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.LuongCoSo), true, DataSourceUpdateMode.OnPropertyChanged);
            //txtLuongCoSo.DataBindings[0].Format += (s, e) => { e.Value = e.Value ?? 0.0f; };
            //txtLuongCoSo.DataBindings[0].Parse += (s, e) => { e.Value = e.Value == null || e.Value.ToString() == "0" ? (float?)null : Convert.ToSingle(e.Value); };

            txtHotroXangXe.DataBindings.Add("Text", bindingSource, nameof(NhanVienModel.MaDMXX), true, DataSourceUpdateMode.OnPropertyChanged);
            //txtHotroXangXe.DataBindings[0].Format += (s, e) => { e.Value = e.Value ?? 0; };
            //txtHotroXangXe.DataBindings[0].Parse += (s, e) => { e.Value = e.Value == null || e.Value.ToString() == "0" ? (int?)null : Convert.ToInt32(e.Value); };

            // ToggleSwitch bindings for nullable bool (RoiCoQuan, NghiHuu, etc.)
            rdRoiCoQuan.DataBindings.Add("IsOn", bindingSource, nameof(NhanVienModel.RoiCoQuan));
            rdNghiHuu.DataBindings.Add("IsOn", bindingSource, nameof(NhanVienModel.NghiHuu));
            rdNangLuong.DataBindings.Add("IsOn", bindingSource, nameof(NhanVienModel.KhongChoPhepNangLuong));

            // SearchLookUpEdit bindings for nullable foreign keys
            cboTinhThanh.DataBindings.Add("EditValue", bindingSource, nameof(NhanVienModel.MaTT));
            cboDanToc.DataBindings.Add("EditValue", bindingSource, nameof(NhanVienModel.MaDT));
            cboNganHang.DataBindings.Add("EditValue", bindingSource, nameof(NhanVienModel.MaDMXX));
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
                    InitializeDataBindings(new NhanVienModel());
                }
                else
                {
                    string[] lstParam = new string[3] { "@TableName", "@PrimaryKeyColumn", "@PrimaryKeyValue" };
                    object[] lstValue = new object[3] { "NhanVien", "MaNV", $"{MaNV}" };
                    DataTable dt = SQLHelper.GetDataTableFromSP("GetRecordByKey", lstParam, lstValue);
                    NhanVienModel newModel = dt.ToList<NhanVienModel>()[0];
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

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                NhanVienModel nhanVien = (NhanVienModel)bindingSource.Current;

               
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "ucEmployeeDetail", ex.ToString()); }
        }
    }
}
