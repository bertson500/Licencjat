using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemSprzedazyInternetowej.Models
{
    public class Cloth
    {
        public int ClothId { get; set; }
        public int CategoryId { get; set; }
        public string NameOfClothes { get; set; }
        public string SizeCloth { get; set; }
        public string ColorCloth { get; set; }
        public DateTime DateAddCloth { get; set; }
        public string ImageClothFileName { get; set; }
        public string DescriptionCloth { get; set; }
        public decimal ClothPrice { get; set; }
        public bool SaleCloth { get; set; }
        public int SecretCloth { get; set; }
        public string ClotCutDescription { get; set; }

        public virtual Category Category { get; set; } //reference to clothes

    }
}