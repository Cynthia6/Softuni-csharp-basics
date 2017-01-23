using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {   
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Console.Write("+");
            //for (int i = 0; i < n - 2; i++)
            //    Console.Write(" -");
            //Console.WriteLine(" +");

            //for (int i = 1; i <= n - 2; i++)
            //{
            //    Console.Write("| ");
            //    for (int row = 0; row < n - 2; row++)
            //        Console.Write("- ");
            //    Console.WriteLine("|");
            //}          


            //Console.Write("+");
            //for (int i2 = 0; i2 < n - 2; i2++)
            //    Console.Write(" -");
            //Console.WriteLine(" +");

            int cols = n;
            string plus = "+";
            string pipe = "|";
            string  dashes = new string('-', n - 2);

            Console.WriteLine("{0}{1}{0}", plus, dashes);

            for (int i = 0; i < n-2; i++)
            {
                Console.WriteLine("{0}{1}{0}", pipe, dashes);
            }

            Console.WriteLine("{0}{1}{0}", plus, dashes);
        }
    }
}
