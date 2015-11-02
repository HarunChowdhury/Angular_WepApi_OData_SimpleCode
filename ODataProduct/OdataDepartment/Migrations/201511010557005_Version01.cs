namespace OdataDepartment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CatSys = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Quality = c.String(),
                        Categorys_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Categorys_Id)
                .Index(t => t.Categorys_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Categorys_Id", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "Categorys_Id" });
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
