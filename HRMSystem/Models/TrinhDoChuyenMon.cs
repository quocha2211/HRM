using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

[Table("TrinhDoChuyenMon")]
public class TrinhDoChuyenMon
{
    [Key]  
    public int MaTDCM { get; set; }

    [Required]  
    [StringLength(150)]  
    public string TenTDCM { get; set; }

    public ICollection<Expertise> ChuyenMons { get; set; } 
}
