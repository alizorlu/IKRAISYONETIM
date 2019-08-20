namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv69 : DbMigration
    {
        public override void Up()
        {
            AddColumn("IkraWeb.MusteriGirisleri", "IslemAciklama", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("IkraWeb.MusteriGirisleri", "IslemAciklama");
        }
    }
}
