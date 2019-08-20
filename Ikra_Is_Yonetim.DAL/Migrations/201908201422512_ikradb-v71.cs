namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv71 : DbMigration
    {
        public override void Up()
        {
            AddColumn("IkraWeb.MusteriGirisleri", "CihazBrowser", c => c.String());
            AddColumn("IkraWeb.MusteriGirisleri", "CihazBrowserAnonId", c => c.String());
            DropColumn("IkraWeb.MusteriGirisleri", "CihazAnonId");
        }
        
        public override void Down()
        {
            AddColumn("IkraWeb.MusteriGirisleri", "CihazAnonId", c => c.String());
            DropColumn("IkraWeb.MusteriGirisleri", "CihazBrowserAnonId");
            DropColumn("IkraWeb.MusteriGirisleri", "CihazBrowser");
        }
    }
}
