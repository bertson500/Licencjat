using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SystemSprzedazyInternetowej.Models
{
    public class Cloth
    {
        public int ClothId { get; set; }
        public int CategoryId { get; set; }
        [Required(ErrorMessage ="Nazwa jest wymagana.")]
        public string NameOfClothes { get; set; }

        [Required(ErrorMessage = "Rozmiar jest wymagany")]
        [RegularExpression("^[A-Z]$",ErrorMessage = "Muszą być podane wielkie litery z zakresu od A-Z")]
        [StringLength(2)]
        public string SizeCloth { get; set; }
        //tutaj chyba zrobię listę kolorów do wyboru
        public string ColorCloth { get; set; }
        public DateTime DateAddCloth { get; set; }
        public string ImageClothFileName { get; set; }
        public string DescriptionCloth { get; set; }
        [Required(ErrorMessage = "Cena jest wymagana, podaj cenę.")]
        public decimal ClothPrice { get; set; }
        [Required(ErrorMessage = "Wybierz czy produkt jest z wyprzedaży")]
        public bool SaleCloth { get; set; }
        public int SecretCloth { get; set; }
        public string ClotCutDescription { get; set; }

        

        public virtual Category Category { get; set; } //reference to clothes

    }
}