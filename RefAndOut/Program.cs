using System;

namespace RefOutMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 50;
            int sayi2 = 231;
            Topla(ref sayi1, 12);
            Topla2(out sayi2, 12);

        }

        static void Topla(ref int sayi1, int sayi2)
        {
            //sayi1 = 20;
            Console.WriteLine(sayi1 + sayi2);

        }
        static void Topla2(out int sayi1, int sayi2)
        {
            sayi1 = 10;
            Console.WriteLine(sayi1 + sayi2);

        }
    }
}