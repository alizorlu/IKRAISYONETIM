namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("IkraGenel.Kullanicilar", "MealCount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("IkraGenel.Kullanicilar", "MealCount");
        }
    }
}
