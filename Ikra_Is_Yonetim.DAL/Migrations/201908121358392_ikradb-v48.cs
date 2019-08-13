namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv48 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("IkraDesk.MalzemeKullanimTB", "Stok_Id", "IkraDesktop.StoklarTB");
            DropForeignKey("IkraDesk.MalzemeKullanimTB", "Yemek_Id", "IkraGenel.Yemekler");
            DropIndex("IkraDesk.MalzemeKullanimTB", new[] { "Stok_Id" });
            DropIndex("IkraDesk.MalzemeKullanimTB", new[] { "Yemek_Id" });
            RenameColumn(table: "IkraDesk.MalzemeKullanimTB", name: "Stok_Id", newName: "StokId");
            RenameColumn(table: "IkraDesk.MalzemeKullanimTB", name: "Yemek_Id", newName: "YemekId");
            AlterColumn("IkraDesk.MalzemeKullanimTB", "StokId", c => c.Guid(nullable: false));
            AlterColumn("IkraDesk.MalzemeKullanimTB", "YemekId", c => c.Guid(nullable: false));
            CreateIndex("IkraDesk.MalzemeKullanimTB", "YemekId");
            CreateIndex("IkraDesk.MalzemeKullanimTB", "StokId");
            AddForeignKey("IkraDesk.MalzemeKullanimTB", "StokId", "IkraDesktop.StoklarTB", "StokId", cascadeDelete: true);
            AddForeignKey("IkraDesk.MalzemeKullanimTB", "YemekId", "IkraGenel.Yemekler", "StokId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("IkraDesk.MalzemeKullanimTB", "YemekId", "IkraGenel.Yemekler");
            DropForeignKey("IkraDesk.MalzemeKullanimTB", "StokId", "IkraDesktop.StoklarTB");
            DropIndex("IkraDesk.MalzemeKullanimTB", new[] { "StokId" });
            DropIndex("IkraDesk.MalzemeKullanimTB", new[] { "YemekId" });
            AlterColumn("IkraDesk.MalzemeKullanimTB", "YemekId", c => c.Guid());
            AlterColumn("IkraDesk.MalzemeKullanimTB", "StokId", c => c.Guid());
            RenameColumn(table: "IkraDesk.MalzemeKullanimTB", name: "YemekId", newName: "Yemek_Id");
            RenameColumn(table: "IkraDesk.MalzemeKullanimTB", name: "StokId", newName: "Stok_Id");
            CreateIndex("IkraDesk.MalzemeKullanimTB", "Yemek_Id");
            CreateIndex("IkraDesk.MalzemeKullanimTB", "Stok_Id");
            AddForeignKey("IkraDesk.MalzemeKullanimTB", "Yemek_Id", "IkraGenel.Yemekler", "StokId");
            AddForeignKey("IkraDesk.MalzemeKullanimTB", "Stok_Id", "IkraDesktop.StoklarTB", "StokId");
        }
    }
}
