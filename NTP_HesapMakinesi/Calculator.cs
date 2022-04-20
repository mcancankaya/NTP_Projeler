using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTP_HesapMakinesi
{
    public class Calculator
    {
        public void Toplama(int sayi1,int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("{0} + {1} = {2}",sayi1,sayi2,sonuc);
        }        
        public void Cikarma(int sayi1,int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            Console.WriteLine("{0} - {1} = {2}",sayi1,sayi2,sonuc);
        }
        public void Carpma(int sayi1,int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            Console.WriteLine("{0} * {1} = {2}",sayi1,sayi2, sonuc);
        }
        public void Bolme(int sayi1, int sayi2)
        {
            int sonuc = sayi1 / sayi2;
            Console.WriteLine("{0} / {1} = {2}",sayi1,sayi2, sonuc);
        }

    }
}
