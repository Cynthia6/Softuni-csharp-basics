using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.bilet.za.ma4
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string type = Console.ReadLine().ToLower();               
            int people = int.Parse(Console.ReadLine());
            double ticket = 0.00;

            if (people > 0 && people <= 4)
            {
                ticket = budget - (budget * 0.75);

            }
            if (people >= 5 && people <= 9)
            {
                ticket = budget - (budget * 0.60);

            }
            if (people >= 10 && people <= 24)
            {
                ticket = budget - (budget * 0.50);

            }
            if (people >= 25 && people <= 49)
            {
                ticket = budget - (budget * 0.40);

            }
            if (people > 49)
            {
                ticket = budget - (budget * 0.25);

            }

            if (type == "normal")
            {
                if (249.99 * people < ticket) Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(ticket - 249.99*people));
                if (249.99 * people > ticket) Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(ticket - 249.99*people));
            }
            if (type == "vip")
            {
                if (499.99 * people < ticket) Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(ticket - 499.99*people));
                if (499.99 * people > ticket) Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(ticket - 499.99*people));
            }
        }
    }
}
