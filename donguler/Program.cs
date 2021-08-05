using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // alttaki şekilde ayrı ayrı değişkenlerde yazarsak çok gereksiz bilgi kirliliği oluşur. ve aynı şekilde her değişkenide ekrana yazdırmak gerekir.
            //bunun yerine dizi şeklinde yazılırlar veya çağırırlar.
            // string kurs1 = "yazılım geliştirici haırlık kursu";
            //string kurs2 = "programlamaya yeni başlangıç kursu";
            //string kurs3 = "java";

            //Console.WriteLine(kurs1);
            //Console.WriteLine(kurs2);
            //Console.WriteLine(kurs3); 

            // array-dizi
            string[] Kurslar = new string[] { "yazılım geliştirici haırlık kursu", "programlamaya yeni başlangıç kursu", "java"
            ,"python"};
            
            for (int i = 0; i < Kurslar.Length; i ++)
            {
                Console.WriteLine(Kurslar[i]);

            }
            Console.WriteLine("for bitti");
            foreach (string kurs in Kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
