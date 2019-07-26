namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv23 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("IkraGenel.SirketBilgiTB", "Logo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("IkraGenel.SirketBilgiTB", "Logo", c => c.Binary());
        }
    }
}
