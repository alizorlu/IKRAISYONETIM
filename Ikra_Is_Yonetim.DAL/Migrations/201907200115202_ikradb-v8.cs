namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv8 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "IkraGenel.Emai",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        EmailAddres = c.String(),
                        Port = c.String(),
                        Host = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("IkraGenel.Emai");
        }
    }
}
