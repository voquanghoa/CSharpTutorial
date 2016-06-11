namespace EmployeeManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpgrateTo20 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Departments", "Location", c => c.String(nullable: false, defaultValueSql:"'123 Le Duan'"));
            AddColumn("dbo.Employees", "Salary", c => c.Int(nullable: false));
            DropColumn("dbo.Employees", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Address", c => c.String());
            DropColumn("dbo.Employees", "Salary");
            DropColumn("dbo.Departments", "Location");
        }
    }
}
