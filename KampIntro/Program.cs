using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler ve Diğerleri";

            int ogrenciSayisi = 32000;
                        
            bool sistemeGirisYapmisMi = true;

            double dolarDun = 7.15;
            double dolarBugun = 7.15;

            if (dolarDun > dolarBugun) 
            {

                Console.WriteLine("Azalış butonu");

            }

            else if(dolarDun < dolarBugun)
            {
                Console.WriteLine("artış butonu");
            
            }

            else
            {
                Console.WriteLine("eşittir butonu");
            }
        }
    }
}
