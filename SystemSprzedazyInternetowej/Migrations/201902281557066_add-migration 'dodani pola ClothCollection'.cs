namespace SystemSprzedazyInternetowej.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigrationdodanipolaClothCollection : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cloth", "ClothColleciton", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cloth", "ClothColleciton");
        }
    }
}
