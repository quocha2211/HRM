using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("TrinhDoNgoaiNgu")]
public class LevelLanguage
{
    [Key]  
    public int MaTDNN { get; set; }

    [Required]  
    [StringLength(150)] 
    public string TenTDNN { get; set; }

    public int MaNN { get; set; }
}
