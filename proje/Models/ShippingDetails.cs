using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace proje.Models
{
    public class ShippingDetails
    {
        public string UserName { get; set; }


        [Required(ErrorMessage = "Lütfen Bir Adres Tanımı Giriniz")]
     
        public string AdresBasligi { get; set; }


        [Required(ErrorMessage = "Lütfen Bir Adres Giriniz")]

        public string Adres { get; set; }

        [Required(ErrorMessage = "Lütfen Bir Şehir Giriniz")]

        public string Sehir { get; set; }

        [Required(ErrorMessage = "Lütfen Bir Semt Giriniz")]

        public string Semt { get; set; }

        [Required(ErrorMessage = "Lütfen Bir Mahalle Giriniz")]

        public string Mahalle { get; set; }

        [Required(ErrorMessage = "Lütfen Bir Posta Kodu Giriniz")]

        public string PostaKodu { get; set; }


    }
}