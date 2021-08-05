using System;

namespace metot
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "elma";
            int urunFiyati = 80;
            string aciklama = "amasya elması";

            string[]  meyveler = new string[] { };

            urun urun1 = new urun();
            urun1.urunAdi = "elma";
            urun1.urunFiyati = 20 ;
            urun1.aciklama = "amasya elması";

            urun urun2 = new urun();
            urun2.urunAdi = "çilek";
            urun2.urunFiyati = 10;
            urun2.aciklama = "dağ çileği";

            urun[] urunler = new urun[] {urun1,urun2 };

            // type safety - tip güvenliği veri tipini yazacaksın diyor.

            foreach (urun urun in urunler) // varda kalabilir ototmatik olarak veri tipinin urun olduğunu anlıyor.
            {
                //Console.WriteLine(urun.urunAdi + " : " + urun.urunFiyati + " : " + urun.aciklama);
                Console.WriteLine(urun.urunAdi);
                Console.WriteLine(urun.urunFiyati);
                Console.WriteLine(urun.aciklama);

            }

            Console.WriteLine("........METOTLAR...........");

            sepetmanager sepetmanager = new sepetmanager();

            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);

            sepetmanager.Ekle2(urun1);
            sepetmanager.Ekle2(urun2);





        }
    }
}
