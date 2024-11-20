using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSystem.Models
{
    [Table("NguoiDung")]
    public class User
    {
        [Key]
        public int MaND { get; set; }

        // TenDangNhap is the username (nvarchar)
        public string TenDangNhap { get; set; }

        // MatKhau is the password (nvarchar)
        public string MatKhau { get; set; }

        // MaChucVu is a foreign key referencing the ChucVu table (int)
        public int? MaChucVu { get; set; }

        // Quyen represents the user role (nvarchar)
        public string Quyen { get; set; }

        // MaNV is a foreign key referencing the NhanVien table (int)
        public int? MaNV { get; set; }


    }
}
