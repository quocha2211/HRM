using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Models
{
    [Table("DieuChuyenCongTac")]
    public class EmployeeTransfer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? MaCCT { get; set; } // MaCCT (Primary Key, Identity)
        public DateTime? NgayChuyen { get; set; } // NgayChuyen
        public string SoQD { get; set; } // SoQD
        public int? MaPB { get; set; } // MaPB (Nullable, FK to PhongBan)
        public int? MaChucVu { get; set; } // MaChucVu (Nullable, FK to ChucVu)
        public int? MaHD { get; set; } // MaHD (Nullable, FK to HopDong)
        public int? MaNV { get; set; } // MaNV (Nullable, FK to NhanVien)
        public int? MaTL { get; set; } // MaBL (Nullable, FK to HeSoThangBacLuong)
        public string GhiChu { get; set; } // GhiChu (Nullable)

    }
}
