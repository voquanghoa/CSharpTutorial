namespace EntityTutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bill",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        Payment = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        Product_Id = c.Int(),
                        Saller_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Product", t => t.Product_Id)
                .ForeignKey("dbo.Employee", t => t.Saller_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.Saller_Id);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                        Description = c.Int(nullable: false),
                        Category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.Category_Id)
                .Index(t => t.Category_Id);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bill", "Saller_Id", "dbo.Employee");
            DropForeignKey("dbo.Bill", "Product_Id", "dbo.Product");
            DropForeignKey("dbo.Product", "Category_Id", "dbo.Category");
            DropIndex("dbo.Product", new[] { "Category_Id" });
            DropIndex("dbo.Bill", new[] { "Saller_Id" });
            DropIndex("dbo.Bill", new[] { "Product_Id" });
            DropTable("dbo.Employee");
            DropTable("dbo.Category");
            DropTable("dbo.Product");
            DropTable("dbo.Bill");
        }
    }
}
