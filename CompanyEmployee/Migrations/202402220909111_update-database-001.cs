namespace CompanyEmployee.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabase001 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee", "PhoneNumber", c => c.Long());
            AddColumn("dbo.Employee", "HighSchoolPercentage", c => c.Single());
            AddColumn("dbo.Employee", "IntermediatePercentage", c => c.Single());
            AddColumn("dbo.Employee", "CTC", c => c.Single());
            AddColumn("dbo.Employee", "LastCompany", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employee", "LastCompany");
            DropColumn("dbo.Employee", "CTC");
            DropColumn("dbo.Employee", "IntermediatePercentage");
            DropColumn("dbo.Employee", "HighSchoolPercentage");
            DropColumn("dbo.Employee", "PhoneNumber");
        }
    }
}
