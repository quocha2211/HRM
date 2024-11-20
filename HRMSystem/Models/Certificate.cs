
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSystem.Models
{
    [Table("ChungChi")]
    public class Certificate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaCC { get; set; }  // Primary Key, auto-incremented

        [Required]
        [StringLength(100)]
        public string TenCC { get; set; }  // Certification Name

        public int MaNV { get; set; }  // Foreign Key referencing NhanVien table (nullable)

        [Required]
        public DateTime NgayCap { get; set; }  // Date of Issuance

        [Required]
        public DateTime NgayHetHan { get; set; }  // Expiry Date

        [Required]
        [StringLength(200)]
        public string NoiCap { get; set; }  // Issuing Organization

        // Navigation Property for the NhanVien relationship
        [ForeignKey("MaNV")]
        public virtual Employee NhanVien { get; set; }
    }
}
