namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv43 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("IkraDesk.MalzemeKullanimTB", "Stok_Id", "IkraDesktop.StoklarTB");
            DropIndex("IkraDesk.MalzemeKullanimTB", new[] { "Stok_Id" });
            RenameColumn(table: "IkraDesk.MalzemeKullanimTB", name: "Stok_Id", newName: "StokId");
            AlterColumn("IkraDesk.MalzemeKullanimTB", "StokId", c => c.Guid(nullable: false));
            CreateIndex("IkraDesk.MalzemeKullanimTB", "StokId");
            AddForeignKey("IkraDesk.MalzemeKullanimTB", "StokId", "IkraDesktop.StoklarTB", "StokId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("IkraDesk.MalzemeKullanimTB", "StokId", "IkraDesktop.StoklarTB");
            DropIndex("IkraDesk.MalzemeKullanimTB", new[] { "StokId" });
            AlterColumn("IkraDesk.MalzemeKullanimTB", "StokId", c => c.Guid());
            RenameColumn(table: "IkraDesk.MalzemeKullanimTB", name: "StokId", newName: "Stok_Id");
            CreateIndex("IkraDesk.MalzemeKullanimTB", "Stok_Id");
            AddForeignKey("IkraDesk.MalzemeKullanimTB", "Stok_Id", "IkraDesktop.StoklarTB", "StokId");
        }
    }
}
