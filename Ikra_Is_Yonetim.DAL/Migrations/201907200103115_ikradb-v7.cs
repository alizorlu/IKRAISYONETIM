namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "IkraGenel.MusterilerTB",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Telefon = c.String(),
                        FirmaAdSoyad = c.String(),
                        Email = c.String(),
                        KayitTarihi = c.DateTime(nullable: false),
                        LastLogin = c.DateTime(nullable: false),
                        GunlukYemekSayisi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "IkraGenel.SiparislerTB",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UretimId = c.Guid(nullable: false),
                        MusteriId = c.Guid(nullable: false),
                        CikisTarihi = c.DateTime(nullable: false),
                        OdemeYapildiMi = c.Boolean(nullable: false),
                        SiparisOnaylandiMi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("IkraGenel.MusterilerTB", t => t.MusteriId, cascadeDelete: true)
                .ForeignKey("IkraDesktop.YemeklerTB", t => t.UretimId, cascadeDelete: true)
                .Index(t => t.UretimId)
                .Index(t => t.MusteriId);
            
            CreateTable(
                "IkraDesktop.YemeklerTB",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UretimAdi = c.String(),
                        UretimZamani = c.DateTime(nullable: false),
                        BirimFiyat1 = c.Decimal(nullable: false, storeType: "money"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "IkraDesktop.StoklarTB",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        StokAdi = c.String(),
                        StokTutari = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StokKgBirim = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AlisTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "IkraGenel.YemekMalzemelerTB",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UretimId = c.Guid(nullable: false),
                        StokId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("IkraDesktop.StoklarTB", t => t.StokId, cascadeDelete: true)
                .ForeignKey("IkraDesktop.YemeklerTB", t => t.UretimId, cascadeDelete: true)
                .Index(t => t.UretimId)
                .Index(t => t.StokId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("IkraGenel.YemekMalzemelerTB", "UretimId", "IkraDesktop.YemeklerTB");
            DropForeignKey("IkraGenel.YemekMalzemelerTB", "StokId", "IkraDesktop.StoklarTB");
            DropForeignKey("IkraGenel.SiparislerTB", "UretimId", "IkraDesktop.YemeklerTB");
            DropForeignKey("IkraGenel.SiparislerTB", "MusteriId", "IkraGenel.MusterilerTB");
            DropIndex("IkraGenel.YemekMalzemelerTB", new[] { "StokId" });
            DropIndex("IkraGenel.YemekMalzemelerTB", new[] { "UretimId" });
            DropIndex("IkraGenel.SiparislerTB", new[] { "MusteriId" });
            DropIndex("IkraGenel.SiparislerTB", new[] { "UretimId" });
            DropTable("IkraGenel.YemekMalzemelerTB");
            DropTable("IkraDesktop.StoklarTB");
            DropTable("IkraDesktop.YemeklerTB");
            DropTable("IkraGenel.SiparislerTB");
            DropTable("IkraGenel.MusterilerTB");
        }
    }
}
