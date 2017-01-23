using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.element.equal.to.rest
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int max=int.MinValue;
            int sum=0;
            int nums=0;
            for (int i = 0; i < n; i++)
            {

                nums = int.Parse(Console.ReadLine());
                sum +=nums;
            
                if (nums > max)  max = nums;
            
            }
               if (sum - max == max) 
               {
                    Console.WriteLine("Yes");
                    Console.WriteLine("Sum = " + max);
                }
                else
                {
                    Console.WriteLine("No");
                    Console.WriteLine("Diff = " + Math.Abs(max -(sum - max)));
                }
                }
        
   
            
    }
}

