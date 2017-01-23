using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {

            int field = int.Parse(Console.ReadLine());
            double grapes1km = double.Parse(Console.ReadLine());
            int litersneeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double grapes = grapes1km * field;
            double actualWine1 = ((grapes * 0.4 ) / 2.5);
            double difference1 = Math.Abs(actualWine1 - litersneeded);
            if (actualWine1 >= litersneeded)
            {
                
                double LpWorker = (difference1 / workers);
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.\n{1} liters left -> {2} liters per person.", Math.Floor( actualWine1), Math.Ceiling( difference1), Math.Ceiling( LpWorker));
            }
             if (actualWine1 < litersneeded)
            {
                
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", (int)( difference1) );
            }


        }
    }
}
