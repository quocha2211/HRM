using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Models
{
    [Table("BangLuong")]
    public class Payroll
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaBangL { get; set; } // MaBangL (Primary Key, Identity)
        public int MaCCTL { get; set; } // MaCCTL (Nullable, FK to ChamCongTL)
        public int Thang { get; set; } // Thang
        public int Nam { get; set; } // Nam
        public float HSL { get; set; } // HSL (Hệ số lương)
        public float HSPC { get; set; } // HSPC (Hệ số phụ cấp)
        public int MaMLTT { get; set; } // MaMLTT (Nullable, FK to MucLuongToiThieu)
        public int MucLuongTTV { get; set; } // MucLuongTTV (Mức lương TTV)
        public float MucLuongTTC { get; set; } // MucLuongTTC (Mức lương TTC)
        public float NgayCong { get; set; } // NgayCong (Số ngày công)
        public float MucLuongCoSo { get; set; } // MucLuongCoSo (Mức lương cơ sở)
        public float PhuCapTTCV { get; set; } // PhuCapTTCV (Phụ cấp TTCV)
        public float TienLuongBQMN { get; set; } // TienLuongBQMN (Tiền lương BQMN)
        public float LuongThoiGian { get; set; } // LuongThoiGian (Lương theo thời gian)
        public float NgayHuongCong100PT { get; set; } // NgayHuongCong100PT
        public float TienAnGiuaCa { get; set; } // TienAnGiuaCa (Tiền ăn giữa ca)
        public float CongK3 { get; set; } // CongK3
        public float TienK3 { get; set; } // TienK3
        public float CongTgNgayThuong { get; set; } // CongTgNgayThuong
        public float CongTGNgayNghi { get; set; } // CongTGNgayNghi
        public float CongTGNgayLe { get; set; } // CongTGNgayLe
        public float TienThuong { get; set; } // TienThuong
        public int MaDMXX { get; set; } // MaDMXX (Nullable, FK to DinhMucXangXe)
        public float LeTet { get; set; } // LeTet (Lễ Tết)
        public string GhiChuLeTet { get; set; } // GhiChuLeTet (Ghi chú lễ Tết)
        public float TongLuong { get; set; } // TongLuong (Tổng lương)
        public float TruBHYT { get; set; } // TruBHYT (Trừ bảo hiểm y tế)
        public float TruBHXH { get; set; } // TruBHXH (Trừ bảo hiểm xã hội)
        public float TruBHTN { get; set; } // TruBHTN (Trừ bảo hiểm thất nghiệp)
        public float SoTienConNhan { get; set; } // SoTienConNhan (Số tiền còn nhận)
        public int MucThue { get; set; } // MucThue (Mức thuế)
        public float ThuePhaiNop { get; set; } // ThuePhaiNop (Thuế phải nộp)
        public float ThueCaNam { get; set; } // ThueCaNam (Thuế cả năm)
        public float TamUng { get; set; } // TamUng (Tạm ứng)
        public float TongThucNhan { get; set; } // TongThucNhan (Tổng thực nhận)
        public int MaPB { get; set; } // MaPB (Nullable, FK to PhongBan)
        public int MaChucVu { get; set; } // MaChucVu (Nullable, FK to ChucVu)
        public int MaNV { get; set; } // MaNV (Nullable, FK to NhanVien)
        public int MaND { get; set; } // MaND (Nullable, FK to NguoiDung)
    }
}
