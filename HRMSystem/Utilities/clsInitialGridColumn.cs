using DevExpress.Utils.Filtering.Internal;
using DevExpress.XtraGrid.Columns;
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

        public static List<GridColumnModel> InitialBangLuong()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "MA", FieldName = "MaHD", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "ma", FieldName = "MaLoaiHD", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "MaNV", FieldName = "MaNV", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Tên nhân viên", FieldName = "TenNV", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Hệ số lương", FieldName = "HeSo", DisplayFormat = "N0", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Lương tối thiểu vùng", FieldName = "MLTTC", DisplayFormat = "N0", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Lương cơ bản", FieldName = "LuongCoBan", DisplayFormat = "N0", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Số công", FieldName = "NgayCongTrongThang", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Lương thời gian", FieldName = "LuongThoiGian", DisplayFormat = "N0", Visible = true });
                //lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Lương trách nhiệm", FieldName = "LuongThoiGian", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Trợ cấp xăng xe", FieldName = "DMXX", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Tiền ăn", FieldName = "TienAn", DisplayFormat = "N0", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Tổng lương", FieldName = "TongLuong", DisplayFormat = "N0", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Bảo hiểm xã hội", FieldName = "BHXH", DisplayFormat = "N0", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Bảo hiểm y tế", FieldName = "BHYT", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Bảo hiểm thất nghiệp", FieldName = "BHTN", DisplayFormat = "N0", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Số tiền ứng", FieldName = "SoTienTU", DisplayFormat = "N0", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Lương giảm trừ", FieldName = "LuongGiamTru", DisplayFormat = "N0", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Lương thực nhận", FieldName = "LuongThucNhan", DisplayFormat = "n0", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }

        public static List<GridColumnModel> InitialUser()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "MA", FieldName = "MaND", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Tên nhân viên", FieldName = "TenNV", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Tên đăng nhập", FieldName = "TenDangNhap", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Mật khẩu", FieldName = "MatKhau", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Quyền hạn", FieldName = "Quyen", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }

        public static List<GridColumnModel> InitialDieuChuyenCongTac()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "MA", FieldName = "MaHD", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "ma", FieldName = "MaCCT", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Tên nhân viên", FieldName = "TenNV", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "MaNV", FieldName = "MaNV", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Ngày chuyển", FieldName = "NgayChuyen", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Tên chức vụ", FieldName = "TenChucVu", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Thang bậc lương", FieldName = "TenTL", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Ghi chú", FieldName = "GhiChu", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }

        public static List<GridColumnModel> InitialContract()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "MA", FieldName = "MaHD", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "ma", FieldName = "MaLoaiHD", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Tên nhân viên", FieldName = "TenNV", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Loại hợp đồng", FieldName = "TenLoaiHD", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "MaNV", FieldName = "MaNV", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Ngày ký", FieldName = "NgayKy", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Thời hạn", FieldName = "ThoiHan", Visible = true });
                //lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Tên phòng ban", FieldName = "TenPB", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Ghi chú", FieldName = "GhiChu", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }

        public static List<GridColumnModel> InitialThanNhan()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "MA", FieldName = "MaHD", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "ma", FieldName = "MaQHTN", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Tên nhân viên", FieldName = "TenNV", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Quan hệ thân nhân", FieldName = "TenQHTN", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "MaNV", FieldName = "MaNV", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Tên thân nhân", FieldName = "HoVaTen", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Ngày sinh", FieldName = "NgaySinh", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Nơi ở", FieldName = "NoiO", Visible = true });
                //lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Tên phòng ban", FieldName = "TenPB", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Ghi chú", FieldName = "GhiChu", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }

        public static List<GridColumnModel> InitialEmployeeRanking()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "MA", FieldName = "MaXLCB", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Tên nhân viên", FieldName = "TenNV", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "MaNV", FieldName = "MaNV", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Xếp loại", FieldName = "XepLoai", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Danh hiệu", FieldName = "DanhHieu", Visible = true });
                //lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Tên phòng ban", FieldName = "TenPB", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Ghi chú", FieldName = "GhiChu", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }

        public static List<GridColumnModel> InitialComboLoaiHopDong()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "MA", FieldName = "MaLoaiHD", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Loại hợp đồng", FieldName = "TenLoaiHD", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }

        public static List<GridColumnModel> InitialComboQHTN()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "MA", FieldName = "MaQHTN", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Quan hệ thân nhân", FieldName = "TenQHTN", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }


        public static List<GridColumnModel> InitialComboDuty()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "MA", FieldName = "MaChucVu", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Tên chức vụ", FieldName = "TenChucVu", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }

        public static List<GridColumnModel> InitialComboSalary()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "MA", FieldName = "MaBL", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Bậc lương", FieldName = "TenBL", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }

        public static List<GridColumnModel> InitialComboThangLuong()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "MA", FieldName = "MaTL", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Bậc lương", FieldName = "TenTL", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }

        public static List<GridColumnModel> InitialComboDepartment()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "MA", FieldName = "MaPB", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Tên phòng ban", FieldName = "TenPB", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }

        public static List<GridColumnModel> InitialComboEmployee()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "MA", FieldName = "MaNV", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Tên nhân viên", FieldName = "TenNV", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }

        public static List<GridColumnModel> InitialLevelEducational()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "MA", FieldName = "MaTDVH", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Tên trình độ văn hoá", FieldName = "TenTDVH", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }

        public static List<GridColumnModel> InitialDinhMucXangXe()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "MA", FieldName = "MaCC", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Tên phương tiện", FieldName = "TenPTien", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Định mức xăng xe", FieldName = "DMXX", DisplayFormat = "N0", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }

        public static List<GridColumnModel> InitialBangTamUng()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "MA", FieldName = "MaBTU", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Tháng", FieldName = "Thang", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Năm", FieldName = "Nam", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Số tiền tạm ứng", FieldName = "SoTienTU", DisplayFormat = "N0", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Diễn giải", FieldName = "DienGiai", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Nhân viên", FieldName = "TenNV", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Ngày tạm ứng", FieldName = "NgayTU", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }


        public static List<GridColumnModel> InitialChamCong()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "MA", FieldName = "MaCCTL", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Tên chấm công", FieldName = "TenCCTL", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Năm", FieldName = "Nam", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Tháng", FieldName = "Thang", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Ngày tính công", FieldName = "NgayTinhCong", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Số ngày công", FieldName = "NgayCongTrongThang", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }

        public static List<GridColumnModel> InitialMinSalary()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "MA", FieldName = "MaCC", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Ngày áp dụng", FieldName = "NgayAD", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Vùng áp dụng", FieldName = "MLTTVung", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Mức lương tối thiểu", FieldName = "MLTTC", DisplayFormat = "N0", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }

        public static List<GridColumnModel> InitialKTKL()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Mã ", FieldName = "MaKTKL", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Tên nhân viên ", FieldName = "TenNV", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Tên khen thưởng kỷ luật", FieldName = "TenKTKL", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Số quyết định", FieldName = "SoQD", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Ngày quyết định", FieldName = "NgayQD", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Hình thức", FieldName = "HinhThuc", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Đơn vị khen thưởng kỷ luật", FieldName = "DonviKTKL", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }


        public static List<GridColumnModel> InitialDegree()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Mã Chứng chỉ", FieldName = "MaCC", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Tên Chứng chỉ", FieldName = "TenCC", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Tên nhân viên", FieldName = "TenNV", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Ngày cấp", FieldName = "NgayCap", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Ngày hết hạn", FieldName = "NgayHetHan", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Nơi cấp", FieldName = "NoiCap", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }

        public static List<GridColumnModel> InitialSalaryScale()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Mã thang lương", FieldName = "MaTL", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Tên thang lương", FieldName = "TenTL", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Diễn giải", FieldName = "DienGiai", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Hệ số", FieldName = "HeSo", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }

        public static List<GridColumnModel> InitialLevelLanguage()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Id", FieldName = "MaNN", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Ngoại ngữ", FieldName = "TenNN", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Trình độ Ngoại ngữ", FieldName = "TenTDNN", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }

        public static List<GridColumnModel> InitialLanguage()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Id", FieldName = "MaNN", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Ngoại ngữ", FieldName = "TenNN", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }

        public static List<GridColumnModel> InitialWorkStatus()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Id", FieldName = "MaTTLV", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Trạng thái làm việc", FieldName = "TenTTLV", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }

        public static List<GridColumnModel> InitialLevelExpertise()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Id", FieldName = "MaTDCM", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Chuyên Môn", FieldName = "TenCM", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Trình độ chuyên môn", FieldName = "TenTDCM", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }

        public static List<GridColumnModel> InitialExpertise()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Id", FieldName = "MaCM", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Chuyên Môn", FieldName = "TenCM", Visible = true });
            }
            catch (Exception ex) { SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString()); }
            return lst;
        }
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

        public static List<GridColumnModel> InitialComboChucVu()
        {
            List<GridColumnModel> lst = new List<GridColumnModel>();
            try
            {
                lst.Add(new GridColumnModel() { Name = "colCode", Caption = "Mã chức vụ", FieldName = "MaChucVu", Visible = false });
                lst.Add(new GridColumnModel() { Name = "colName", Caption = "Tên chức vụ", FieldName = "TenChucVu", Visible = true });
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
                lst.Add(new GridColumnModel() { Name = "colHeSoLuong", Caption = "Hệ số lương", FieldName = "HeSo", Visible = false });
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
                //lst.Add(new GridColumnModel() { Name = "colKhongChoPhepNangLuong", Caption = "Không cho phép nâng lương", FieldName = "KhongChoPhepNangLuong", Visible = true });
                //lst.Add(new GridColumnModel() { Name = "colRoiCoQuan", Caption = "Rời cơ quan", FieldName = "RoiCoQuan", Visible = true });
                //lst.Add(new GridColumnModel() { Name = "colNghiHuu", Caption = "Nghỉ hưu", FieldName = "NghiHuu", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colLuongCoSo", Caption = "Lương cơ sở", FieldName = "MLTTC", DisplayFormat = "N0", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colMaDMXX", Caption = "Tên phương tiện", FieldName = "TenPTien", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colMaDMXX", Caption = "Định mức xăng xe", FieldName = "DMXX", DisplayFormat = "N0", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colMaTG", Caption = "Tôn giáo", FieldName = "TenTG", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colMaChucVu", Caption = "Chức vụ", FieldName = "TenChucVu", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colMaXL", Caption = "Xếp loại", FieldName = "XepLoai", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colMaTT", Caption = "Tỉnh thành", FieldName = "TenTT", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colMaTDVH", Caption = "Trình độ văn hóa", FieldName = "TenTDVH", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colMaDT", Caption = "Dân tộc", FieldName = "TenDT", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colMaCM", Caption = "Chuyên môn", FieldName = "TenCM", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colMaNN", Caption = "Ngoại ngữ", FieldName = "TenNN", Visible = true });
                //lst.Add(new GridColumnModel() { Name = "colMaTDLLCT", Caption = "Trình độ lý luận chính trị", FieldName = "TrinhDoLyLuanChinhTri", Visible = true });
                lst.Add(new GridColumnModel() { Name = "colMaTTLV", Caption = "Trạng thái làm việc", FieldName = "TenTTLV", Visible = true });
            }
            catch (Exception ex)
            {
                SQLiteHelper.SaveToLog(ex.Message, "clsInitialGridColumn", ex.ToString());
            }
            return lst;
        }

    }
}
