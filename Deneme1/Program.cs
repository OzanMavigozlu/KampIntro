using System;

namespace xd
{
    class Program
    {
        static void Main(string[] args)
        {

            Product Mal1 = new Product();
            Mal1.MalAdi = "Razer Kulaklık";
            Mal1.MalMihtari = 25;
            Mal1.MalinFiyati = 99;

            Product Mal2 = new Product();
            Mal2.MalAdi = "Razer Klavye";
            Mal2.MalMihtari = 50;
            Mal2.MalinFiyati = 189;


            Product Mal3 = new Product();
            Mal3.MalAdi = "Razer MousePad";
            Mal3.MalMihtari = 30;
            Mal3.MalinFiyati = 60;


            Product Mal4 = new Product();
            Mal4.MalAdi = "Razer Mouse";
            Mal4.MalMihtari = 50;
            Mal4.MalinFiyati = 122;

            Product Mal5 = new Product();
            Mal5.MalAdi = "Oyuncu Sandalyesi";
            Mal5.MalMihtari = 40;
            Mal5.MalinFiyati = 600;


            Product[] Mallar = new Product[] { Mal1, Mal2, Mal3, Mal4, Mal5 };

            for (int i = 0; i < Mallar.Length; i++)
            {
                Console.WriteLine(Mallar[i].MalAdi, Mallar[i].MalMihtari, Mallar[i].MalinFiyati);
            }

            Console.WriteLine("---------------------------------------------------");

            foreach (var Product in Mallar)
            {
                Console.WriteLine(Product.MalAdi + " : " + Product.MalMihtari);
            }

            Console.WriteLine("---------------------------------------------------");

            int x = 0;
            while (x < Mallar.Length)
            {
                Console.WriteLine(Mallar[x].MalAdi);
                x++;
            }



        }
    }
}
class Product
{
    public string MalAdi { get; set; }
    public int MalMihtari { get; set; }
    public int MalinFiyati { get; set; }



}




