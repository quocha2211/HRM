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

        public double Bac1 { get; set; }
        public double Bac2 { get; set; }
        public double Bac3 { get; set; }
        public double Bac4 { get; set; }
        public double Bac5 { get; set; }
        public double Bac6 { get; set; }
        public double Bac7 { get; set; }
        public double Bac8 { get; set; }
        public double Bac9 { get; set; }
        public double Bac10 { get; set; }
        public double Bac11 { get; set; }
        public double Bac12 { get; set; }

    }
}
