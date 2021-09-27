using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)                             
             

        {
            Kurs kurs1 = new Kurs();

            kurs1.Egitmen = "Musa Eroğul";
            kurs1.kursAdi = "Yazılım Geliştirme Kursu";
            kurs1.ogrenciSayisi = 80;



            Kurs kurs2 = new Kurs();

            kurs2.Egitmen = "Emrah Keleş";
            kurs2.kursAdi = "Python Kursu";
            kurs2.ogrenciSayisi = 60;



            Kurs kurs3 = new Kurs();

            kurs3.Egitmen = "Ali Veli";
            kurs3.kursAdi = "Java Kursu";
            kurs3.ogrenciSayisi = 50;

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi+" : "+kurs.Egitmen);

            }

            
        

            //Console.WriteLine(kurs1.kursAdi+" : "+kurs1.Egitmen,kurs2.kursAdi+" : "+kurs2.Egitmen);
                    

            //Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {

        public string kursAdi { get; set; }
        public string Egitmen { get; set; }
        public int ogrenciSayisi { get; set; }
    }
    
    }

