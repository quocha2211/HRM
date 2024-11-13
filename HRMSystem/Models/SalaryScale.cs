using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSystem.Models
{
    [Table("ThangLuong")]
    public class SalaryScale
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaTL { get; set; }  

        [Required]
        [StringLength(150)]
        public string TenTL { get; set; } 

        [StringLength(100)]
        public string DienGiai { get; set; }  
    }
}
