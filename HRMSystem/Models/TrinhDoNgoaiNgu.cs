using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("TrinhDoNgoaiNgu")]
public class TrinhDoNgoaiNgu
{
    [Key]  
    public int MaTDNN { get; set; }

    [Required]  
    [StringLength(150)] 
    public string TenTDNN { get; set; }

    public ICollection<Language> Languages { get; set; }  
}
