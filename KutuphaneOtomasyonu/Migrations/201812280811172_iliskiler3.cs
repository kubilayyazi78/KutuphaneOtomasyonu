namespace KutuphaneOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class iliskiler3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kiralar",
                c => new
                    {
                        UyeId = c.Int(nullable: false),
                        KitapId = c.Int(nullable: false),
                        Eklenme = c.DateTime(nullable: false, storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => new { t.UyeId, t.KitapId })
                .ForeignKey("dbo.Kitaplar", t => t.KitapId, cascadeDelete: true)
                .ForeignKey("dbo.Urunler", t => t.UyeId, cascadeDelete: true)
                .Index(t => t.UyeId)
                .Index(t => t.KitapId);
            
            CreateTable(
                "dbo.Urunler",
                c => new
                    {
                        UyeId = c.Int(nullable: false, identity: true),
                        UyeAdi = c.String(nullable: false, maxLength: 20),
                        UyeSoyadi = c.String(nullable: false, maxLength: 20),
                        TcKimlik = c.String(maxLength: 11),
                        Ceza = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UyeId)
                .Index(t => t.TcKimlik, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kiralar", "UyeId", "dbo.Urunler");
            DropForeignKey("dbo.Kiralar", "KitapId", "dbo.Kitaplar");
            DropIndex("dbo.Urunler", new[] { "TcKimlik" });
            DropIndex("dbo.Kiralar", new[] { "KitapId" });
            DropIndex("dbo.Kiralar", new[] { "UyeId" });
            DropTable("dbo.Urunler");
            DropTable("dbo.Kiralar");
        }
    }
}
