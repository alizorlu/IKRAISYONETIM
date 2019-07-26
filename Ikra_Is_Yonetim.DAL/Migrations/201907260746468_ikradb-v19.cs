namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv19 : DbMigration
    {
        public override void Up()
        {
            AddColumn("IkraDesk.PersonelMaaslarTB", "FaturaId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("IkraDesk.PersonelMaaslarTB", "FaturaId");
        }
    }
}
