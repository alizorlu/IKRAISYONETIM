namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv53 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("IkraDesk.MalzemeKullanimTB", "StokId", "IkraDesktop.StoklarTB");
            DropForeignKey("IkraDesk.MalzemeKullanimTB", "YemekId", "IkraGenel.Yemekler");
            DropPrimaryKey("IkraDesktop.StoklarTB");
            DropPrimaryKey("IkraGenel.Yemekler");
            AddColumn("IkraDesktop.StoklarTB", "StokId", c => c.Guid(nullable: false));
            AddColumn("IkraGenel.Yemekler", "YemekId", c => c.Guid(nullable: false));
            AddPrimaryKey("IkraDesktop.StoklarTB", "StokId");
            AddPrimaryKey("IkraGenel.Yemekler", "YemekId");
            AddForeignKey("IkraDesk.MalzemeKullanimTB", "StokId", "IkraDesktop.StoklarTB", "StokId", cascadeDelete: true);
            AddForeignKey("IkraDesk.MalzemeKullanimTB", "YemekId", "IkraGenel.Yemekler", "YemekId", cascadeDelete: true);
            DropColumn("IkraDesktop.StoklarTB", "Id");
            DropColumn("IkraGenel.Yemekler", "Id");
        }
        
        public override void Down()
        {
            AddColumn("IkraGenel.Yemekler", "Id", c => c.Guid(nullable: false));
            AddColumn("IkraDesktop.StoklarTB", "Id", c => c.Guid(nullable: false));
            DropForeignKey("IkraDesk.MalzemeKullanimTB", "YemekId", "IkraGenel.Yemekler");
            DropForeignKey("IkraDesk.MalzemeKullanimTB", "StokId", "IkraDesktop.StoklarTB");
            DropPrimaryKey("IkraGenel.Yemekler");
            DropPrimaryKey("IkraDesktop.StoklarTB");
            DropColumn("IkraGenel.Yemekler", "YemekId");
            DropColumn("IkraDesktop.StoklarTB", "StokId");
            AddPrimaryKey("IkraGenel.Yemekler", "Id");
            AddPrimaryKey("IkraDesktop.StoklarTB", "Id");
            AddForeignKey("IkraDesk.MalzemeKullanimTB", "YemekId", "IkraGenel.Yemekler", "Id", cascadeDelete: true);
            AddForeignKey("IkraDesk.MalzemeKullanimTB", "StokId", "IkraDesktop.StoklarTB", "Id", cascadeDelete: true);
        }
    }
}
