using System;
using System.Collections;

class MusteriManager{

    ArrayList musteriArray = new ArrayList(); 

    public void MusteriEkle(Musteri musteri){
        musteriArray.Add(musteri);
        Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " eklendi.");
    }

    public void MusteriSil(int id){
        musteriArray.RemoveAt(id-1);
        Console.WriteLine("Müşteri silindi.");
    }

    public void MusteriListele(){
        foreach(Musteri item in musteriArray){
            Console.WriteLine(item.ID + " " + item.Ad + " " + item.Soyad);
        }
    }
}