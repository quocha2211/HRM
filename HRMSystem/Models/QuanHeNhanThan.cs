using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSystem.Models
{
    [Table("QuanHeThanNhan")]
    public class QuanHeThanNhan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaQHTN { get; set; }  // Primary Key, auto-incremented

        [Required]
        [StringLength(50)]
        public string TenQHTN { get; set; }  // Relationship name (e.g., "Father", "Mother", etc.)
    }
}
