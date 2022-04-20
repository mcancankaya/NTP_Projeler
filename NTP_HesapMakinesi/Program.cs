using System;
using System.Collections.Generic;

namespace NTP_HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            bool durum = true;
            while (durum==true)
            {
                
                int islem,sayi1,sayi2;
                Console.WriteLine("-- Hesap Makinesine Hoşgeldiniz --");

                Console.WriteLine("Yapmak istediğiniz işlemi seçin\n" +
                    "1. Toplama\n" +
                    "2. Çıkarma\n" +
                    "3. Çarpma\n" +
                    "4. Bölme\n" +
                    "5. Çıkış Yap\n" +
                    "İşlem :");


                islem = Convert.ToInt32(Console.ReadLine());
                if (islem==5)
                {
                    Console.WriteLine("Program bitti.");
                    break;
                }
                Console.WriteLine("Sayı 1 Girin : ");
                sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Sayı 2 Girin : ");
                sayi2 = Convert.ToInt32(Console.ReadLine());
                switch (islem)
                {
                    case 1:
                        calculator.Toplama(sayi1,sayi2);
                        break;
                    case 2:
                        calculator.Cikarma(sayi1,sayi2);
                        break;
                    case 3:
                        calculator.Carpma(sayi1,sayi2);
                        break;
                    case 4:
                        calculator.Bolme(sayi1,sayi2);
                        break;
                    case 5:
                        durum = false;
                        Console.WriteLine("Program bitti...");
                        break;
                    default:
                        Console.WriteLine("Hatali Seçim");
                        break;
                }
            }

        }
    }
}
