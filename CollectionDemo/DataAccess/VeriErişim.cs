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
            int id;
            if (Veri.Ogrenciler.Count == 0)
            {
                id = 1;
            }
            else
            {
                id = Veri.Ogrenciler[Veri.Ogrenciler.Count - 1].Id;
                id++;
            }
            ogrenci.Id = id;
            Veri.Ogrenciler.Add(ogrenci);
        }

        public List<Ogrenci> Oku()
        {
            return Veri.Ogrenciler;
        }

        public void Guncelle(Ogrenci ogrenci, int id)
        {
            Ogrenci listedekiOgrenci = Oku(id);
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

        public void Sil(int id)
        {
            Ogrenci listedekiOgrenci = Oku(id);
            Sil(listedekiOgrenci);
        }

        public Ogrenci Oku(int id)
        {
            Ogrenci listedekiOgrenci = null;
            foreach (Ogrenci veriOgrenci in Veri.Ogrenciler)
            {
                if (veriOgrenci.Id == id)
                {
                    listedekiOgrenci = veriOgrenci;
                    break;
                }
            }

            return listedekiOgrenci;
        }
    }
}
