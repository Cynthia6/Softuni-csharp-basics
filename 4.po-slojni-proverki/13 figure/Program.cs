using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            

            if ((((x > 0) && (x < h*3)) && ((y < h) && (y > 0))) || (((x > h) && (x < h*2)) && ((y < h*4) && (y > h))) || (((x > h) && (x < h*2)) && ((y == h))))
            {
                Console.WriteLine("inside");

            }
            else if ((((x < 0) || (x > h * 3)) || ((y > h) || (y < 0))) && (((x < h) || (x > h * 2)) || ((y > h * 4) || (y < h))) || (((x < h) && (x > h * 2)) && ((y != h))))
            {
                Console.WriteLine("outside");

            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}
