
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("ChuyenMon")]
public class Expertise
{
    [Key]  
    public int MaCM { get; set; }

    [Required]  
    [StringLength(150)]  
    public string TenCM { get; set; }

}
