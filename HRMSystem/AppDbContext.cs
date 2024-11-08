using HRMSystem.Models;
using System.Data.Entity;

public class AppDbContext : DbContext
{
    public DbSet<Users> NhanVien { get; set; }

    public AppDbContext() : base("name=MyConnectionString")
    {
    }
}
