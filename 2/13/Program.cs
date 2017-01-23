using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {

            double n = double.Parse(Console.ReadLine());
            string daytime = Console.ReadLine();

            if (n < 20 )
            {
               
                if (daytime == "day")
                {
                    n = (n * 0.79) + 0.70;
                }
                else if (daytime == "night")
                {
                    n = (n * 0.90) +0.70;
                }
                Console.WriteLine(n);
            }
             if ( n >= 20 && n < 100)
            {
                n = n * 0.09;
                Console.WriteLine(n);
            }
             if (n >= 100)
            {
                  n = n * 0.06;
                Console.WriteLine(n);
            }
            }
        }
    }
