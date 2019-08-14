namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv61 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("IkraGenel.Siparis", "KullaniciId", "IkraGenel.Kullanicilar");
            DropIndex("IkraGenel.Siparis", new[] { "KullaniciId" });
            DropColumn("IkraGenel.Siparis", "KullaniciId");
        }
        
        public override void Down()
        {
            AddColumn("IkraGenel.Siparis", "KullaniciId", c => c.Guid(nullable: false));
            CreateIndex("IkraGenel.Siparis", "KullaniciId");
            AddForeignKey("IkraGenel.Siparis", "KullaniciId", "IkraGenel.Kullanicilar", "Id", cascadeDelete: true);
        }
    }
}
