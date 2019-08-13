namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv40 : DbMigration
    {
        public override void Up()
        {
            AddColumn("IkraGenel.MusterilerTB", "GunlukYemekFiyati", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("IkraGenel.MusterilerTB", "GunlukYemekFiyati");
        }
    }
}
