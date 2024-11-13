using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSystem.Models
{
    [Table("XepLoaiCanBo")]
    public class EmployeeRanking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaXLCB { get; set; }
        [Required]
        public int MaNV { get; set; } 
        public string XepLoai { get; set; } 
        public string DanhHieu { get; set; } 
        [Required]
        public int MaPB { get; set; } 
        public string GhiChu { get; set; } 

    }
}
