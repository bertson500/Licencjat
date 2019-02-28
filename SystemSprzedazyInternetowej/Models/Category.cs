using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SystemSprzedazyInternetowej.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public string IconNameCategory { get; set; }

        

        public virtual ICollection<Cloth> Cloth { get; set; } //Collection in which they will be stored clothes. 
    }
} 