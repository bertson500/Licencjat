using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SystemSprzedazyInternetowej.Models;

namespace SystemSprzedazyInternetowej.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Category> Categories { get; set; }
        
    }
}