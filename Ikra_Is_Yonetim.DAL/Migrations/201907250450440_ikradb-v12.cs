namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("IkraDesk.PersonellerTB", "DigerBilgiler", c => c.String());
            DropColumn("IkraDesk.PersonellerTB", "Adres");
        }
        
        public override void Down()
        {
            AddColumn("IkraDesk.PersonellerTB", "Adres", c => c.String());
            DropColumn("IkraDesk.PersonellerTB", "DigerBilgiler");
        }
    }
}
