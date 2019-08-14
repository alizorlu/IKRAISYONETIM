namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv58 : DbMigration
    {
        public override void Up()
        {
            AddColumn("IkraGenel.MusterilerTB", "GeciciPassword", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("IkraGenel.MusterilerTB", "GeciciPassword");
        }
    }
}
