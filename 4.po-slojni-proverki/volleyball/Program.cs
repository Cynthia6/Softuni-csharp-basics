using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            
            double weekendsinsf = ((48 - h)*(3.0/4));
                double holidays = p * (2.0/3);
            double totalgames = weekendsinsf + h + holidays;

            if (year =="leap")
            {
                double totalgames1=((totalgames*0.15) + totalgames);
                Console.WriteLine( Math.Floor( totalgames1));
            }
            else if (year == "normal")
            {
                
                Console.WriteLine(Math.Floor(totalgames));
            }

        }
    }
}
