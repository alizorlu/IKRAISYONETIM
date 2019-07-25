namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "IkraDesk.PersonelIzinlerTB",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PersonelId = c.Guid(nullable: false),
                        IzinTarihi = c.DateTime(nullable: false),
                        IzinSuresi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("IkraDesk.PersonellerTB", t => t.PersonelId, cascadeDelete: true)
                .Index(t => t.PersonelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("IkraDesk.PersonelIzinlerTB", "PersonelId", "IkraDesk.PersonellerTB");
            DropIndex("IkraDesk.PersonelIzinlerTB", new[] { "PersonelId" });
            DropTable("IkraDesk.PersonelIzinlerTB");
        }
    }
}
