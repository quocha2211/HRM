using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Models
{
    [Table("QuaTrinhCongTac")]
    public class QuaTrinhCongTac
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? MaQTCT { get; set; }

        public int? MaNV { get; set; }

        public int? MaPB { get; set; }

        public int? MaChucVu { get; set; }

        public DateTime? NgayBatDau { get; set; }

        public DateTime? NgayKetThuc { get; set; }

        public DateTime? Ngay { get; set; }
    }
}
