namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv17 : DbMigration
    {
        public override void Up()
        {
            AddColumn("IkraDesk.PersonelAvansTB", "MaastanDusulduMu", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("IkraDesk.PersonelAvansTB", "MaastanDusulduMu");
        }
    }
}
