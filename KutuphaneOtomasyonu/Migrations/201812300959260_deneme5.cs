namespace KutuphaneOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme5 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Kiralar", new[] { "KiraId" });
            AlterColumn("dbo.Kiralar", "KiraId", c => c.Int(nullable: false, identity: true));
            CreateIndex("dbo.Kiralar", "KiraId", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Kiralar", new[] { "KiraId" });
            AlterColumn("dbo.Kiralar", "KiraId", c => c.Int(nullable: false));
            CreateIndex("dbo.Kiralar", "KiraId", unique: true);
        }
    }
}
