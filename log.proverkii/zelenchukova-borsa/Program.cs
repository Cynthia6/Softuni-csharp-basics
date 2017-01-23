using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zelenchukova_borsa
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal vegePrice = decimal.Parse(Console.ReadLine());
            decimal frPrice = decimal.Parse(Console.ReadLine());
            decimal vegeTotal = decimal.Parse(Console.ReadLine());
            decimal frTotal = decimal.Parse(Console.ReadLine());

            decimal vegeMoney = vegePrice * vegeTotal;
            decimal frMoney = frPrice * frTotal;
            decimal totalRes = ((vegeMoney + frMoney)/1.94m);

            Console.WriteLine(totalRes);



        }
    }
}
