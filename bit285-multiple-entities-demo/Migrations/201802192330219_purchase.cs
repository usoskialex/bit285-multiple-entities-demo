namespace bit285_multiple_entities_demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class purchase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        PurchaseID = c.Int(nullable: false, identity: true),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BookID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PurchaseID);
            
            AddColumn("dbo.Books", "Purchase_PurchaseID", c => c.Int());
            CreateIndex("dbo.Books", "Purchase_PurchaseID");
            AddForeignKey("dbo.Books", "Purchase_PurchaseID", "dbo.Purchases", "PurchaseID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "Purchase_PurchaseID", "dbo.Purchases");
            DropIndex("dbo.Books", new[] { "Purchase_PurchaseID" });
            DropColumn("dbo.Books", "Purchase_PurchaseID");
            DropTable("dbo.Purchases");
        }
    }
}
