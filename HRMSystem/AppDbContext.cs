using HRMSystem.Models;
using System.Data.Entity;

public class AppDbContext : DbContext
{
    public DbSet<Users> NhanViens { get; set; }
    public DbSet<Expertise> ChuyenMons { get; set; }
    public DbSet<Language> NgoaiNgus { get; set; }
    public DbSet<TrinhDoChuyenMon> TrinhDoChuyenMons { get; set; }
    public DbSet<TrinhDoNgoaiNgu>  TrinhDoNgoaiNgus { get; set; }

    public DbSet<ThangLuong> ThangLuongs { get; set; }

    public DbSet<TrinhDoVanHoa> TrinhDoVanHoas { get; set; }

    public DbSet<ChungChi> ChungChis { get; set; }

    public DbSet<MucLuongToiThieu> MucLuongToiThieus { get; set; }
    public DbSet<DinhMucXangXe> DinhMucXangXes { get; set; }
    public DbSet<PhongBan> PhongBans { get; set; }
    public DbSet<ChucVu> ChucVus { get; set; }
    public DbSet<QuanHeThanNhan> QuanHeThanNhans { get; set; }

    public AppDbContext() : base("name=MyConnectionString")
    {
    }
}
