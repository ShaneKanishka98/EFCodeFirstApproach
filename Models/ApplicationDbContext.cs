using Microsoft.EntityFrameworkCore;

namespace coreEFCodeFirstApproach.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseSqlServer("Server=LAPTOP-75O0631G;Database=CodeFirstDB;Integrated Security=true;TrustServerCertificate=true;");
        }
    }
}
