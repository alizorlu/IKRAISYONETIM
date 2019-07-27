namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv35 : DbMigration
    {
        public override void Up()
        {
            DropColumn("IkraDesktop.StoklarTB", "StokBittiMi");
        }
        
        public override void Down()
        {
            AddColumn("IkraDesktop.StoklarTB", "StokBittiMi", c => c.Boolean(nullable: false));
        }
    }
}
