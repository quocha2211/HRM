using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSystem.Models
{
    [Table("KhenThuongKyLuat")]
    public class KhenThuongKyLuat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaKTKL { get; set; }  // Mã khen thưởng kỷ luật
        public int? SoQD { get; set; }   // Số quyết định
        public DateTime? NgayQD { get; set; }  // Ngày quyết định
        public string TenKTKL { get; set; }  // Tên khen thưởng kỷ luật
        public string LyDo { get; set; }  // Lý do
        public string HinhThuc { get; set; }  // Hình thức
        public string DonviKTKL { get; set; }  // Đơn vị khen thưởng kỷ luật
        public int? MaNV { get; set; }  // Mã nhân viên (Khóa ngoại)
    }
}
