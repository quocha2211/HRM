using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Models
{
    [Table("QuaTrinhLuong")]
    public class QuaTrinhLuong
    {
        [Key]
        public int MaQTL { get; set; }
        public DateTime NgayQD { get; set; }
        public DateTime NgayHuong { get; set; }
        public DateTime NgayNangCapLuong { get; set; }
        public int? MaBL { get; set; }
        public int? MaTL { get; set; }
        public float? HSL { get; set; }
        public float? HSPC { get; set; }
        public int? MaMLTT { get; set; }
        public int? MaNV { get; set; }

        
    }
}
