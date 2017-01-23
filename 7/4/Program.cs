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
            int n = int.Parse (Console.ReadLine());
            int num = 1;
            for (num = 1; num <= n ; num++)
            {
                Console.WriteLine(num);
                num = num * 2;
            }
        }
    }
}

