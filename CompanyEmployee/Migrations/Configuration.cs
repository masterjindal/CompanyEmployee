namespace CompanyEmployee.Migrations
{
    using CompanyEmployee.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Diagnostics;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CompanyEmployee.DAL.CompanyEmployeeContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CompanyEmployee.DAL.CompanyEmployeeContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var employees = new List<Employee>
            {
                new Employee {FirstName="Kanishk", LastName="Aggarwal", Address="325/6, Kisanpura", City="Delhi", Country="India", Designation="Software Engineer", Experienced=true, JoiningDate=DateTime.Parse("2012-09-01"), Gender=Gender.Male, State="Delhi"},
                new Employee {FirstName="Kritika", LastName="Dutta", Address="325/6, Kisanpura", City="Meerut", Country="India", Designation="Software Engineer", Experienced=true, JoiningDate=DateTime.Parse("2012-09-01"), Gender=Gender.Male, State="UP"},
                new Employee {FirstName="Lakshay", LastName="Aggarwal", Address="390/6, Ashok Nagar", City="Delhi", Country="India", Designation="Software Engineer", Experienced=true, JoiningDate=DateTime.Parse("2012-09-01"), Gender=Gender.Male, State="Delhi"}
            };
            employees.ForEach(e => context.Employees.AddOrUpdate(p => p.FirstName, e));
            context.SaveChanges();

            var departments = new List<Department>
            {
                new Department { DepartmentName = "HR"},
                new Department { DepartmentName = "Engineering"},
                new Department { DepartmentName = "Finance"},
                
            };
            departments.ForEach(e => context.Departments.AddOrUpdate(p => p.DepartmentName, e));
            context.SaveChanges();
        }
    }
}
