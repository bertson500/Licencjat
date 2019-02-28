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
            var listCategory = db.Categories.ToList();
            return View();
        }
    }
}