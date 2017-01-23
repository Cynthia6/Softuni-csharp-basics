using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.lice.na.pravoygylnik.v.ravnina
{
    class Program
    {
        static void Main(string[] args)
        {

            double x1 = double.Parse(Console.ReadLine()); // x side
            double y1 = double.Parse(Console.ReadLine()); // y side
            double x2 = double.Parse(Console.ReadLine()); // x side
            double y2 = double.Parse(Console.ReadLine()); // y side

            double a = Math.Abs( x1 - x2);
            double b = Math.Abs(y1 - y2);

            Console.WriteLine(a * b);
            Console.WriteLine((a + b)*2);

        }
    }
}
