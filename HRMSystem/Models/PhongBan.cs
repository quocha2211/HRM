using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSystem.Models
{
    [Table("PhongBan")]
    public class PhongBan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaPB { get; set; }  

        [Required]
        [StringLength(150)]
        public string TenPB { get; set; }  

        [Required]
        public int CapDo { get; set; } 

        public int DoTuoiVeHuuNam { get; set; }  

        public int DoTuoiVeHuuNu { get; set; }  
    }
}
