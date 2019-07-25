namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "IkraDesk.PersonelAvansTB",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PersonelId = c.Guid(nullable: false),
                        AvansTutari = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AvansTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("IkraDesk.PersonellerTB", t => t.PersonelId, cascadeDelete: true)
                .Index(t => t.PersonelId);
            
            CreateTable(
                "IkraDesk.PersonellerTB",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        AdSoyad = c.String(),
                        Gorevi = c.String(),
                        Telefon = c.String(),
                        Adres = c.String(),
                        ToplamMaasi = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GirisZamani = c.DateTime(nullable: false),
                        MaasTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "IkraGenel.KasaTB",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Aciklama = c.String(),
                        GirenTutar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CikanTutar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IslemTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("IkraDesktop.StoklarTB", "StokBittiMi", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("IkraDesk.PersonelAvansTB", "PersonelId", "IkraDesk.PersonellerTB");
            DropIndex("IkraDesk.PersonelAvansTB", new[] { "PersonelId" });
            DropColumn("IkraDesktop.StoklarTB", "StokBittiMi");
            DropTable("IkraGenel.KasaTB");
            DropTable("IkraDesk.PersonellerTB");
            DropTable("IkraDesk.PersonelAvansTB");
        }
    }
}
