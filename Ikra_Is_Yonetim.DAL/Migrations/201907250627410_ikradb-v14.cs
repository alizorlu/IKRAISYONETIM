namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv14 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("IkraDesk.PersonellerTB", "Gorevi", c => c.String(maxLength: 100));
            AlterColumn("IkraDesk.PersonellerTB", "Telefon", c => c.String(maxLength: 11));
            AlterColumn("IkraDesk.PersonellerTB", "DigerBilgiler", c => c.String(maxLength: 1000));
        }
        
        public override void Down()
        {
            AlterColumn("IkraDesk.PersonellerTB", "DigerBilgiler", c => c.String());
            AlterColumn("IkraDesk.PersonellerTB", "Telefon", c => c.String());
            AlterColumn("IkraDesk.PersonellerTB", "Gorevi", c => c.String());
        }
    }
}
