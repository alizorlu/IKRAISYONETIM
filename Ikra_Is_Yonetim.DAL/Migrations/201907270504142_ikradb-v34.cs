namespace Ikra_Is_Yonetim.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ikradbv34 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "IkraGenel.KasaTB", newName: "KasalarTB");
        }
        
        public override void Down()
        {
            RenameTable(name: "IkraGenel.KasalarTB", newName: "KasaTB");
        }
    }
}
