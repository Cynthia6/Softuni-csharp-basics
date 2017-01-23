using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.dnevna.pechalba
{
    class Program
    {
        static void Main(string[] args)
        {
            double workindays = double.Parse(Console.ReadLine());
            double monperday = double.Parse(Console.ReadLine());
            double USDLV = double.Parse(Console.ReadLine());


            double onemonsalary = workindays * monperday;
            double yearIncome = ((onemonsalary * 12) + (onemonsalary * 2.5));
            double steal = yearIncome * 0.25;
            double yearincometot1 = yearIncome - steal;
            double yearincomelv = yearincometot1 * USDLV;
            Console.WriteLine(Math.Round(yearincomelv / 365, 2));
        }
    }
}
