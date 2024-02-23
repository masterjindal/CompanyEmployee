namespace CompanyEmployee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addeddepartment : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Employee", name: "Department_ID", newName: "DepartmentId");
            RenameIndex(table: "dbo.Employee", name: "IX_Department_ID", newName: "IX_DepartmentId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Employee", name: "IX_DepartmentId", newName: "IX_Department_ID");
            RenameColumn(table: "dbo.Employee", name: "DepartmentId", newName: "Department_ID");
        }
    }
}
