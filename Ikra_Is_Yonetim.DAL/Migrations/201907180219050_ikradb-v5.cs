namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("IkraGenel.Kullanicilar", "Address", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("IkraGenel.Kullanicilar", "Address");
        }
    }
}
