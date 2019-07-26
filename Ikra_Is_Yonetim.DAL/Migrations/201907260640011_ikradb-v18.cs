namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv18 : DbMigration
    {
        public override void Up()
        {
            AddColumn("IkraDesk.PersonelIzinlerTB", "MaastanDusurulduMu", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("IkraDesk.PersonelIzinlerTB", "MaastanDusurulduMu");
        }
    }
}
