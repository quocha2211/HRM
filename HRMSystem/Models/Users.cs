using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRMSystem.Models
{
    [Table("NhanVien")]
    public class Users
    {
        [Key]
        public int MaNV { get; set; }

        [Required]
        [StringLength(150)]
        public string TenNV { get; set; }

        [Required]
        [StringLength(50)]
        public string BiDanh { get; set; }

        [Required]
        [StringLength(5)]
        public string GioiTinh { get; set; }

        [Required]
        public DateTime NgaySinh { get; set; }

        [Required]
        [StringLength(150)]
        public string QueQuan { get; set; }

        [Required]
        [StringLength(100)]
        public string NoiSinh { get; set; }

        [Required]
        [StringLength(150)]
        public string NoiOHienTai { get; set; }

        [Required]
        [StringLength(15)]
        public string SoCCCD { get; set; }

        [Required]
        public DateTime NgayCap { get; set; }

        [Required]
        [StringLength(100)]
        public string NoiCap { get; set; }

        [Required]
        [StringLength(70)]
        public string Email { get; set; }

        [Required]
        [StringLength(100)]
        public string SoDienThoai { get; set; }

        public byte[] Anh { get; set; }

        [Required]
        public DateTime NgayVaoDoan { get; set; }

        [Required]
        [StringLength(150)]
        public string NoiVaoDoan { get; set; }

        [Required]
        public DateTime NgayVaoDang { get; set; }

        [Required]
        [StringLength(150)]
        public string NoiVaoDang { get; set; }

        [Required]
        public DateTime NgayVaoLam { get; set; }

        public DateTime NgayRoiCoQuan { get; set; }

        [StringLength(150)]
        public string LyDo { get; set; }

        public double HeSoLuong { get; set; }

        public double HeSoPhuCap { get; set; }

        public double HeSoTNVK { get; set; }

        [Required]
        public int SoSocBH { get; set; }

        [Required]
        public DateTime NgayCapSo { get; set; }

        [Required]
        [StringLength(150)]
        public string NoiCapSo { get; set; }

        [Required]
        [StringLength(30)]
        public string SoThe { get; set; }

        [Required]
        [StringLength(20)]
        public string SoTaiKhoan { get; set; }

        [Required]
        [StringLength(100)]
        public string NganHang { get; set; }

        [Required]
        public bool TinhTrangHonNhan { get; set; }

        [Required]
        [StringLength(50)]
        public string TinhTrangSuckhoe { get; set; }

        public double ChieuCao { get; set; }

        public double CanNang { get; set; }

        [Required]
        [StringLength(50)]
        public string NhomMau { get; set; }

        public DateTime NgayNhapNgu { get; set; }

        public DateTime NgayXuatNgu { get; set; }

        [StringLength(50)]
        public string QuanHamCaoNhat { get; set; }

        public int ThoiGianNangBacHSL { get; set; }

        public bool KhongChoPhepNangLuong { get; set; }

        public bool RoiCoQuan { get; set; }

        public bool NghiHuu { get; set; }

        public double LuongCoSo { get; set; }

        public int MaDMXX { get; set; }
        public int MaTG { get; set; }
        public int MaChucVu { get; set; }
        public int MaXL { get; set; }
        public int MaTT { get; set; }
        public int MaTDVH { get; set; }
        public int MaDT { get; set; }
        public int MaCM { get; set; }
        public int MaNN { get; set; }
        public int MaTDLLCT { get; set; }
        public int MaTTLV { get; set; }

        //// Navigation Properties (Foreign Key Relationships)
        //public virtual ChucVu ChucVu { get; set; }
        //public virtual ChuyenMon ChuyenMon { get; set; }
        //public virtual DinhMucXangXe DinhMucXangXe { get; set; }
        //public virtual DanToc DanToc { get; set; }
        //public virtual NgoaiNgu NgoaiNgu { get; set; }
        //public virtual TrinhDoLyLuanChinhTri TrinhDoLyLuanChinhTri { get; set; }
        //public virtual TrinhDoVanHoa TrinhDoVanHoa { get; set; }
        //public virtual TonGiao TonGiao { get; set; }
        //public virtual TinhThanh TinhThanh { get; set; }
        //public virtual TrangThaiLamViec TrangThaiLamViec { get; set; }
        //public virtual XepLoai XepLoai { get; set; }
    }
}
