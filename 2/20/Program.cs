using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {

            int FreeDays = int.Parse(Console.ReadLine());

            int workDays = 365 - FreeDays;
            int TimePlay = ((workDays * 63) + (FreeDays * 127));

            int norma = 30000 - TimePlay;

            if (TimePlay <= 30000)
            {
                int result = 30000 - TimePlay;
                int resultH = result / 60;
                decimal resultM = result % 60;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", resultH, resultM);


            }
            else if (TimePlay > 30000)
            {
                int result = TimePlay - 30000;
                int resultH = result / 60;
                int resultM = result % 60;
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", resultH, resultM);
                }

        }
    }
}
