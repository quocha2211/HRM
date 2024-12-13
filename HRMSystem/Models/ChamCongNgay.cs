using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSystem.Models
{
    [Table("ChamCongNgay")]
    public class ChamCongNgay
    {
        [Key]
        public int ID { get; set; }        
        public int? MaNV { get; set; }      
        public DateTime? Ngay { get; set; } 
        public string NoiDung { get; set; } 
    }
}
