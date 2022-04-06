
using System.Collections;

ArrayList isimlerListesi = new ArrayList();

isimlerListesi.Add("Ali");

isimlerListesi.Add("Cem");

isimlerListesi.Add(1);

isimlerListesi.Add(true);


foreach (object isim in isimlerListesi)
{
    Console.WriteLine(isim);
}

isimlerListesi.Add("Fatih");

foreach (object isim in isimlerListesi)
{
    Console.WriteLine(isim);
}


// generic tip koleksiyon, tip güvenli
List<int> sayilarListesi = new List<int>();
sayilarListesi.Add(24);
sayilarListesi.Add(5);
sayilarListesi.Add(12);

foreach (int sayi in sayilarListesi)
{
    Console.WriteLine(sayi);
}


List<string> sehirListesi = new List<string>()
{
    "Ankara",
    "İstanbul",
    "İzmir",
    "Adana"
};


IEnumerable<string> koleksiyon1 = new List<string>()
{
    "Çağıl", "Leo"
};

ICollection<int> koleksiyon2 = new List<int>()
{
    1, 2, 3
};

//1. yöntem toplama

int toplam = 0;
foreach (int sayi in koleksiyon2)
{
    toplam += sayi;
}
Console.WriteLine(toplam);

//2. yöntem toplama
Console.WriteLine(koleksiyon2.Sum()); // 6


Console.WriteLine(koleksiyon2.Count); // 3

Console.WriteLine(koleksiyon2.Max());  //3

Console.WriteLine(koleksiyon2.Average());  //2



string kelime = "ana";
IEnumerable<char> tersListe = kelime.Reverse();
string tersKelime = string.Join("", tersListe);
if (kelime == tersKelime)
{
    Console.WriteLine("Palindrom");
}
else
{
    Console.WriteLine("Palindrom değil");
}





//






List<Pet> petler = new List<Pet>()
{
    new Pet()
    {
        Name = "Leo",
        BirthDate = new DateTime(2014, 1, 1),
        Sex = Sex.Erkek
    },
    new Pet()
    {
        Name = "Angel",
        BirthDate = DateTime.Parse("13.06.1994"),
        Sex = Sex.Dişi
    }
};

Pet pet1 = new Pet()
{
    BirthDate = DateTime.Parse("05.09.2020"),
    Sex = Sex.Dişi,
    Name = "Rambo"
};
petler.Add(pet1);



foreach (Pet pet in petler)
{
    Console.WriteLine($"Adı: {pet.Name} Cinsiyeti: {pet.Sex} Doğum tarihi: {pet.BirthDate.ToShortDateString()}");
}

for (int i = 0; i < petler.Count; i++)
{
    Console.WriteLine("Adı: " + petler[i].Name + " Cinsiyeti: " + petler[i].Sex + " Doğum tarihi: " + petler[i].BirthDate.ToShortDateString());
}

Pet[] petler2 = new Pet[2]
{
    new Pet()
    {
        BirthDate = DateTime.Parse("08.07.1998"),
        Name = "Rocky",
        Sex = Sex.Erkek
    },
    new Pet()
    {
        BirthDate = DateTime.Parse("16.12.1990"),
        Name = "Riggs",
        Sex = Sex.Erkek
    }
};

petler.AddRange(petler2); // petler2 yi petlerin sonuna ekledik.



IEnumerable<string> names1 = new List<String>()
{
    "Max", "Charlize", "Robert", "Jasmine"
};

ICollection<string> names2 = new List<string>()
{
    "Max", "Charlize", "Robert", "Jasmine"
};

List<string> names3 = new List<string>()
{
    "Max", "Charlize", "Robert", "Jasmine"
};

// sadece list tipindeki değişkende .Sort methodu var

names3.Sort();

Console.WriteLine(names2.Contains("Max")); // true
//Console.WriteLine(names2.Contains<string>("Max")); // true, yukarının aynısı

Console.WriteLine(names2.Contains("max")); // false


Console.WriteLine(petler.Contains(new Pet() { BirthDate = DateTime.Parse("16.12.1990"), Name = "Riggs", Sex = Sex.Erkek }));  // false döner

Pet riggsPet = petler[4];
Console.WriteLine(petler.Contains(riggsPet)); // true

Console.WriteLine(petler.IndexOf(riggsPet)); // 4
Console.WriteLine(petler.LastIndexOf(riggsPet)); // 4

List<Pet> hayvanlar = new List<Pet>()
{
    new Pet()
    {
        BirthDate = DateTime.Parse("14.12.2012"),
        Name = "Deli Yürek",
        Sex = Sex.Erkek
    }
};
hayvanlar.Insert(0, new Pet() { Name = "---Seçiniz---" });

hayvanlar.RemoveAt(0); // seçiniz'i siler
var seciniz = hayvanlar[0];

bool silindiMi = hayvanlar.Remove(seciniz);


hayvanlar.Clear(); // içindeki bütün elemanlar temizlenir






class Pet
{
    public string Name { get; set; }
    public Sex Sex { get; set; }
    public DateTime BirthDate { get; set; }
}

enum Sex
{
    Erkek,
    Dişi
}
