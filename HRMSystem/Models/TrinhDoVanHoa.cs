using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Models
{
    [Table("TrinhDoVanHoa")]
    public class TrinhDoVanHoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaTDVH { get; set; }  // Primary Key, auto-incremented

        [Required]
        [StringLength(150)]
        public string TenTDVH { get; set; }  // Education Level Name
    }

}
