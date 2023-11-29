namespace ClassMetotDemo;

public class MusteriManager
{
   public void Add(Musteri musteri)
    {
        Console.WriteLine("Musteri eklendi:" + musteri.FirstName + " " + musteri.LastName);
    }
   public void Delete(Musteri musteri)
   {
       Console.WriteLine("Musteri Silindi:" + musteri.FirstName + " " + musteri.LastName);
   }
   public void Listed(Musteri musteri)
   {
       Console.WriteLine("Musteri Listelendi:" + musteri.FirstName + " " + musteri.LastName);
       
   }



}