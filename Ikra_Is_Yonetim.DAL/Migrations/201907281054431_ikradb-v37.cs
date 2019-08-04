namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv37 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "IkraDesk.FirmalarTB",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirmaAdi = c.String(),
                        Adres = c.String(),
                        Telefon = c.String(),
                        YetkiliKisi = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("IkraDesk.FirmalarTB");
        }
    }
}
