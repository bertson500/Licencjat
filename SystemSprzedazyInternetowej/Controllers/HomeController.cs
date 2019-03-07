using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SystemSprzedazyInternetowej.DAL;
using SystemSprzedazyInternetowej.Models;
using SystemSprzedazyInternetowej.ViewModels;

namespace SystemSprzedazyInternetowej.Controllers
{
    public class HomeController : Controller
    {
        private ShopDboContext db = new ShopDboContext();

        

        public ActionResult Index()
        {
            

            return View();
        }

        public ActionResult StaticPages(string name)
        {
            return View(name);
        }
        //dodaje kontroler dla menu kategorii
        public ActionResult SideMenuCategory()
        {
            var categories = db.Categories.ToList();
            
            var vNavbarModel = new HomeViewModel
            {
                Categories = categories
            };
            return PartialView("_SideMenuCategory", vNavbarModel);
       }
    }
}