using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            var first = Console.ReadLine();
            var second = Console.ReadLine();

            if (first == "usd")
            {
                if (second == "bgn")
                {
                    Console.WriteLine("{0}", Math.Round(num * 1.79549, 2));
                }
                else if (second == "eur")
                {
                    Console.WriteLine("{0}", Math.Round(num * 0.91801, 2));
                }
                else if (second == "gbp")
                {
                    Console.WriteLine("{0}", Math.Round(num * 0.70854, 2));
                }

            }

            if (first == "bgn")
            {
                if (second == "usd")
                {
                    Console.WriteLine("{0} {1} ", Math.Round(num / 1.79549, 2), second);
                }
                else if (second == "eur")
                {
                    Console.WriteLine("{0} {1}", Math.Round(num / 1.95583, 2), second);
                }
                else if (second == "gbp")
                {
                    Console.WriteLine("{0}", Math.Round(num / 2.53405, 2) + second);
                }
            }

            if (first == "eur")
            {
                if (second == "bgn")
                {
                    Console.WriteLine("{0}", Math.Round(num * 2.53405, 2) + second);
                }
                else if (second == "usd")
                {
                    Console.WriteLine("{0}", Math.Round(num * 1.08930, 2));
                }
                else if (second == "gbp")
                {
                    Console.WriteLine("{0}", Math.Round(num * 0.77181, 2));
                }
            }
            if (first == "gbp")
                if (second == "bgn")
                {
                    Console.WriteLine("{0}", Math.Round(num * 0.39462, 2));
                }
                else if (second == "usd")
                {
                    Console.WriteLine("{0}", Math.Round(num * 0.70854, 2));
                }
                else if (second == "eur")
                {
                    Console.WriteLine("{0}", Math.Round(num * 0.77181, 2));
                }
        }
    }
}