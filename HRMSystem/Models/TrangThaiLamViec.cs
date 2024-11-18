using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Models
{
    [Table("TrangThaiLamViec")]
    public class TrangThaiLamViec
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaTTLV { get; set; } 

        [Required]
        [StringLength(150)]
        public string TenTTLV { get; set; }  

        [Required]
        public int KyHieu { get; set; }  

        
    }
}
