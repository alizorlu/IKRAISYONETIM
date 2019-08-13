namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv44 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("IkraDesk.MalzemeKullanimTB", "StokId", "IkraDesktop.StoklarTB");
            DropIndex("IkraDesk.MalzemeKullanimTB", new[] { "StokId" });
            RenameColumn(table: "IkraDesk.MalzemeKullanimTB", name: "StokId", newName: "Stok_Id");
            AlterColumn("IkraDesk.MalzemeKullanimTB", "Stok_Id", c => c.Guid());
            CreateIndex("IkraDesk.MalzemeKullanimTB", "Stok_Id");
            AddForeignKey("IkraDesk.MalzemeKullanimTB", "Stok_Id", "IkraDesktop.StoklarTB", "StokId");
        }
        
        public override void Down()
        {
            DropForeignKey("IkraDesk.MalzemeKullanimTB", "Stok_Id", "IkraDesktop.StoklarTB");
            DropIndex("IkraDesk.MalzemeKullanimTB", new[] { "Stok_Id" });
            AlterColumn("IkraDesk.MalzemeKullanimTB", "Stok_Id", c => c.Guid(nullable: false));
            RenameColumn(table: "IkraDesk.MalzemeKullanimTB", name: "Stok_Id", newName: "StokId");
            CreateIndex("IkraDesk.MalzemeKullanimTB", "StokId");
            AddForeignKey("IkraDesk.MalzemeKullanimTB", "StokId", "IkraDesktop.StoklarTB", "StokId", cascadeDelete: true);
        }
    }
}
