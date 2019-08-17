namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv63 : DbMigration
    {
        public override void Up()
        {
            AddColumn("IkraGenel.SiparisOdemeTB", "KartBinNumber", c => c.String());
            AddColumn("IkraGenel.SiparisOdemeTB", "SonDortHane", c => c.String());
            AddColumn("IkraGenel.SiparisOdemeTB", "KartTip", c => c.String());
            AddColumn("IkraGenel.SiparisOdemeTB", "KartAile", c => c.String());
            AddColumn("IkraGenel.SiparisOdemeTB", "OdemeTarihi", c => c.DateTime(nullable: false));
            AddColumn("IkraGenel.SiparisOdemeTB", "OdemeTutari", c => c.String());
            AddColumn("IkraGenel.SiparisOdemeTB", "NetOdemeTutari", c => c.String());
            DropColumn("IkraGenel.SiparisOdemeTB", "Odeme");
        }
        
        public override void Down()
        {
            AddColumn("IkraGenel.SiparisOdemeTB", "Odeme", c => c.String());
            DropColumn("IkraGenel.SiparisOdemeTB", "NetOdemeTutari");
            DropColumn("IkraGenel.SiparisOdemeTB", "OdemeTutari");
            DropColumn("IkraGenel.SiparisOdemeTB", "OdemeTarihi");
            DropColumn("IkraGenel.SiparisOdemeTB", "KartAile");
            DropColumn("IkraGenel.SiparisOdemeTB", "KartTip");
            DropColumn("IkraGenel.SiparisOdemeTB", "SonDortHane");
            DropColumn("IkraGenel.SiparisOdemeTB", "KartBinNumber");
        }
    }
}
