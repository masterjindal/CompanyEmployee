namespace CompanyEmployee.Migrations
{
    using CompanyEmployee.Models;
    using System;
    using System.Data.Entity.Migrations;

    public partial class Initialcreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
            "dbo.EmployeeTable",
            c => new
            {
                ID = c.Int(nullable: false, identity: true),
                LastName = c.String(),
                FirstName = c.String(),
                Designation = c.String(),
                Gender = c.String(),
                Department = c.String(),
                Address = c.String(),
                City = c.String(),
                State = c.String(),
                Country = c.String(),
                Experienced = c.Boolean(),
                JoiningDate = c.DateTime(nullable: false),
            })
            .PrimaryKey(t => t.ID);

            CreateTable(
                "dbo.DepartmentTable",
                c => new
                {
                    ID = c.Int(nullable: false, identity: true),
                    DepartmentName = c.String(),
                })
                .PrimaryKey(t => t.ID);
        }

        public override void Down()
        {
            DropTable("dbo.DepartmentTable");
            DropTable("dbo.EmployeeTable");
        }
    }
}
