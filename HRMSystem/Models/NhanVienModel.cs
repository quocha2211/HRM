using HRMSystem.Utilities;
using System;

public class NhanVienModel
{
    public int MaNV { get; set; }
    public string TenNV { get; set; }
    public string BiDanh { get; set; }
    public string GioiTinh { get; set; }
    public string NgaySinh { get; set; }
    public string QueQuan { get; set; }
    public string NoiSinh { get; set; }
    public string NoiOHienTai { get; set; }
    public string SoCCCD { get; set; }
    public string NgayCap { get; set; }
    public string NoiCap { get; set; }
    public string Email { get; set; }
    public string SoDienThoai { get; set; }
    public byte[] Anh { get; set; }
    public string NgayVaoDoan { get; set; }
    public string NoiVaoDoan { get; set; }
    public string NgayVaoDang { get; set; }
    public string NoiVaoDang { get; set; }
    public string NgayVaoLam { get; set; }
    public string NgayRoiCoQuan { get; set; }
    public string LyDo { get; set; }
    public float? HeSoLuong { get; set; }
    public float? HeSoPhuCap { get; set; }
    public float? HeSoTNVK { get; set; }
    public int SoSocBH { get; set; }
    public string NgayCapSo { get; set; }
    public string NoiCapSo { get; set; }
    public string SoThe { get; set; }
    public string SoTaiKhoan { get; set; }
    public string NganHang { get; set; }
    public bool TinhTrangHonNhan { get; set; }
    public string TinhTrangSuckhoe { get; set; }
    public float ChieuCao { get; set; }
    public float CanNang { get; set; }
    public string NhomMau { get; set; }
    public string NgayNhapNgu { get; set; }
    public string NgayXuatNgu { get; set; }
    public string QuanHamCaoNhat { get; set; }
    public int? ThoiGianNangBacHSL { get; set; }
    public bool? KhongChoPhepNangLuong { get; set; }
    public bool? RoiCoQuan { get; set; }
    public bool? NghiHuu { get; set; }
    public float? LuongCoSo { get; set; }

    // Foreign key properties
    public int? MaDMXX { get; set; }
    public int? MaTG { get; set; }
    public int? MaChucVu { get; set; }
    public int? MaXL { get; set; }
    public int? MaTT { get; set; }
    public int? MaTDVH { get; set; }
    public int? MaDT { get; set; }
    public int? MaCM { get; set; }
    public int? MaNN { get; set; }
    public int? MaTDLLCT { get; set; }
    public int? MaTTLV { get; set; }

    public NhanVienModel()
    {
        NgayCap = NgayCapSo = NgayNhapNgu = NgayRoiCoQuan = NgaySinh = NgayVaoDang = NgayVaoDoan = NgayVaoLam = NgayXuatNgu = "";
    }

}
