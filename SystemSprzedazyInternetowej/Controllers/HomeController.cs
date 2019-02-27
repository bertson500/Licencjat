using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SystemSprzedazyInternetowej.DAL;
using SystemSprzedazyInternetowej.Models;

namespace SystemSprzedazyInternetowej.Controllers
{
    public class HomeController : Controller
    {
        private ShopDboContext db = new ShopDboContext();

        

        public ActionResult Index()
        {
            for (int i = 0; i < 10000000; i++)
            {
                Category category = new Category
                {
                    CategoryName = "Koszulka"+i,
                    CategoryDescription = "Ładna koszulka" +i*2,
                    IconNameCategory = "koszulka1.jpg"
                };
                db.Categories.Add(category);
                db.SaveChanges();
            }
            

            return View();
        }
    }
}