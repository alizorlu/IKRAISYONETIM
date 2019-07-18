namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("IkraGenel.Kullanicilar", "Tip", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("IkraGenel.Kullanicilar", "Tip");
        }
    }
}
