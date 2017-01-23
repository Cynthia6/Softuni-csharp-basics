using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remont_na_plochki
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double O = double.Parse(Console.ReadLine());

            double totalArea = ((N * N) - (M * O));
            double totSq = (W * L);
            double needSq = (totalArea / totSq);
            double needTime = (needSq * 0.2);

            Console.WriteLine(needSq);
            Console.WriteLine(needTime);


        }
    }
}
