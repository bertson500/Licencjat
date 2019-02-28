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

        //[Required(ErrorMessage = "Rozmiar jest wymagany")]
        //[RegularExpression("^[A-Z]$",ErrorMessage = "Muszą być podane wielkie litery z zakresu od A-Z")]
        //[StringLength(2)]
        public string SizeCloth { get; set; }
        //tutaj chyba zrobię listę kolorów do wyboru
        public string ColorCloth { get; set; }
        public DateTime DateAddCloth { get; set; }
        public string ImageClothFileName { get; set; }
        public string DescriptionCloth { get; set; }
        //[Required(ErrorMessage = "Cena jest wymagana, podaj cenę.")]
        public decimal ClothPrice { get; set; }
        //[Required(ErrorMessage = "Wybierz czy produkt jest z wyprzedaży")]
        public bool SaleCloth { get; set; } //if cloth is on sale true
        public int SecretCloth { get; set; } //when cloth is unavailable 0 available 1
        public string ClotCutDescription { get; set; } //short description cloths
        public string ClothColleciton { get; set; }

        

        public virtual Category Category { get; set; } //reference to clothes

    }
}