namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv38 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("IkraGenel.SiparislerTB", "MusteriId", "IkraGenel.MusterilerTB");
            DropForeignKey("IkraGenel.SiparislerTB", "UretimId", "IkraDesktop.YemeklerTB");
            DropForeignKey("IkraGenel.YemekMalzemelerTB", "StokId", "IkraDesktop.StoklarTB");
            DropForeignKey("IkraGenel.YemekMalzemelerTB", "UretimId", "IkraDesktop.YemeklerTB");
            DropIndex("IkraGenel.SiparislerTB", new[] { "UretimId" });
            DropIndex("IkraGenel.SiparislerTB", new[] { "MusteriId" });
            DropIndex("IkraGenel.YemekMalzemelerTB", new[] { "UretimId" });
            DropIndex("IkraGenel.YemekMalzemelerTB", new[] { "StokId" });
            CreateTable(
                "IkraDesk.MalzemeKullanimTB",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        KullanimKg = c.Decimal(nullable: false, precision: 18, scale: 2),
                        KullanimTarihi = c.DateTime(nullable: false),
                        Stok_Id = c.Guid(),
                        Yemek_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("IkraDesktop.StoklarTB", t => t.Stok_Id)
                .ForeignKey("IkraGenel.Yemekler", t => t.Yemek_Id)
                .Index(t => t.Stok_Id)
                .Index(t => t.Yemek_Id);
            
            CreateTable(
                "IkraGenel.Yemekler",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        YemekAdi = c.String(),
                        PorsiyonGr = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UretimZamani = c.DateTime(nullable: false),
                        YayinDurumu = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropTable("IkraGenel.SiparislerTB");
            DropTable("IkraDesktop.YemeklerTB");
            DropTable("IkraGenel.YemekMalzemelerTB");
        }
        
        public override void Down()
        {
            CreateTable(
                "IkraGenel.YemekMalzemelerTB",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UretimId = c.Guid(nullable: false),
                        StokId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("IkraDesk.MalzemeKullanimTB", "Yemek_Id", "IkraGenel.Yemekler");
            DropForeignKey("IkraDesk.MalzemeKullanimTB", "Stok_Id", "IkraDesktop.StoklarTB");
            DropIndex("IkraDesk.MalzemeKullanimTB", new[] { "Yemek_Id" });
            DropIndex("IkraDesk.MalzemeKullanimTB", new[] { "Stok_Id" });
            DropTable("IkraGenel.Yemekler");
            DropTable("IkraDesk.MalzemeKullanimTB");
            CreateIndex("IkraGenel.YemekMalzemelerTB", "StokId");
            CreateIndex("IkraGenel.YemekMalzemelerTB", "UretimId");
            CreateIndex("IkraGenel.SiparislerTB", "MusteriId");
            CreateIndex("IkraGenel.SiparislerTB", "UretimId");
            AddForeignKey("IkraGenel.YemekMalzemelerTB", "UretimId", "IkraDesktop.YemeklerTB", "Id", cascadeDelete: true);
            AddForeignKey("IkraGenel.YemekMalzemelerTB", "StokId", "IkraDesktop.StoklarTB", "Id", cascadeDelete: true);
            AddForeignKey("IkraGenel.SiparislerTB", "UretimId", "IkraDesktop.YemeklerTB", "Id", cascadeDelete: true);
            AddForeignKey("IkraGenel.SiparislerTB", "MusteriId", "IkraGenel.MusterilerTB", "Id", cascadeDelete: true);
        }
    }
}
