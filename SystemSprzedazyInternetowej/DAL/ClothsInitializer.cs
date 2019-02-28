using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using SystemSprzedazyInternetowej.Migrations;
using SystemSprzedazyInternetowej.Models;

namespace SystemSprzedazyInternetowej.DAL
{      //Przy takim rozwiązaniu trzeba dodawać lub aktualizować model bazy danych tylko poprzez migracje!!!
    public class ClothsInitializer : MigrateDatabaseToLatestVersion<ShopDboContext, Configuration >
    {
        
        
        public static void SeedClothsData(ShopDboContext context)
        {
            var category = new List<Category>
            {
                new Category(){CategoryId = 1, CategoryName = "Koszulka", CategoryDescription ="Modna koszulka holister", IconNameCategory = "plik.jpg"},
                new Category(){CategoryId = 2, CategoryName = "Spodnie", CategoryDescription="Super modne spodnie levis", IconNameCategory ="levis.jpg"}
            };
            category.ForEach(k => context.Categories.AddOrUpdate(k));
            context.SaveChanges();

            var cloth = new List<Cloth>
            {
                new Cloth(){CategoryId=1, NameOfClothes ="Koszulka holister 100% bawaełna", SizeCloth ="XL",
                    ColorCloth ="Niebieski", DateAddCloth = DateTime.Now, ImageClothFileName="holister.jpg",
                    DescriptionCloth = "Ekstrawagancka koszulka holister", ClothPrice = 90, SaleCloth = true,
                    SecretCloth = 1,ClotCutDescription = "Piękna koszuleczka"}
            };
            cloth.ForEach(k => context.Cloths.AddOrUpdate(k));
            context.SaveChanges();

            
        }
    }
}