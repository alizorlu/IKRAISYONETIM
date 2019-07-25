namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv15 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("IkraDesk.PersonellerTB", "Telefon", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("IkraDesk.PersonellerTB", "Telefon", c => c.String(maxLength: 11));
        }
    }
}
