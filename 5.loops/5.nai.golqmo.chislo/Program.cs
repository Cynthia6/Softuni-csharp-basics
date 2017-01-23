using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.nai.golqmo.chislo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var max = int.MinValue ;
            for (int i = 0; i <= n - 1; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                if (nums > max) max = nums;
               

            }
            Console.WriteLine(max);

        }
    }
}
