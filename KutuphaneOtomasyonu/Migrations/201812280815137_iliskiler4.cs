namespace KutuphaneOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class iliskiler4 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Urunler", newName: "Uyeler");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Uyeler", newName: "Urunler");
        }
    }
}
