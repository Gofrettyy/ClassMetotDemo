// See https://aka.ms/new-console-template for more information

using ClassMetotDemo;

Console.WriteLine("Hello, World!");

Musteri musteri1 = new Musteri();
musteri1.Id = 1;
musteri1.FirstName = "Nazife";
musteri1.LastName = "Aliçavuş";
musteri1.TcKimlikNo = 121212121212;

Musteri musteri2 = new Musteri();
musteri2.Id = 2;
musteri2.FirstName = "Vijdan";
musteri2.LastName = "Aliçavuş";
musteri2.TcKimlikNo = 32323232332;

Musteri musteri3 = new Musteri();
musteri3.Id = 3;
musteri3.FirstName = "Özcan";
musteri3.LastName = "Aliçavuş";
musteri3.TcKimlikNo = 32423434234;


/*Musteri[] musteriler = new Musteri[]
{
    musteri1, musteri2
};*/
// yukarıdaki eklemeyi normalde biz listelerle yaparız 

List<Musteri> musteriler = new List<Musteri>
{
    musteri1, musteri2
}; // projelerimizde böyle yapacağız.
// Birde dictionary yapısıyla Add işlemini yapalım. 

//Dictionary kullanarak müşterinin sisteme dahil olup olmadığını Tc kimlik no ile sorgulayan bir program yazalım.
Dictionary<int, string> musterilerDictionary = new Dictionary<int, string>();
musterilerDictionary.Add(1234567,"Melek Şubaşı");
musterilerDictionary.Add(8912345,"Kardelen Demir");
musterilerDictionary.Add(9012345,"İlknur Karaca");
musterilerDictionary.Add(0123456,"Faruk Kaleli");

Console.WriteLine("Tc Kimlik No giriniz:");
int No = int.Parse(Console.ReadLine());

try
{
    Console.WriteLine("Bu müşteri sistemde var:" + musterilerDictionary[No]);
}
catch
{
    Console.WriteLine("Musteri bulunamadı.");
}

foreach (var musteris in musteriler)
{
    Console.WriteLine(musteris.Id);
    Console.WriteLine(musteris.FirstName);
    Console.WriteLine(musteris.LastName);
    Console.WriteLine(musteris.TcKimlikNo);
}

MusteriManager musteriManager = new MusteriManager();
musteriManager.Add(musteri1);
musteriManager.Delete(musteri2);
musteriManager.Listed(musteri3);