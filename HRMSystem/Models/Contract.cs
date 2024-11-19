using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Models
{
    [Table("HopDong")]
    public class Contract
    {
        [Key]
        public int? MaHD { get; set; } // MaHD (Primary Key, Identity)
        public int? MaLoaiHD { get; set; } // MaLoaiHD (Nullable, FK to LoaiHopDong)
        public int? MaNV { get; set; } // MaNV (Nullable, FK to NhanVien)
        public DateTime? NgayKy { get; set; } // NgayKy (Ngày ký hợp đồng)
        public DateTime? NgayHetHan { get; set; } // NgayHetHan (Ngày hết hạn hợp đồng)
        public int? ThoiHan { get; set; } // ThoiHan (Thời hạn hợp đồng)
        public string NguoiKy { get; set; } // NguoiKy (Người ký hợp đồng)
        public int? MaBL { get; set; } // MaBL (Nullable, FK to HeSoThangBacLuong)
        public int? MaTL { get; set; } // MaTL (Nullable, FK to ThangLuong)
        public int? MaChucVu { get; set; } // MaChucVu (Nullable, FK to ChucVu)
        public string NoiCap { get; set; } // NoiCap (Nơi cấp hợp đồng)
        public string GhiChu { get; set; } // GhiChu (Ghi chú)
    }
}
