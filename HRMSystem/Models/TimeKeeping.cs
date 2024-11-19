using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Models
{
    [Table("ChamCongTL")]
    public class TimeKeeping
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaCCTL { get; set; }  // Primary Key, auto-incremented
        public string TenCCTL { get; set; }  // Name of the attendance record
        [Key, Column(Order = 2)]
        public int Nam { get; set; }  // Year
        [Key, Column(Order = 3)]
        public int Thang { get; set; }  // Month
        public bool? Khoa { get; set; }  // Lock/Unlock status (nullable)
        public DateTime? NgayTinhCong { get; set; }  // Date of time calculation (nullable)
        public double? NgayCongTrongThang { get; set; }  // Days worked in the month (nullable)
        public bool? TrangThai { get; set; }  // Status (nullable)
        [Key, Column(Order = 1)]
        public int? MaNV { get; set; }  // Status (nullable)
    }
}
