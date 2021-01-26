using System;

namespace Odev_Hafta3
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = "0001";
            musteri1.AdSoyad = "Ali Tufan";
            musteri1.Firma = "DeepOffshore";
            musteri1.Meblag = 1000000;

            Musteri musteri2 = new Musteri();
            musteri2.Id = "0002";
            musteri2.AdSoyad = "Tanju Karal";
            musteri2.Firma = "Karal Turizm";
            musteri2.Meblag = 200000;

            Musteri musteri3 = new Musteri();
            musteri3.Id = "0003";
            musteri3.AdSoyad = "Emre Kepenek";
            musteri3.Firma = "Enis Medikal";
            musteri3.Meblag = 5000000;

            Musteri musteri4 = new Musteri();
            musteri4.Id = "0004";
            musteri4.AdSoyad = "Kazım Kepenek";
            musteri4.Firma = "ENS Ecza Deposu";
            musteri4.Meblag = 10000000;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            foreach(Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " " + musteri.AdSoyad + " " + musteri.Firma + " " + musteri.Meblag);
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri3);

            musteriManager.Sil(musteri2);
            musteriManager.Sil(musteri4);
        }
    }
}
