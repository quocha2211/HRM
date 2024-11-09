using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSystem.Models
{
    [Table("ChucVu")]
    public class ChucVu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaChucVu { get; set; }  // Primary Key, auto-incremented

        [Required]
        [StringLength(150)]
        public string TenChucVu { get; set; }  // Job Title (Required)

        [Required]
        public int CapDo { get; set; }  // Job Level (Required)

        [Required]
        public double HeSoChucDanh { get; set; }  // Job Position Coefficient (Required)
    }
}
