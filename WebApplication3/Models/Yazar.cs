using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Yazar
    {//her model aynı zamanda veri tabanı tablosudur.
        public int YazarId { get; set; }//öz nitelik ekleyeceğiz
        [Required(ErrorMessage ="Yazar Adı Soyadı Alanına Değer Girmediniz")]//hata mesajı vermesi için
        [StringLength(100,ErrorMessage ="Ad Soyad Alanı 100 Karakterden Fazla Olamaz.")]
        public string YazarAdiSoyadi { get; set; }
        public DateTime YazarDogumTarihi { get; set; }


        [Required(ErrorMessage ="e-posta adresi girmediniz")]
        public string YazarEmailAdresi { get; set; }
    }
}