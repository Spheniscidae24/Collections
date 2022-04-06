using CollectionDemo.Data;
using CollectionDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo.DataAccess
{
    public class VeriErişim
    {
        //CRUD: create read update delete
        public void Ekle(Ogrenci ogrenci)
        {
            Veri.Ogrenciler.Add(ogrenci);
        }

        public List<Ogrenci> Oku()
        {
            return Veri.Ogrenciler;
        }

        public void Guncelle(Ogrenci ogrenci)
        {
            Ogrenci listedekiOgrenci = null;
            foreach (Ogrenci veriOgrenci in Veri.Ogrenciler)
            {
                if (veriOgrenci.Id == ogrenci.Id)
                {
                    listedekiOgrenci = veriOgrenci;
                    break;
                }
            }
            if (listedekiOgrenci != null)
            {
                listedekiOgrenci.Adi = ogrenci.Adi;
                listedekiOgrenci.Soyadi = ogrenci.Soyadi;
                listedekiOgrenci.DogumTarihi = ogrenci.DogumTarihi;
                listedekiOgrenci.Cinsiyet = ogrenci.Cinsiyet;
                listedekiOgrenci.MezunMu = ogrenci.MezunMu;
                listedekiOgrenci.NotOrtalamasi = ogrenci.NotOrtalamasi;
            }
        }

        public void Sil(Ogrenci ogrenci)
        {
            Veri.Ogrenciler.Remove(ogrenci);
        }
    }
}
