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
        public int MaCCT { get; set; } // MaCCT (Primary Key, Identity)
        public DateTime NgayChuyen { get; set; } // NgayChuyen
        public string SoQD { get; set; } // SoQD
        [Required]
        public int MaPB { get; set; } // MaPB (Nullable, FK to PhongBan)
        [Required]
        public int MaChucVu { get; set; } // MaChucVu (Nullable, FK to ChucVu)
        [Required]
        public int MaHD { get; set; } // MaHD (Nullable, FK to HopDong)
        [Required]
        public int MaNV { get; set; } // MaNV (Nullable, FK to NhanVien)
        [Required]
        public int MaBL { get; set; } // MaBL (Nullable, FK to HeSoThangBacLuong)
        public string GhiChu { get; set; } // GhiChu (Nullable)

    }
}
