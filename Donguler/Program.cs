using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici kursu";
            string kurs2 = "Programaya giriş Kursu";
            string kurs3 = "Java Kursu";
            string kurs4 = "Python Kursu";

          //  Console.WriteLine(kurs1);
          //  Console.WriteLine(kurs2);
          //  Console.WriteLine(kurs3);
          //  Console.WriteLine(kurs4);

            string[] kurslar = new string[] { kurs1,kurs2,kurs3 };

            for (int i = 0; i <kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);


            }

            Console.WriteLine("For Döngüsü bitti..");

            foreach (string kurs in kurslar)
            {

                Console.WriteLine(kurs);

            }

        }
    }
}
