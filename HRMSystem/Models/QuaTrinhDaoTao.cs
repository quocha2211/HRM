using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Models
{
    [Table("QuaTrinhDaoTao")]
    public class QuaTrinhDaoTao
    {
        [Key]
        public int? MaQTDT { get; set; }  // Primary key, auto-incremented
        public int? MaNV { get; set; }    // Nullable foreign key to the NhanViens table (if applicable)
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayHetHan { get; set; }
        public string TruongDaoTao { get; set; }
        public string NuocDaoTao { get; set; }
        public string NganhDaoTao { get; set; }
        public string HinhThucDaoTao { get; set; }
        public string TrinhDoDaoTao { get; set; }
        public int? MaPB { get; set; }    // Nullable foreign key to the PhongBan table (if applicable)
        public int? MaChucVu { get; set; } // Nullable foreign key to the ChucVu table (if applicable)
    }
}
