using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Models
{

    [Table("TinhThanh")]
    public class TinhThanh
    {
        [Key]
        public int MaTT { get; set; }

        [Required]
        [StringLength(150)]
        public string TenTT { get; set; }

    }

    [Table("DanToc")]
    public class DanToc
    {
        [Key]
        public int MaDT { get; set; }

        [Required]
        [StringLength(150)]
        public string TenDT { get; set; }

    }

}
