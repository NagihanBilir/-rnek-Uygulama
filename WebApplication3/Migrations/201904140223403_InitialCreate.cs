namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Yazars",
                c => new
                    {
                        YazarId = c.Int(nullable: false, identity: true),
                        YazarAdiSoyadi = c.String(),
                        YazarDogumTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.YazarId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Yazars");
        }
    }
}
