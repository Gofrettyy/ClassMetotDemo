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


Musteri[] musteriler = new Musteri[]
{
    musteri1, musteri2
};

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