namespace KutuphaneOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class iliskiler5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Uyeler", "Ceza", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Uyeler", "Ceza", c => c.Int(nullable: false));
        }
    }
}
