using CollectionDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo.DataAccess.Bases
{
    public interface IOgrenciVeriErisim
    {
        //CRUD: create read update delete
        void Ekle(Ogrenci ogrenci); // create kuralı mutlaka bu interface'i implemente eden class'larda uygulanmalıdır. yani methodu oluşturulup içi doldurulmalıdır.

        List<Ogrenci> Oku(); // read kuralı mutlaka.....

        void Guncelle(Ogrenci ogrenci); // update kuralı mutlaka.....

        void Sil(Ogrenci ogrenci); // delete kuralı mutlaka.....
    }
}
