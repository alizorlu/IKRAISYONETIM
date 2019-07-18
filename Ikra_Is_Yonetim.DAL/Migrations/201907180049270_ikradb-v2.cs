namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("IkraGenel.Kullanicilar", "Email", c => c.String(nullable: false));
            AddColumn("IkraGenel.Kullanicilar", "Phone", c => c.String(nullable: false));
            AlterColumn("IkraGenel.Kullanicilar", "AdSoyad", c => c.String(nullable: false));
            AlterColumn("IkraGenel.Kullanicilar", "UserName", c => c.String(nullable: false));
            AlterColumn("IkraGenel.Kullanicilar", "Password", c => c.String(nullable: false));
            DropColumn("IkraGenel.Kullanicilar", "IsAdmin");
        }
        
        public override void Down()
        {
            AddColumn("IkraGenel.Kullanicilar", "IsAdmin", c => c.Boolean(nullable: false));
            AlterColumn("IkraGenel.Kullanicilar", "Password", c => c.String());
            AlterColumn("IkraGenel.Kullanicilar", "UserName", c => c.String());
            AlterColumn("IkraGenel.Kullanicilar", "AdSoyad", c => c.String());
            DropColumn("IkraGenel.Kullanicilar", "Phone");
            DropColumn("IkraGenel.Kullanicilar", "Email");
        }
    }
}
