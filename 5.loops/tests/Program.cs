using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.tests.alphabet

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Latin alphabet:");
            for (char letter = 'a'; letter <= 'z'; letter++)
            {
                Console.Write(" " + letter);
            }
            Console.WriteLine();

        }
    }
}
