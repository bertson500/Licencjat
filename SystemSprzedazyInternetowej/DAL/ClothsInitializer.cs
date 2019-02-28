using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SystemSprzedazyInternetowej.Models;

namespace SystemSprzedazyInternetowej.DAL
{
    public class ClothsInitializer : DropCreateDatabaseAlways<ShopDboContext>
    {
        protected override void Seed(ShopDboContext context)
        {
            SeedClothsData(context);
            base.Seed(context);
        }

        private void SeedClothsData(ShopDboContext context)
        {
            var category = new List<Category>
            {
                new Category(){CategoryId = 1, CategoryName = "Koszulka", CategoryDescription ="Modna koszulka holister", IconNameCategory = "plik.jpg"},
                new Category(){CategoryId = 2, CategoryName = "Spodnie", CategoryDescription="Super modne spodnie levis", IconNameCategory ="levis.jpg"}
            };
            category.ForEach(k => context.Categories.Add(k));
            context.SaveChanges();

            var cloth = new List<Cloth>
            {
                new Cloth(){CategoryId=1, NameOfClothes ="Koszulka holister 100% bawaełna", SizeCloth ="XL",
                    ColorCloth ="Niebieski", DateAddCloth = DateTime.Now, ImageClothFileName="holister.jpg",
                    DescriptionCloth = "Ekstrawagancka koszulka holister", ClothPrice = 90, SaleCloth = true,
                    SecretCloth = 1,ClotCutDescription = "Piękna koszuleczka"}
            };
            cloth.ForEach(k => context.Cloths.Add(k));
            context.SaveChanges();

            
        }
    }
}