using System;

namespace NTP_Projeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Mutlucan";
            musteri1.Soyadi = "Çelik";
            musteri1.Telefon = "01234567890";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Emre";
            musteri2.Soyadi = "Boyacı";
            musteri2.Telefon = "01234567890";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Mahmut Can";
            musteri3.Soyadi = "Çankaya";
            musteri3.Telefon = "05534598779";

            Musteri[] musteriler = { musteri1, musteri2, musteri3 };

            MusteriManager manager = new MusteriManager();


            foreach (var musteri in musteriler)
            {
                manager.Add(musteri);
            }

            Console.WriteLine("----- Müşteri Listesi -----");
            manager.GetAllMusteri();
            musteri1.Adi = "Mutlu2";
            manager.Update(musteri1);
            manager.Delete(musteri3);

            Console.WriteLine("----- Müşteri Listesi -----");
            manager.GetAllMusteri();
        }
    }
}
