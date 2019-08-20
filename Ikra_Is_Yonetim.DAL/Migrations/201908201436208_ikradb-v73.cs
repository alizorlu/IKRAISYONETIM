namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv73 : DbMigration
    {
        public override void Up()
        {
            DropColumn("IkraWeb.MusteriGirisleri", "CihazOS");
            DropColumn("IkraWeb.MusteriGirisleri", "CihazBrowserVersion");
            DropColumn("IkraWeb.MusteriGirisleri", "CihazBrowserUserAgent");
        }
        
        public override void Down()
        {
            AddColumn("IkraWeb.MusteriGirisleri", "CihazBrowserUserAgent", c => c.String());
            AddColumn("IkraWeb.MusteriGirisleri", "CihazBrowserVersion", c => c.String());
            AddColumn("IkraWeb.MusteriGirisleri", "CihazOS", c => c.String());
        }
    }
}
