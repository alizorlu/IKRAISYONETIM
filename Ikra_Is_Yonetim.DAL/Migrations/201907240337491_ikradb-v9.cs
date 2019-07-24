namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv9 : DbMigration
    {
        public override void Up()
        {
            AddColumn("IkraDesktop.StoklarTB", "StokKgBirimAlinan", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("IkraDesktop.StoklarTB", "StokKgBirimKalan", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("IkraDesktop.StoklarTB", "StokKgBirim");
        }
        
        public override void Down()
        {
            AddColumn("IkraDesktop.StoklarTB", "StokKgBirim", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("IkraDesktop.StoklarTB", "StokKgBirimKalan");
            DropColumn("IkraDesktop.StoklarTB", "StokKgBirimAlinan");
        }
    }
}
