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

        public DbSet<Staff> Staffs{ get; set; }
        public DbSet<Salary> Salaries{get;set;}
        public DbSet<Overtime> Overtimes{get;set;}
        public DbSet<Allowance> Allowances{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433; Database=SalaryApp;User=SA; Password=YourStrong!Passw0rd");
        }

    }
}