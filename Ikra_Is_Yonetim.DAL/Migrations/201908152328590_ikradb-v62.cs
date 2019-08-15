namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv62 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "IkraGenel.SiparisOdemeTB",
                c => new
                    {
                        OdemeId = c.Guid(nullable: false),
                        Odeme = c.String(),
                    })
                .PrimaryKey(t => t.OdemeId);
            
            AddColumn("IkraGenel.Siparis", "OdemeId", c => c.Guid());
            CreateIndex("IkraGenel.Siparis", "OdemeId");
            AddForeignKey("IkraGenel.Siparis", "OdemeId", "IkraGenel.SiparisOdemeTB", "OdemeId");
        }
        
        public override void Down()
        {
            DropForeignKey("IkraGenel.Siparis", "OdemeId", "IkraGenel.SiparisOdemeTB");
            DropIndex("IkraGenel.Siparis", new[] { "OdemeId" });
            DropColumn("IkraGenel.Siparis", "OdemeId");
            DropTable("IkraGenel.SiparisOdemeTB");
        }
    }
}
