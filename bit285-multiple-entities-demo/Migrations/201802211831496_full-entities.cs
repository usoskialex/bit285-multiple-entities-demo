namespace bit285_multiple_entities_demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fullentities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        AuthorID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.AuthorID);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        BookID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        AuthorID = c.Int(nullable: false),
                        Edition = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Publication = c.String(),
                    })
                .PrimaryKey(t => t.BookID)
                .ForeignKey("dbo.Authors", t => t.AuthorID, cascadeDelete: true)
                .Index(t => t.AuthorID);
            
            CreateTable(
                "dbo.Purchases",
                c => new
                    {
                        PurchaseID = c.Int(nullable: false, identity: true),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BookID = c.Int(nullable: false),
                        MemberID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PurchaseID)
                .ForeignKey("dbo.Books", t => t.BookID, cascadeDelete: true)
                .ForeignKey("dbo.Members", t => t.MemberID, cascadeDelete: true)
                .Index(t => t.BookID)
                .Index(t => t.MemberID);
            
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        MemberID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.MemberID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Purchases", "MemberID", "dbo.Members");
            DropForeignKey("dbo.Books", "AuthorID", "dbo.Authors");
            DropForeignKey("dbo.Purchases", "BookID", "dbo.Books");
            DropIndex("dbo.Purchases", new[] { "MemberID" });
            DropIndex("dbo.Purchases", new[] { "BookID" });
            DropIndex("dbo.Books", new[] { "AuthorID" });
            DropTable("dbo.Members");
            DropTable("dbo.Purchases");
            DropTable("dbo.Books");
            DropTable("dbo.Authors");
        }
    }
}
