using HRMSystem.Models;
using System.Data.Entity;

public class AppDbContext : DbContext
{
    public DbSet<Users> NhanViens { get; set; }
    public DbSet<Expertise> ChuyenMons { get; set; }
    public DbSet<Language> NgoaiNgus { get; set; }
    public DbSet<TrinhDoChuyenMon> TrinhDoChuyenMons { get; set; }
    public DbSet<TrinhDoNgoaiNgu>  TrinhDoNgoaiNgus { get; set; }




    public AppDbContext() : base("name=MyConnectionString")
    {
    }
}
