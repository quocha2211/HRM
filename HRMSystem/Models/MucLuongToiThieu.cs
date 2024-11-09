using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSystem.Models
{
    [Table("MucLuongToiThieu")]
    public class MucLuongToiThieu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaMLTT { get; set; }  // Primary Key, auto-incremented

        [Required]
        public DateTime NgayAD { get; set; }  // Effective Date

        [Required]
        public int MLTTVung { get; set; }  // Minimum Salary for Region

        [Required]
        public double MLTTC { get; set; }  // Minimum Salary for Category
    }
}
