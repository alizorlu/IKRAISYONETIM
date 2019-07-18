namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "IkraGenel.Kullanicilar",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        AdSoyad = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                        CreateTime = c.DateTime(nullable: false),
                        LastLogin = c.DateTime(nullable: false),
                        IsAdmin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("IkraGenel.Kullanicilar");
        }
    }
}
