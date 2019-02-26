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
        private ShopContext db = new ShopContext();

        

        public ActionResult Index()
        {
            Category category = new Category
            {
                CategoryName = "Koszulka",
                CategoryDescription = "Ładna koszulka",
                IconNameCategory = "koszulka.jpg"
            };

            db.Categories.Add(category);
            db.SaveChanges();

            return View();
        }
    }
}