namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv39 : DbMigration
    {
        public override void Up()
        {
            AddColumn("IkraGenel.MusterilerTB", "FirmaAdres", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("IkraGenel.MusterilerTB", "FirmaAdres");
        }
    }
}
