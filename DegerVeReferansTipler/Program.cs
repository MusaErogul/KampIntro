﻿using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 20;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 değeri 10 olur.


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] = ??
            //sayilar1[0] = 999 olur.            
            //**Değer diplerde değerler değiştirken Referans tiplerde Adresler değişir..




        }
    }
}
