using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1= new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Python";
            kurs2.Egitmen = "Kadir Halı";
            kurs2.IzlenmeOrani = 80;

            Console.WriteLine(kurs1.KursAdi+" : " + kurs1.Egitmen);
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
