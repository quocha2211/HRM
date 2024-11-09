using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSystem.Models
{
    [Table("DinhMucXangXe")]
    public class DinhMucXangXe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaDMXX { get; set; }  // Primary Key, auto-incremented

        [StringLength(150)]
        public string TenPTien { get; set; }  // Payment Method (optional)

        [Required]
        public double DMXX { get; set; }  // Fuel Allocation Amount (in currency or other units)
    }
}
