namespace SystemSprzedazyInternetowej.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using SystemSprzedazyInternetowej.DAL;

    public sealed class Configuration : DbMigrationsConfiguration<ShopDboContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "SystemSprzedazyInternetowej.DAL.ShopDboContext";
        }

        protected override void Seed(ShopDboContext context)
        {
            ClothsInitializer.SeedClothsData(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
