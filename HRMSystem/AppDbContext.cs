using HRMSystem.Models;
using System.Data.Entity;

public class AppDbContext : DbContext
{
    public DbSet<Employee> NhanViens { get; set; }
    public DbSet<User> NguoiDungs { get; set; }
    public DbSet<Expertise> ChuyenMons { get; set; }
    public DbSet<Language> NgoaiNgus { get; set; }
    public DbSet<LevelExpertise> TrinhDoChuyenMons { get; set; }
    public DbSet<LevelLanguage>  TrinhDoNgoaiNgus { get; set; }

    public DbSet<SalaryScale> ThangLuongs { get; set; }

    public DbSet<LevelEducational> TrinhDoVanHoas { get; set; }

    public DbSet<Certificate> ChungChis { get; set; }

    public DbSet<MinSalary> MucLuongToiThieus { get; set; }
    public DbSet<DinhMucXangXe> DinhMucXangXes { get; set; }
    public DbSet<PhongBan> PhongBans { get; set; }
    public DbSet<ChucVu> ChucVus { get; set; }
    public DbSet<QuanHeThanNhan> QuanHeThanNhans { get; set; }

    public DbSet<EmployeeRanking> XepLoaiNhanViens { get; set; }
    public DbSet<EmployeeTransfer> DieuChuyenCongTacs { get; set; }

    public DbSet<Payroll> BangLuongs { get; set; }
    public DbSet<Contract> HopDongs { get; set; }
    public DbSet<TimeKeeping> ChamCongTLs { get; set; }

    public DbSet<SalaryAdvance> BangTamUngs { get; set; }
    public DbSet<TonGiao> TonGiaos { get; set; }
    public DbSet<TrangThaiLamViec> TrangThaiLamViecs { get; set; }
    public DbSet<TinhThanh> TinhThanhs { get; set; }
    public DbSet<DanToc> DanTocs { get; set; }

    public DbSet<ContractType> LoaiHopDongs { get; set; }
    public DbSet<ThanNhan> ThanNhans { get; set; }
    public DbSet<KhenThuongKyLuat> khenThuongKyLuats { get; set; }

    public DbSet<QuaTrinhDaoTao> QuaTrinhDaoTaos { get; set; }

    public DbSet<QuaTrinhLuong> QuaTrinhLuongs { get; set; }
    public DbSet<QuaTrinhCongTac> QuaTrinhCongTacs { get; set; }
    public DbSet<ChamCongNgay> ChamCongNgays { get; set; }

    public AppDbContext() : base("name=MyConnectionString")
    {
    }
}
