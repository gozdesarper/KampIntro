using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "gözde";
            int yas = 26;
            kurs kurs1 = new kurs(); // bu arkadaşın veri tipi kurs birçok değişken tutuyor içinde
            kurs1.kursAdi = "c#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 86;

            kurs kurs2 = new kurs(); 
            kurs2.kursAdi = "JAVA";
            kurs2.Egitmen = "TUĞÇE";
            kurs2.IzlenmeOrani = 66;

            kurs kurs3 = new kurs();
            kurs3.kursAdi = "PYTHON";
            kurs3.Egitmen = "GÖZDE";
            kurs3.IzlenmeOrani = 25;

            // Console.WriteLine(kurs1.kursAdi + " : " + kurs1.IzlenmeOrani);

            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3 };

            foreach (kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi);
            }



        }
    }
    class kurs
        {
        public string kursAdi { get; set; }
        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
        }
        
    
}
