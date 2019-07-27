namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv33 : DbMigration
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
                        MaastanDusulduMu = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("IkraDesk.PersonellerTB", t => t.PersonelId, cascadeDelete: true)
                .Index(t => t.PersonelId);
            
            CreateTable(
                "IkraDesk.PersonellerTB",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        AdSoyad = c.String(nullable: false, maxLength: 100),
                        Gorevi = c.String(maxLength: 100),
                        Telefon = c.String(maxLength: 20),
                        DigerBilgiler = c.String(maxLength: 1000),
                        ToplamMaasi = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GirisZamani = c.DateTime(nullable: false),
                        MaasTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "IkraGenel.Emai",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        EmailAddres = c.String(),
                        Port = c.String(),
                        Host = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "IkraDesk.PersonelIzinlerTB",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        PersonelId = c.Guid(nullable: false),
                        IzinTarihi = c.DateTime(nullable: false),
                        IzinSuresi = c.DateTime(nullable: false),
                        MaastanDusurulduMu = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("IkraDesk.PersonellerTB", t => t.PersonelId, cascadeDelete: true)
                .Index(t => t.PersonelId);
            
            CreateTable(
                "IkraGenel.KasaTB",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Donem = c.String(),
                        Miktar = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Aciklama = c.String(),
                        IslemTarihi = c.DateTime(nullable: false),
                        IslemTipi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "IkraGenel.Kullanicilar",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Tip = c.Int(nullable: false),
                        AdSoyad = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        CreateTime = c.DateTime(nullable: false),
                        LastLogin = c.DateTime(nullable: false),
                        Email = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        IsState = c.Boolean(nullable: false),
                        Address = c.String(nullable: false),
                        MealCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "IkraDesk.PersonelMaaslarTB",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Odendi = c.Boolean(nullable: false),
                        PersonelId = c.Guid(nullable: false),
                        OdemeTutari = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SonMaasDonemTarihi = c.DateTime(nullable: false),
                        FaturaId = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("IkraDesk.PersonellerTB", t => t.PersonelId, cascadeDelete: true)
                .Index(t => t.PersonelId);
            
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
                "IkraGenel.SirketBilgiTB",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        VATNo = c.String(),
                        SiteName = c.String(),
                        Logo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "IkraDesktop.StoklarTB",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        StokAdi = c.String(),
                        StokTutari = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StokKgBirimAlinan = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StokKgBirimKalan = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AlisTarihi = c.DateTime(nullable: false),
                        StokBittiMi = c.Boolean(nullable: false),
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
            DropForeignKey("IkraDesk.PersonelMaaslarTB", "PersonelId", "IkraDesk.PersonellerTB");
            DropForeignKey("IkraDesk.PersonelIzinlerTB", "PersonelId", "IkraDesk.PersonellerTB");
            DropForeignKey("IkraDesk.PersonelAvansTB", "PersonelId", "IkraDesk.PersonellerTB");
            DropIndex("IkraGenel.YemekMalzemelerTB", new[] { "StokId" });
            DropIndex("IkraGenel.YemekMalzemelerTB", new[] { "UretimId" });
            DropIndex("IkraGenel.SiparislerTB", new[] { "MusteriId" });
            DropIndex("IkraGenel.SiparislerTB", new[] { "UretimId" });
            DropIndex("IkraDesk.PersonelMaaslarTB", new[] { "PersonelId" });
            DropIndex("IkraDesk.PersonelIzinlerTB", new[] { "PersonelId" });
            DropIndex("IkraDesk.PersonelAvansTB", new[] { "PersonelId" });
            DropTable("IkraGenel.YemekMalzemelerTB");
            DropTable("IkraDesktop.StoklarTB");
            DropTable("IkraGenel.SirketBilgiTB");
            DropTable("IkraDesktop.YemeklerTB");
            DropTable("IkraGenel.SiparislerTB");
            DropTable("IkraGenel.MusterilerTB");
            DropTable("IkraDesk.PersonelMaaslarTB");
            DropTable("IkraGenel.Kullanicilar");
            DropTable("IkraGenel.KasaTB");
            DropTable("IkraDesk.PersonelIzinlerTB");
            DropTable("IkraGenel.Emai");
            DropTable("IkraDesk.PersonellerTB");
            DropTable("IkraDesk.PersonelAvansTB");
        }
    }
}
