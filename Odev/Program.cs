using System;

namespace Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();

            urun1.urunAdi = "İphone 13";
            urun1.urunFiyat = 9000;
            urun1.urunRenk = "Siyah";

            Urun urun2 = new Urun();

            urun2.urunAdi = "Laptop";
            urun2.urunFiyat = 5000;
            urun2.urunRenk = "Kırmızı";

            Urun urun3 = new Urun();

            urun3.urunAdi = "Blender";
            urun3.urunFiyat = 1750;
            urun3.urunRenk = "Beyaz";

            Urun urun4 = new Urun();

            urun4.urunAdi = "Elbise Dolabı";
            urun4.urunFiyat = 950;
            urun4.urunRenk = "Gri";

            Urun[] urunler = new Urun[] {urun1,urun2,urun3,urun4 };

            foreach (Urun abc in urunler)
            {
                Console.WriteLine("Ürün Adı:"+urun1.urunAdi+"  "  +"Urun Fiyatı:"+urun1.urunFiyat+" " +"Ürün Renk:"+urun1.urunRenk);
                Console.WriteLine("Ürün Adı:" + urun2.urunAdi + "  " + "Urun Fiyatı:" + urun2.urunFiyat + " " + "Ürün Renk:" + urun2.urunRenk);
                Console.WriteLine("Ürün Adı:" + urun3.urunAdi + "  " + "Urun Fiyatı:" + urun3.urunFiyat + " " + "Ürün Renk:" + urun3.urunRenk);
                Console.WriteLine("Ürün Adı:" + urun4.urunAdi + "  " + "Urun Fiyatı:" + urun4.urunFiyat + " " + "Ürün Renk:" + urun4.urunRenk);
            }
        }
    }



    class Urun
    {
        public string urunAdi { get; set; }
        public int urunFiyat { get; set; }
        public string urunRenk { get; set; }
    }
}

