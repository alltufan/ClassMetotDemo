using System;
namespace Odev_Hafta3
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Eklenen Müşteri: " + musteri.AdSoyad);
            Console.WriteLine("Eklenen Firma: " + musteri.Firma);
            Console.WriteLine("Toplam Bakiye: " + musteri.Meblag);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Silinen Müşteri: " + musteri.AdSoyad + " " + musteri.Firma);
        }
    }
}
