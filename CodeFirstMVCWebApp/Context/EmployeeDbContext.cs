using CodeFirstMVCWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstMVCWebApp.Context
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {

        }

        public EmployeeDbContext()
        {
        }

        public DbSet<Employee> employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-GON2OH60;Database=EmployeeDB;Trusted_Connection=True;TrustServerCertificate=true");
        }
    }
}
