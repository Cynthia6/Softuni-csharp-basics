using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.operacii.mjdu._4isla
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string oper = Console.ReadLine();

            if ( n2 == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero", n1);
            }
            if (oper == "+")
            {
                double n3 = n1+n2;

                if (n3 % 2 == 0) Console.WriteLine("{0} + {1} = {2} - even",(int)n1, (int)n2, (int)n3);
                if (n3 % 2 != 0) Console.WriteLine("{0} + {1} = {2} - odd", (int)n1, (int)n2, (int)n3);
            }
            else if (oper == "-")
            {
                double n3 = n1 - n2;

                if (n3 % 2 == 0) Console.WriteLine("{0} - {1} = {2} - even", (int)n1, (int)n2, (int)n3);
                if (n3 % 2 != 0) Console.WriteLine("{0} - {1} = {2} - odd", (int)n1, (int)n2, (int)n3);
            }
            else if (oper == "*")
            {
                double n3 = n1 * n2;

                if (n3 % 2 == 0) Console.WriteLine("{0} * {1} = {2} - even",(int)n1, (int)n2, (int)n3);
                if (n3 % 2 != 0) Console.WriteLine("{0} * {1} = {2} - odd", (int)n1, (int)n2, (int)n3);
            }
            else if (oper == "%" && n2 != 0)
            {
                double n3 = n1 % n2;

                Console.WriteLine("{0} % {1} = {2}", (int)n1, (int)n2, (int)n3);
                
            }
            else if (oper == "/" && n2!=0)
            {
                double n3 = n1 / n2;

                Console.WriteLine("{0} / {1} = {2:f2}", (int)n1, (int)n2, n3);

            }


        }
    }
}
