using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proje.Entity
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public bool Slider { get; set; }
        public bool IsHome { get; set; }
        public bool IsApproved { get; set; } //true false olayı
        public bool IsFeatured { get; set; } //öne çıkanlar tarzı
        public int CategoryId { get; set; } //category sayfası ile ilişkilendirme. bir ürünün bir kategorisi vardır
        public virtual Category Category { get; set; }
    }
}