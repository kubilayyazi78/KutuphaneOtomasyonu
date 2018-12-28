namespace KutuphaneOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kitapyazar1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kitaplar",
                c => new
                    {
                        KitapId = c.Int(nullable: false, identity: true),
                        KitapAdi = c.String(nullable: false, maxLength: 25),
                        YazarId = c.Int(nullable: false),
                        Adet = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KitapId)
                .ForeignKey("dbo.Yazarlar", t => t.YazarId, cascadeDelete: true)
                .Index(t => t.KitapAdi, unique: true)
                .Index(t => t.YazarId);
            
            CreateTable(
                "dbo.Yazarlar",
                c => new
                    {
                        YazarId = c.Int(nullable: false, identity: true),
                        YazarAdi = c.String(nullable: false, maxLength: 20),
                        YazarSoyadi = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.YazarId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kitaplar", "YazarId", "dbo.Yazarlar");
            DropIndex("dbo.Kitaplar", new[] { "YazarId" });
            DropIndex("dbo.Kitaplar", new[] { "KitapAdi" });
            DropTable("dbo.Yazarlar");
            DropTable("dbo.Kitaplar");
        }
    }
}
