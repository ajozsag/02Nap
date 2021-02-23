using System;
using System.Text;

namespace ValtozokCore
{
    class Program
    {
        static void Main(string[] args)
        {
            //értéktípus
            var ertek1 = 10;

            var ertek2 = ertek1;

            Console.WriteLine($"ertek1: {ertek1}, ertek2: {ertek2}");

            ertek1 = 20;

            Console.WriteLine($"ertek1: {ertek1}, ertek2: {ertek2}");


            //referenciatípus
            var referencia1 = new Sajatreferencia();
            referencia1.ertek = 10;
            var referencia2 = referencia1;
            Console.WriteLine($"referencia1: {referencia1.ertek}, ertek2: {referencia2.ertek}");

            referencia1.ertek = 20;
            Console.WriteLine($"referencia1: {referencia1.ertek}, ertek2: {referencia2.ertek}");



            var szoveg1 = new char[] { '1', '0' };
            var szoveg2 = szoveg1;
            Console.WriteLine($"szoveg1: {szoveg1[0]}, szoveg2: {szoveg2[0]}");
            szoveg1[0] = '2';
            Console.WriteLine($"szoveg1: {szoveg1[0]}, szoveg2: {szoveg2[0]}");

            //var szoveg = "";

            //for (int i = 0; i < 10000; i++)
            //{
            //    szoveg += new string('A', 10000);
            //}

            //var sb = new StringBuilder();
            //for (int i = 0; i < 10000; i++)
            //{
            //    sb.Append(new string('A', 10000));
            //}

            var sajatertek1 = new SajatErtek
            {
                ertek = 10
            };
            var sajatertek2 = sajatertek1;
            Console.WriteLine($"sajatertek1: {sajatertek1.ertek}, sajatertek2: {sajatertek2.ertek}");

            sajatertek1.ertek = 20;
            Console.WriteLine($"sajatertek1: {sajatertek1.ertek}, sajatertek2: {sajatertek2.ertek}");




            Console.ReadLine();
        }
    }
}
