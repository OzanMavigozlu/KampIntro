using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Ozan";
            string yas = "18";

            Kurs kurs1= new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Eğitmen = "Ozi";
            kurs1.İzlenmeOrani = 68;
            kurs1.Ülkesi = "Kıbrıs";


            Kurs kurs2= new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Eğitmen = "Arda";
            kurs2.İzlenmeOrani = 100;
            kurs2.Ülkesi = "Kıbrıs";

            Kurs kurs3= new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Eğitmen = "Hüsniye";
            kurs3.İzlenmeOrani = 41;
            kurs3.Ülkesi = "Jameyka";

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Eğitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

            foreach (var kurs in kurslar)
            {
                //Console.WriteLine(kurs.KursAdi);
                
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Eğitmen);
            }


        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Eğitmen { get; set; }
        public  string Ülkesi { get; set; }
        public int İzlenmeOrani { get; set; }
        


    }
}
