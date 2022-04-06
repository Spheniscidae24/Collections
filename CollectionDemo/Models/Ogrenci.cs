using CollectionDemo.Enum;
using CollectionDemo.Models.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo.Models
{
    public class Ogrenci : KayitBase
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public bool MezunMu { get; set; } = true;
        public double NotOrtalamasi { get; set; }

        public Ogrenci() : base()
        {
            Adi = "";
            Soyadi = "";
            Cinsiyet = Cinsiyet.Erkek;
        }

        public Ogrenci(int id, string adi, string soyadi, DateTime dogumTarihi, Cinsiyet cinsiyet, bool mezunMu, double notOrtalamasi) : base(id)
        {
            //Id = id; yapılan doğrudur ama kalıtımda constructor kullanımı örneği için devre dışı bırakılmıştır
            Adi = adi;
            Soyadi = soyadi;
            DogumTarihi = dogumTarihi;
            Cinsiyet = cinsiyet;
            MezunMu = mezunMu;
            NotOrtalamasi = notOrtalamasi;
        }
    }
}
