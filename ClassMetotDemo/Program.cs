using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.MusteriId = 1;
            musteri1.MusteriAdi = "Musa";
            musteri1.MusteriSoyadi = "Eroğul";
            musteri1.MusteriTc = 123456789;

            Musteri musteri2 = new Musteri();

            musteri2.MusteriId = 2;
            musteri2.MusteriAdi = "Ali";
            musteri2.MusteriSoyadi = "Şen";
            musteri2.MusteriTc = 123456789;

            Musteri musteri3 = new Musteri();

            musteri3.MusteriId = 3;
            musteri3.MusteriAdi = "Veli";
            musteri3.MusteriSoyadi = "Kaçar";
            musteri3.MusteriTc = 123456789;


            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3 };

            MusteriManager musteriManager = new MusteriManager();


            foreach (var musterilistesi in musteriler)
            {
               MusteriManager.MusteriEkle(musterilistesi);
                MusteriManager.MusteriSil(musterilistesi);
                MusteriManager.MusteriListele(musterilistesi);

                
            }




        }
    }

    class Musteri
    {

        public int MusteriId { get; set; }
        public int MusteriTc { get; set; }
        public string MusteriAdi { get; set; }
        public string MusteriSoyadi { get; set; }

    }
}
