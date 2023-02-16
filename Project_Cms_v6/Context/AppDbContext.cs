using Microsoft.EntityFrameworkCore;
using Project_Cms_v6.Models;

namespace Project_Cms_v6.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Employees> Employees { get; set; }
        public DbSet<AccountRoles> AccountRoles { get; set; }
        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Roles> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountRoles>().HasNoKey();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
