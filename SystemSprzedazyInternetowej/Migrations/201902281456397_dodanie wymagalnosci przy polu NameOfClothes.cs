namespace SystemSprzedazyInternetowej.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dodaniewymagalnosciprzypoluNameOfClothes : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cloth", "NameOfClothes", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cloth", "NameOfClothes", c => c.String());
        }
    }
}
