using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

[Table("TrinhDoChuyenMon")]
public class LevelExpertise
{
    [Key]  
    public int MaTDCM { get; set; }

    [Required]  
    [StringLength(150)]  
    public string TenTDCM { get; set; }

    public int MaCM { get; set; }

}
