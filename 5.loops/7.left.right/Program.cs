using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.left.right
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var leftside= 0 ;
            var rightside = 0;
            for (int i = 1; i <= n; i++)
            {
                leftside = leftside + int.Parse(Console.ReadLine());
                
            }
            for (int i = 1; i <= n; i++)
            {
                rightside = rightside + int.Parse(Console.ReadLine());

            }
            if (leftside==rightside)
            {
                Console.WriteLine("Yes, sum = " + leftside);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(leftside-rightside));
            }
        }
    }
}
