using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            string Ad = "Elmas";
            int fiyat = 15;
            string Aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();

            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Çilek";
            urun2.Fiyati = 10;
            urun2.Aciklama = "Sinop Çileği";

            Urun[] urunler = new Urun[] {urun1,urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("-----------------------");
            }

            Console.WriteLine("------Metotlar------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil Armut",12,10);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,5);

        }
    }
}
