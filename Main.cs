using System;

namespace ClassLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri(1, "Emre", "Tanrisever");
            Musteri musteri2 = new Musteri(2, "Deneme", "Tanrisever");
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriSil(2);
            musteriManager.MusteriListele();
        }
    }
}
