namespace KutuphaneOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kiralar", "KiraId", c => c.Int(nullable: false));
            CreateIndex("dbo.Kiralar", "KiraId", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Kiralar", new[] { "KiraId" });
            DropColumn("dbo.Kiralar", "KiraId");
        }
    }
}
