using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WBL_EF_CORE.Models;

namespace WBL_EF_CORE.SqlDbContext
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source =Localhost; Initial Catalog = EcoomerceWBLDB;Integrated Security = true; Trust Server Certificate =true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
