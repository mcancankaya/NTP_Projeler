using System;
using System.Collections.Generic;

namespace NTP_Projeler
{
    class MusteriManager
    {
        List<Musteri> musteriler;
        public MusteriManager()
        {
            musteriler = new List<Musteri>();
        }
        public void Add(Musteri musteri)
        {
            musteriler.Add(musteri);
            Console.WriteLine("Müşteri Eklendi : " + musteri.Adi);
        }

        public void Delete(Musteri musteri)
        {
            musteriler.Remove(musteri);
            Console.WriteLine("Müşteri Silindi : " + musteri.Adi);
        }
        public void Update(Musteri musteri)
        {
            var result = musteriler.Find(m => m.Id == musteri.Id);
            result.Adi = musteri.Adi;
            result.Soyadi = musteri.Soyadi;
            result.Telefon = musteri.Telefon;

            Console.WriteLine("Müşteri Güncellendi : " + musteri.Adi);
        }
        public void GetAllMusteri()
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşteri Adı : " + musteri.Adi + "\nMüşteri Soyadı : " + musteri.Soyadi + "\nMüşteri Telefon : " + musteri.Telefon);
                Console.WriteLine("-----  -----  -----  -----  -----");
            }
        }
    }
}
