using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Models
{
    [Table("HeSoThangBacLuong")]
    public class SalaryGradeCoefficient
    {
        public int MaBL { get; set; } // MaBL (Primary Key, Identity)
        public int? MaTL { get; set; } // MaTL (Nullable, FK to ThangLuong)
        public DateTime NgayQD { get; set; } // NgayQD (Ngày quyết định áp dụng hệ số)
        public float? HeSo { get; set; } // HeSo (Hệ số thang bậc lương)
    }
}
