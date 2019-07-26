namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv22 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "IkraGenel.SirketBilgiTB",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        VATNo = c.String(),
                        SiteName = c.String(),
                        Logo = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("IkraGenel.SirketBilgiTB");
        }
    }
}
