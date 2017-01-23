using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write("$");
                for (int i2 = 1; i2 < i; i2++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();


            }
        }
    }
}
