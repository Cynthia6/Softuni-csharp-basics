using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.mejduvaluten.konvertor
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            var b = Console.ReadLine();
            var c = Console.ReadLine();

            var usd = 1.79549;
            var eur = 1.95583;
            var gbp = 2.53405;

            if (b == "BGN")
            {
                if (c == "USD")
                {
                    Console.WriteLine("{0} {1}", Math.Round(a * (1 / usd), 2), c);
                }
                else if (c == "EUR")
                {
                    Console.WriteLine("{0} {1}", Math.Round(a * (1 / eur), 2), c);
                }
                else if (c == "GBP")
                {
                    Console.WriteLine("{0} {1}", Math.Round(a * (1 / gbp), 2), c);
                }
            }
            else if (b == "USD")
            {
                if (c == "BGN")
                {
                    Console.WriteLine("{0} {1}", Math.Round(a * usd, 2), c);
                }
                if (c == "EUR")
                {
                    Console.WriteLine("{0} {1}", Math.Round(a * (usd / eur), 2), c);
                }
                if (c == "GBP")
                {
                    Console.WriteLine("{0} {1}", Math.Round(a * (usd / gbp), 2), c);
                }
            }
            else if (b == "EUR")
            {
                if (c == "BGN")
                {
                    Console.WriteLine("{0} {1}", Math.Round(a * eur, 2), c);
                }
                else if (c == "USD")
                {
                    Console.WriteLine("{0} {1}", Math.Round(a * (eur / usd), 2), c);
                }
                else if (c == "GBP")
                {
                    Console.WriteLine("{0} {1}", Math.Round(a * (eur / gbp), 2), c);
                }
            }
            else if (b == "GBP")
            {
                if (c == "BGN")
                {
                    Console.WriteLine("{0} {1}", Math.Round(a * gbp, 2), c);
                }
                else if (c == "USD")
                {
                    Console.WriteLine("{0} {1}", Math.Round(a * (gbp / usd), 2), c);
                }
                else if (c == "EUR")
                {
                    Console.WriteLine("{0} {1}", Math.Round(a * (gbp / eur), 2), c);
                }
            }

        }
    }
}
