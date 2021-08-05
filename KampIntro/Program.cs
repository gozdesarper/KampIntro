using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            string KategoriEklentisi = "kategoriler";
            int OgrenciSayısı = 3000;
            double FaizOrani = 1.45;
            bool KullaniciGirisiYapildimi = true;
            double DolarDun = 1.55;
            double DolarBugun = 1.65;

            Console.WriteLine(KategoriEklentisi);

            

            if (KullaniciGirisiYapildimi == true) 
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("giriş yap butonu");
            }

            if (DolarDun<DolarBugun)
            {
                Console.WriteLine("yükseliş oku");

            }

            else if (DolarDun>DolarBugun)
            {
                Console.WriteLine("azalış oku");

            }
            else
            {
                Console.WriteLine("değişmedi oku");
            }






        }
    }
}
