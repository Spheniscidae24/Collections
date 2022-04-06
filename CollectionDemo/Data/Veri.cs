using CollectionDemo.Enum;
using CollectionDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo.Data
{
    public static class Veri
    {
        public static List<Ogrenci> Ogrenciler { get; set; } // = new List<Ogrenci>(){  ogrenci tipinde ogrenci objeleri }; veya constructorda da olabilir

        static Veri()
        {
            Ogrenciler = new List<Ogrenci>()
            {
                new Ogrenci()
                {
                    Adi = "Kıvanç",
                    Soyadi = "Timur",
                    Cinsiyet = Cinsiyet.Erkek,
                    DogumTarihi = new DateTime(1993, 07, 24),
                    Id = 1,
                    NotOrtalamasi = 2.8
                },
                new Ogrenci(2, "Leo", "Alsaç", DateTime.Parse("01.05.2014"), Cinsiyet.Erkek, false, 1.5)
            };
        }
    }
}
