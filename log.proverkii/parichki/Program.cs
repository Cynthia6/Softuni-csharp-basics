using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parichki
{
    class Program
    {
        static void Main(string[] args)
        {

            double bitcoin = double.Parse(Console.ReadLine());
            double una = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());

            double totalBC = (bitcoin * 1168);
            double totalU = una * 0.15;
            double totalusdinbgn = totalU * 1.76;
            double totalEU = (totalBC + totalusdinbgn) / 1.95;

            double comTotal = ((comission / 100) * totalEU);

            Console.WriteLine(totalEU - comTotal);




        }
    }
}
