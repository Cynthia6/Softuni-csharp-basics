using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)
        {

            string type = Console.ReadLine().ToLower();
            double r = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double number = r * c;

            if(type == "premiere")
            {
                number *= 12.000;
            }
            else if (type == "normal")
            {
                number *= 7.50;
            }
            else  if (type == "discount")
            {
                number *= 5.00;
            }
            Console.WriteLine("{0:f2}", number);
        }
    }
}
