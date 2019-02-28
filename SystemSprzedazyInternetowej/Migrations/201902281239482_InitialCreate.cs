namespace SystemSprzedazyInternetowej.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        CategoryDescription = c.String(),
                        IconNameCategory = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Cloth",
                c => new
                    {
                        ClothId = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        NameOfClothes = c.String(),
                        SizeCloth = c.String(),
                        ColorCloth = c.String(),
                        DateAddCloth = c.DateTime(nullable: false),
                        ImageClothFileName = c.String(),
                        DescriptionCloth = c.String(),
                        ClothPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SaleCloth = c.Boolean(nullable: false),
                        SecretCloth = c.Int(nullable: false),
                        ClotCutDescription = c.String(),
                    })
                .PrimaryKey(t => t.ClothId)
                .ForeignKey("dbo.Category", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.OrderPossition",
                c => new
                    {
                        OrderPossitionId = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        ClothId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        PriceOrderFinal = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderPossitionId)
                .ForeignKey("dbo.Cloth", t => t.ClothId, cascadeDelete: true)
                .ForeignKey("dbo.Order", t => t.OrderId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.ClothId);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Street = c.String(),
                        City = c.String(),
                        PostCode = c.String(),
                        PhoneNumber = c.String(),
                        AdressEmail = c.String(),
                        Comment = c.String(),
                        OrderDateAdd = c.DateTime(nullable: false),
                        OrderStatus = c.Int(nullable: false),
                        ValueOrder = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.OrderPossition", "OrderId", "dbo.Order");
            DropForeignKey("dbo.OrderPossition", "ClothId", "dbo.Cloth");
            DropForeignKey("dbo.Cloth", "CategoryId", "dbo.Category");
            DropIndex("dbo.OrderPossition", new[] { "ClothId" });
            DropIndex("dbo.OrderPossition", new[] { "OrderId" });
            DropIndex("dbo.Cloth", new[] { "CategoryId" });
            DropTable("dbo.Order");
            DropTable("dbo.OrderPossition");
            DropTable("dbo.Cloth");
            DropTable("dbo.Category");
        }
    }
}
