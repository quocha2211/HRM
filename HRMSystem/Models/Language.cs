using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("NgoaiNgu")]
public class Language
{
    [Key]  // Marks MaNN as the primary key
    public int MaNN { get; set; }

    [Required]  // TenNN is required (non-nullable)
    [StringLength(100)]  // Max length of 100 characters for TenNN
    public string TenNN { get; set; }

}
