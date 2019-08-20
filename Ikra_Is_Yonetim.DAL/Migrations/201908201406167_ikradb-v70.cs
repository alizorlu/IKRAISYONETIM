namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv70 : DbMigration
    {
        public override void Up()
        {
            AddColumn("IkraWeb.MusteriGirisleri", "CihazAnonId", c => c.String());
            AddColumn("IkraWeb.MusteriGirisleri", "CihazOS", c => c.String());
            AddColumn("IkraWeb.MusteriGirisleri", "CihazBrowserVersion", c => c.String());
            AddColumn("IkraWeb.MusteriGirisleri", "CihazBrowserUserAgent", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("IkraWeb.MusteriGirisleri", "CihazBrowserUserAgent");
            DropColumn("IkraWeb.MusteriGirisleri", "CihazBrowserVersion");
            DropColumn("IkraWeb.MusteriGirisleri", "CihazOS");
            DropColumn("IkraWeb.MusteriGirisleri", "CihazAnonId");
        }
    }
}
