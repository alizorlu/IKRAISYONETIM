namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv65 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("IkraGenel.Siparis", "OdemeId", "IkraGenel.SiparisOdemeTB");
            DropPrimaryKey("IkraGenel.SiparisOdemeTB");
            AlterColumn("IkraGenel.SiparisOdemeTB", "OdemeId", c => c.Guid(nullable: false));
            AddPrimaryKey("IkraGenel.SiparisOdemeTB", "OdemeId");
            AddForeignKey("IkraGenel.Siparis", "OdemeId", "IkraGenel.SiparisOdemeTB", "OdemeId");
        }
        
        public override void Down()
        {
            DropForeignKey("IkraGenel.Siparis", "OdemeId", "IkraGenel.SiparisOdemeTB");
            DropPrimaryKey("IkraGenel.SiparisOdemeTB");
            AlterColumn("IkraGenel.SiparisOdemeTB", "OdemeId", c => c.Guid(nullable: false));
            AddPrimaryKey("IkraGenel.SiparisOdemeTB", "OdemeId");
            AddForeignKey("IkraGenel.Siparis", "OdemeId", "IkraGenel.SiparisOdemeTB", "OdemeId");
        }
    }
}
