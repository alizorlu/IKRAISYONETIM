namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv49 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("IkraDesk.MalzemeKullanimTB", "StokId", "IkraDesktop.StoklarTB");
            DropForeignKey("IkraDesk.MalzemeKullanimTB", "YemekId", "IkraGenel.Yemekler");
            DropIndex("IkraDesk.MalzemeKullanimTB", new[] { "YemekId" });
            DropIndex("IkraDesk.MalzemeKullanimTB", new[] { "StokId" });
            AlterColumn("IkraDesk.MalzemeKullanimTB", "YemekId", c => c.Guid());
            AlterColumn("IkraDesk.MalzemeKullanimTB", "StokId", c => c.Guid());
            CreateIndex("IkraDesk.MalzemeKullanimTB", "YemekId");
            CreateIndex("IkraDesk.MalzemeKullanimTB", "StokId");
            AddForeignKey("IkraDesk.MalzemeKullanimTB", "StokId", "IkraDesktop.StoklarTB", "StokId");
            AddForeignKey("IkraDesk.MalzemeKullanimTB", "YemekId", "IkraGenel.Yemekler", "StokId");
        }
        
        public override void Down()
        {
            DropForeignKey("IkraDesk.MalzemeKullanimTB", "YemekId", "IkraGenel.Yemekler");
            DropForeignKey("IkraDesk.MalzemeKullanimTB", "StokId", "IkraDesktop.StoklarTB");
            DropIndex("IkraDesk.MalzemeKullanimTB", new[] { "StokId" });
            DropIndex("IkraDesk.MalzemeKullanimTB", new[] { "YemekId" });
            AlterColumn("IkraDesk.MalzemeKullanimTB", "StokId", c => c.Guid(nullable: false));
            AlterColumn("IkraDesk.MalzemeKullanimTB", "YemekId", c => c.Guid(nullable: false));
            CreateIndex("IkraDesk.MalzemeKullanimTB", "StokId");
            CreateIndex("IkraDesk.MalzemeKullanimTB", "YemekId");
            AddForeignKey("IkraDesk.MalzemeKullanimTB", "YemekId", "IkraGenel.Yemekler", "StokId", cascadeDelete: true);
            AddForeignKey("IkraDesk.MalzemeKullanimTB", "StokId", "IkraDesktop.StoklarTB", "StokId", cascadeDelete: true);
        }
    }
}
