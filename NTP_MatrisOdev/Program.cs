using System;

namespace NTP_MatrisOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            int satir;
            int sutun;
            Console.Write("Satır sayısını gir :");
            satir = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sütun sayısını gir :");
            sutun = Convert.ToInt32(Console.ReadLine());

            //MatrisA : 1,3,2,4
            //MatrisB : 2,3,1,5


            int[,] matrisA = new int[satir, sutun];
            int[,] matrisB = new int[satir, sutun];
            int[,] matrisC = new int[satir, sutun];

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write("MatrisA değerlerini girin :");
                    matrisA[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write("MatrisB değerlerini girin :");
                    matrisB[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    matrisC[i, j] = 0;
                    for (int k = 0; k < sutun; k++)
                    {
                        matrisC[i, j] += matrisA[i, k] * matrisB[k, j];
                    }
                }
            }

            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < sutun; j++)
                {
                    Console.Write("Matris C : " + matrisC[i, j]);
                }
            }
        }
    }
}
