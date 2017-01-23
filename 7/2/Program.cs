using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = 1;
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i++)
            {

                Console.WriteLine(nums);

                nums = nums * 2;
            }
        }
    }
}
