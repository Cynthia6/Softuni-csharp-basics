using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int fstsec = int.Parse(Console.ReadLine());
            int secsec = int.Parse(Console.ReadLine());
            int thirdsec = int.Parse(Console.ReadLine());

            int total = fstsec + secsec + thirdsec;
            var mins = 0;

            if (total > 59)
            {
                mins++;
                total = total - 60;
            }
            if (total > 59)
            {
                mins++;
                total = total - 60;
            }
            if (total > 59)
            {
                mins++;
                total = total - 60;
            }

            if (total < 10)
            {
                Console.WriteLine(mins + ":0" + total);
            }
            else
            {
                Console.WriteLine(mins + ":" + total);
            }

        }
    }
}
