namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv16 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "IkraDesk.PersonelMaaslarTB",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Odendi = c.Boolean(nullable: false),
                        PersonelId = c.Guid(nullable: false),
                        OdemeTutari = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SonMaasDonemTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("IkraDesk.PersonellerTB", t => t.PersonelId, cascadeDelete: true)
                .Index(t => t.PersonelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("IkraDesk.PersonelMaaslarTB", "PersonelId", "IkraDesk.PersonellerTB");
            DropIndex("IkraDesk.PersonelMaaslarTB", new[] { "PersonelId" });
            DropTable("IkraDesk.PersonelMaaslarTB");
        }
    }
}
