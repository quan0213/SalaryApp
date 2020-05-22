using Microsoft.EntityFrameworkCore;
using SalaryApp.Models;

namespace SalaryApp.Data
{
    public class SalaryAppContext : DbContext
    {
        public SalaryAppContext (DbContextOptions<SalaryAppContext> options)
            : base(options)
        {
        }

        public DbSet<Staff> Staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433; Database=SalaryApp;User=SA; Password=YourStrong!Passw0rd");
        }

    }
}