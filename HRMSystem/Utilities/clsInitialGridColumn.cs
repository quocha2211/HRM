﻿using DevExpress.XtraGrid.Columns;
using HRMSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Utilities
{
    public static class clsInitialGridColumn
    {
        public static List<GridColumnModel> InitialProvince()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Mã tỉnh thành", FieldName = "MaTT", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colName", Caption = "Tên tỉnh thành", FieldName = "TenTT", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }
        public static List<GridColumnModel> InitialReligion()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Mã tôn giáo", FieldName = "MaTT", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colName", Caption = "Tên tôn giáo", FieldName = "TenTG", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }
        public static List<GridColumnModel> InitialEthnic()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Mã dân tộc", FieldName = "MaDT", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colName", Caption = "Tên dân tộc", FieldName = "TenDT", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }
        public static List<GridColumnModel> InitialDuty()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Mã chức vụ", FieldName = "MaChucVu", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colName", Caption = "Tên chức vụ", FieldName = "TenChucVu", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colLevel", Caption = "Cấp độ", FieldName = "CapDo", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCoefficient", Caption = "Hệ số chức danh", FieldName = "HeSoChucDanh", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }
        public static List<GridColumnModel> InitialDepartment()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Mã phòng ban", FieldName = "MaPB", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colName", Caption = "Tên phòng ban", FieldName = "TenPB", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colLevel", Caption = "Cấp độ", FieldName = "CapDo", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colMale", Caption = "Độ tuổi về hưu nam", FieldName = "DoTuoiVeHuuNam", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colFemale", Caption = "Độ tuổi về hưu nữ", FieldName = "DoTuoiVeHuuNu", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }

        public static List<GridColumnModel> InitialBank()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Mã ngân hàng", FieldName = "MaNH", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colFullName", Caption = "Tên đầy đủ", FieldName = "TenDayDu", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colName", Caption = "Tên viết tắt", FieldName = "VietTat", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colStockCode", Caption = "Mã chứng khoán", FieldName = "MaChungKhoan", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }
        public static List<GridColumnModel> InitialChucVu()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Mã chức vụ", FieldName = "MaChucVu", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colName", Caption = "Tên chức vụ", FieldName = "TenChucVu", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colLevel", Caption = "Cấp độ", FieldName = "CapDo", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colHS", Caption = "Hệ số chức danh", FieldName = "HeSoChucDanh", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }
        public static List<GridColumnModel> InitialXepLoai()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Mã xếp loại", FieldName = "MaXL", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colName", Caption = "Tên xếp loại", FieldName = "TenXL", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }
        public static List<GridColumnModel> InitialEmployee()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colMaNV", Caption = "Mã nhân viên", FieldName = "MaNV", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colTenNV", Caption = "Tên nhân viên", FieldName = "TenNV", Visible = true, Frozen = FixedStyle.Left });
                lst.Add(new GridColumnModel() { Name = "colBiDanh", Caption = "Bí danh", FieldName = "BiDanh", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colGioiTinh", Caption = "Giới tính", FieldName = "GioiTinh", Visible = true, Frozen = FixedStyle.Left });
                lst.Add(new GridColumnModel() { Name = "colNgaySinh", Caption = "Ngày sinh", FieldName = "NgaySinh", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colQueQuan", Caption = "Quê quán", FieldName = "QueQuan", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colNoiSinh", Caption = "Nơi sinh", FieldName = "NoiSinh", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colNoiOHienTai", Caption = "Nơi ở hiện tại", FieldName = "NoiOHienTai", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colSoCCCD", Caption = "Số CCCD", FieldName = "SoCCCD", Visible = true   });
                lst.Add(new GridColumnModel() { Name = "colNgayCap", Caption = "Ngày cấp", FieldName = "NgayCap", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colNoiCap", Caption = "Nơi cấp", FieldName = "NoiCap", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colEmail", Caption = "Email", FieldName = "Email", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colSoDienThoai", Caption = "Số điện thoại", FieldName = "SoDienThoai", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colAnh", Caption = "Ảnh", FieldName = "Anh", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colNgayVaoDoan", Caption = "Ngày vào đoàn", FieldName = "NgayVaoDoan", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colNoiVaoDoan", Caption = "Nơi vào đoàn", FieldName = "NoiVaoDoan", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colNgayVaoDang", Caption = "Ngày vào đảng", FieldName = "NgayVaoDang", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colNoiVaoDang", Caption = "Nơi vào đảng", FieldName = "NoiVaoDang", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colNgayVaoLam", Caption = "Ngày vào làm", FieldName = "NgayVaoLam", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colNgayRoiCoQuan", Caption = "Ngày rời cơ quan", FieldName = "NgayRoiCoQuan", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colLyDo", Caption = "Lý do", FieldName = "LyDo", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colHeSoLuong", Caption = "Hệ số lương", FieldName = "HeSoLuong", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colHeSoPhuCap", Caption = "Hệ số phụ cấp", FieldName = "HeSoPhuCap", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colHeSoTNVK", Caption = "Hệ số TNVK", FieldName = "HeSoTNVK", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colSoSocBH", Caption = "Số sổ BH", FieldName = "SoSocBH", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colNgayCapSo", Caption = "Ngày cấp sổ", FieldName = "NgayCapSo", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colNoiCapSo", Caption = "Nơi cấp sổ", FieldName = "NoiCapSo", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colSoThe", Caption = "Số thẻ", FieldName = "SoThe", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colSoTaiKhoan", Caption = "Số tài khoản", FieldName = "SoTaiKhoan", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colNganHang", Caption = "Ngân hàng", FieldName = "NganHang", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colTinhTrangHonNhan", Caption = "Tình trạng hôn nhân", FieldName = "TinhTrangHonNhan", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colTinhTrangSuckhoe", Caption = "Tình trạng sức khỏe", FieldName = "TinhTrangSuckhoe", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colChieuCao", Caption = "Chiều cao", FieldName = "ChieuCao", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCanNang", Caption = "Cân nặng", FieldName = "CanNang", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colNhomMau", Caption = "Nhóm máu", FieldName = "NhomMau", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colNgayNhapNgu", Caption = "Ngày nhập ngũ", FieldName = "NgayNhapNgu", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colNgayXuatNgu", Caption = "Ngày xuất ngũ", FieldName = "NgayXuatNgu", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colQuanHamCaoNhat", Caption = "Quân hàm cao nhất", FieldName = "QuanHamCaoNhat", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colThoiGianNangBacHSL", Caption = "Thời gian nâng bậc HSL", FieldName = "ThoiGianNangBacHSL", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colKhongChoPhepNangLuong", Caption = "Không cho phép nâng lương", FieldName = "KhongChoPhepNangLuong", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colRoiCoQuan", Caption = "Rời cơ quan", FieldName = "RoiCoQuan", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colNghiHuu", Caption = "Nghỉ hưu", FieldName = "NghiHuu", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colLuongCoSo", Caption = "Lương cơ sở", FieldName = "LuongCoSo", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colMaDMXX", Caption = "Định mức xăng xe", FieldName = "DinhMucXangXe", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colMaTG", Caption = "Tôn giáo", FieldName = "TonGiao", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colMaChucVu", Caption = "Chức vụ", FieldName = "ChucVu", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colMaXL", Caption = "Xếp loại", FieldName = "XepLoai", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colMaTT", Caption = "Tỉnh thành", FieldName = "TinhThanh", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colMaTDVH", Caption = "Trình độ văn hóa", FieldName = "TrinhDoVanHoa", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colMaDT", Caption = "Dân tộc", FieldName = "DanToc", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colMaCM", Caption = "Chuyên môn", FieldName = "ChuyenMon", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colMaNN", Caption = "Ngoại ngữ", FieldName = "NgoaiNgu", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colMaTDLLCT", Caption = "Trình độ lý luận chính trị", FieldName = "TrinhDoLyLuanChinhTri", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colMaTTLV", Caption = "Trạng thái làm việc", FieldName = "TrangThaiLamViec", Visible = true });
            }
            catch (Exception ex)
            {
                SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString());
            }
            return lst;
        }

    }
}
