namespace SystemSprzedazyInternetowej.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dodanieplciwtabelicategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Category", "TypeSexForClient", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Category", "TypeSexForClient");
        }
    }
}
