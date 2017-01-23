using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourNeeded = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double actualhours = ((days - (days * 0.1))*8);
            double actualHours2 = workers * (2 * days);
            double totalHours = Math.Floor(actualhours + actualHours2);

            int result =  (int)Math.Abs( totalHours - hourNeeded);

            if (totalHours >= hourNeeded)
            {
                
                Console.WriteLine("Yes!{0} hours left.", result );
            }
            else if (totalHours < hourNeeded)
            {
                Console.WriteLine("Not enough time!{0} hours needed.", result);
            }


        }
    }
}
