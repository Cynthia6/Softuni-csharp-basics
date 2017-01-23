using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.even.odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nums = 0;
            var odd = 0;
            var even = 0;
            for (int i = 0; i <= n-1; i++)
            {
               nums=  int.Parse(Console.ReadLine());
                if (i %2 ==0)
                {
                    even += nums;
                }
                if (i % 2 != 0)
                {
                    odd += nums;
                }

            }
            if (odd == even)
            {
                Console.WriteLine("Yes, sum = " + even);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(even - odd));
            }

        }
    }
}
