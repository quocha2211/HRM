using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSystem.Models
{
    [Table("ThanNhan")]
    public class ThanNhan
    {
        // Khóa chính (Primary Key)
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Để Entity Framework biết rằng MaTN là Identity
        public int? MaTN { get; set; }

        // Họ và tên người thân (bắt buộc)
        [Required]
        [StringLength(50)] // Tương ứng với nvarchar(50) trong SQL
        public string HoVaTen { get; set; }

        // Ngày sinh của người thân
        [Required]
        public DateTime? NgaySinh { get; set; }

        // Nghề nghiệp của người thân (bắt buộc)
        [Required]
        [StringLength(150)] // Tương ứng với nvarchar(150) trong SQL
        public string NgheNghiep { get; set; }

        // Nơi ở của người thân (bắt buộc)
        [Required]
        [StringLength(150)] // Tương ứng với nvarchar(150) trong SQL
        public string NoiO { get; set; }

        // Khóa ngoại liên kết đến bảng QuanHeThanNhan (Có thể NULL)
        public int? MaQHTN { get; set; }

        // Khóa ngoại liên kết đến bảng NhanVien (Có thể NULL)
        public int? MaNV { get; set; }

        // Ghi chú (Có thể NULL)
        [StringLength(150)] // Tương ứng với nvarchar(150) trong SQL
        public string GhiChu { get; set; }
      
    }
}
