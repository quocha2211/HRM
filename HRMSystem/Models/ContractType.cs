using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Models
{
    [Table("LoaiHopDong")]
    public class ContractType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Để Entity Framework biết rằng MaLoaiHD là Identity
        public int MaLoaiHD { get; set; }

        [Required]
        [StringLength(150)] // Tương ứng với nvarchar(150) trong SQL
        public string TenLoaiHD { get; set; }

        [StringLength(150)] // Tương ứng với nvarchar(150) trong SQL
        public string GhiChu { get; set; }
    }
}
