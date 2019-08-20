namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv67 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("IkraGenel.MusterilerTB", "Telefon", c => c.String(nullable: false));
            AlterColumn("IkraGenel.MusterilerTB", "FirmaAdSoyad", c => c.String(nullable: false));
            AlterColumn("IkraGenel.MusterilerTB", "Email", c => c.String(nullable: false));
            AlterColumn("IkraGenel.MusterilerTB", "FirmaAdres", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("IkraGenel.MusterilerTB", "FirmaAdres", c => c.String());
            AlterColumn("IkraGenel.MusterilerTB", "Email", c => c.String());
            AlterColumn("IkraGenel.MusterilerTB", "FirmaAdSoyad", c => c.String());
            AlterColumn("IkraGenel.MusterilerTB", "Telefon", c => c.String());
        }
    }
}
