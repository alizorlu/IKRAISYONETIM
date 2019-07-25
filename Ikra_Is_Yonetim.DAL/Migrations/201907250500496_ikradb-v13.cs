namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv13 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("IkraDesk.PersonellerTB", "AdSoyad", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("IkraDesk.PersonellerTB", "AdSoyad", c => c.String());
        }
    }
}
