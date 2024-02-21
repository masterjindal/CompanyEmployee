using CompanyEmployee.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CompanyEmployee.DAL
{
    public class CompanyEmployeeContext : DbContext
    {
        public CompanyEmployeeContext() : base("CompanyEmployeeContext")
        { 
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}