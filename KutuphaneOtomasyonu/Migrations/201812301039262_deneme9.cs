namespace KutuphaneOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneme9 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Kiralar", new[] { "KiraId" });
            DropColumn("dbo.Kiralar", "KiraId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kiralar", "KiraId", c => c.Int(nullable: false, identity: true));
            CreateIndex("dbo.Kiralar", "KiraId", unique: true);
        }
    }
}
