namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv66 : DbMigration
    {
        public override void Up()
        {
            AddColumn("IkraGenel.SiparisOdemeTB", "Kart", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("IkraGenel.SiparisOdemeTB", "Kart");
        }
    }
}
