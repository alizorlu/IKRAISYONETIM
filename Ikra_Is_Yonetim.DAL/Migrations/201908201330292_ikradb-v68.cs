namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv68 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "IkraWeb.MusteriGirisleri",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MusteriId = c.Guid(),
                        IslemTarihi = c.DateTime(nullable: false),
                        Islem = c.Int(),
                        CihazIp = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("IkraGenel.MusterilerTB", t => t.MusteriId)
                .Index(t => t.MusteriId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("IkraWeb.MusteriGirisleri", "MusteriId", "IkraGenel.MusterilerTB");
            DropIndex("IkraWeb.MusteriGirisleri", new[] { "MusteriId" });
            DropTable("IkraWeb.MusteriGirisleri");
        }
    }
}
