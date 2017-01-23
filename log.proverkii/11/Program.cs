using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = a * 1.79549M;

            decimal c = Math.Round(b, 2);
            Console.WriteLine(c + " BGN");
        }
    }
}
