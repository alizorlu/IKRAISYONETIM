namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv57 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "IkraGenel.Siparis",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        SiparisDurum = c.Int(),
                        SiparisTarihi = c.DateTime(nullable: false),
                        TeslimTarihi = c.DateTime(),
                        YemekSayisi = c.Int(nullable: false),
                        MusteriId = c.Guid(nullable: false),
                        YemekId = c.Guid(nullable: false),
                        KullaniciId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("IkraGenel.Kullanicilar", t => t.KullaniciId, cascadeDelete: true)
                .ForeignKey("IkraGenel.MusterilerTB", t => t.MusteriId, cascadeDelete: true)
                .ForeignKey("IkraGenel.Yemekler", t => t.YemekId, cascadeDelete: true)
                .Index(t => t.MusteriId)
                .Index(t => t.YemekId)
                .Index(t => t.KullaniciId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("IkraGenel.Siparis", "YemekId", "IkraGenel.Yemekler");
            DropForeignKey("IkraGenel.Siparis", "MusteriId", "IkraGenel.MusterilerTB");
            DropForeignKey("IkraGenel.Siparis", "KullaniciId", "IkraGenel.Kullanicilar");
            DropIndex("IkraGenel.Siparis", new[] { "KullaniciId" });
            DropIndex("IkraGenel.Siparis", new[] { "YemekId" });
            DropIndex("IkraGenel.Siparis", new[] { "MusteriId" });
            DropTable("IkraGenel.Siparis");
        }
    }
}
