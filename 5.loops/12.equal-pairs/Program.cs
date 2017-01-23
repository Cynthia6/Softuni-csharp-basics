using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.equal_pairs
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int nums = 0;
            int nums2 = 0;
            var presum = 0;
            var max = 0;
            var sum = 0;
            var total = 0;
            for (int i = 0; i <= n - 1; i++)
            {
                presum = sum;
                nums = int.Parse(Console.ReadLine());
                nums2 = int.Parse(Console.ReadLine());
                sum = nums + nums2; 
                
                if ( i != 0)
                {
                    total = Math.Abs(sum - presum);
                    if (total > max) max = total;

                }

            }
            
                if (max == 0)
                {
                    Console.WriteLine("Yes, value = " + sum);
                }
                else
                {
                    Console.WriteLine("No, maxdiff = " + max);
                }
            }
        }
    }