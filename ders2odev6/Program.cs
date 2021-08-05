using System;

namespace ders2odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            product urun1 = new product();
            urun1.urunAdi = "klavye";
            urun1.urunFiyati = 30;
            urun1.yildizSayisi = "beş yıldız";

            product urun2 = new product();
            urun2.urunAdi = "mause";
            urun2.urunFiyati = 50;
            urun2.yildizSayisi = "dört yıldız";

            product urun3 = new product();
            urun3.urunAdi = "klavye";
            urun3.urunFiyati = 80;
            urun3.yildizSayisi = "beş yıldız";

            product[] urunler = new product[] { urun1, urun2, urun3 };

            foreach (product urun in urunler)
            {
                Console.WriteLine(urun.urunAdi + ":" + urun.urunFiyati + ":" + urun.yildizSayisi);


            }

            Console.WriteLine("foreach bitti");

            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].urunAdi + ":" + urunler[i].urunFiyati + ":" + urunler[i].yildizSayisi);
            }

            Console.WriteLine("for bitti");


            int x = 0;
            while (x <= urunler.Length)
                
            {
                Console.WriteLine(urunler[x].urunAdi + ":" + urunler[x].urunFiyati + ":" + urunler[x].yildizSayisi);
                x++;
            }


        }
        class product
        {
            public string urunAdi { get; set; }
            public int urunFiyati { get; set; }

            public string yildizSayisi { get; set; }
        }

    }
}
