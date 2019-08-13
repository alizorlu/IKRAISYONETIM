namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv55 : DbMigration
    {
        public override void Up()
        {
            AddColumn("IkraGenel.Yemekler", "YemekAciklamasi", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("IkraGenel.Yemekler", "YemekAciklamasi");
        }
    }
}
