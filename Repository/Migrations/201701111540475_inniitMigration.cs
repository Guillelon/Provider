namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inniitMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
              "dbo.TypeProducts",
              c => new
              {
                  Id = c.Int(nullable: false, identity: true),
                  Name = c.String(),
              })
              .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SalePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PurchasePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TypeProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TypeProducts", t => t.TypeProductId, cascadeDelete: true)
                .Index(t => t.TypeProductId);          
          
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SaleDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductQuantity = c.Int(nullable: false),
                        SaleId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Sales", t => t.SaleId, cascadeDelete: true)
                .Index(t => t.SaleId)
                .Index(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SaleDetails", "SaleId", "dbo.Sales");
            DropForeignKey("dbo.SaleDetails", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Products", "TypeProductId", "dbo.TypeProducts");
            DropIndex("dbo.SaleDetails", new[] { "ProductId" });
            DropIndex("dbo.SaleDetails", new[] { "SaleId" });
            DropIndex("dbo.Products", new[] { "TypeProductId" });
            DropTable("dbo.SaleDetails");
            DropTable("dbo.Sales");
            DropTable("dbo.TypeProducts");
            DropTable("dbo.Products");
        }
    }
}
