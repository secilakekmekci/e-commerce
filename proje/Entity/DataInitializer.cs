using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proje.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext> 
        //modelde bir değişiklik olduğu zaman veri tabanını siler ve kendi oluşturur
        //böylece biz tekrar tekrar uğraşmayız
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {
                new Category() {Name="Kamera",Description="Kamera Ürünleri"},
                new Category() {Name="Bilgisayar",Description="Bilgisayar Ürünleri"}

            };
            foreach (var item in kategoriler)
            {
                context.Categories.Add(item);
            }
            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product() {Name="Canon Kamera",Description="Kamera",Price=2500,Stock=50,IsHome=true,CategoryId=1,Image="kamera1.jpg",IsApproved=true,IsFeatured=true},
                new Product() {Name="Lenovo Bilgisayar",Description="Bilgisayar",Price=11500,Stock=10,IsHome=true,CategoryId=2,Image="pc1.jpg",IsApproved=true,IsFeatured=true},
                 new Product() {Name="Casper Bilgisayar",Description="Bilgisayar",Price=9500,Stock=10,IsHome=true,CategoryId=2,Image="kamera2.jpg",IsApproved=true,IsFeatured=true}

            };
            foreach (var item in urunler)
            {
                context.Products.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);

        }
    }
}