using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.pyteshestvie
{
    class Program
    {
        static void Main(string[] args)
        {
            double leva = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            if (100 >= leva)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season == "summer") Console.WriteLine("Camp - {0:f2}", leva * 0.3);
                if (season == "winter") Console.WriteLine("Hotel - {0:f2}", leva * 0.7);

            }
            if (100 < leva && leva <= 1000 )
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer") Console.WriteLine("Camp - {0:f2}", leva * 0.4);
                if (season == "winter") Console.WriteLine("Hotel - {0:f2}", leva * 0.8);

            }
            if (1000 < leva)
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}", leva * 0.9);

            }


        }
    }
}
