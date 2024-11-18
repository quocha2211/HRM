using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Models
{
    [Table("TonGiao")]
    public class TonGiao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaTG { get; set; }  // Primary Key, auto-incremented

        [StringLength(150)]
        public string TenTG { get; set; }  // Payment Method (optional)

    }
}
