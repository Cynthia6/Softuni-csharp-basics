using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.bonus_tochki
{
    class Program
    {
        static void Main(string[] args)
        {


            double num = double.Parse(Console.ReadLine());
            double bonus = 0.0;



            if (num <= 100)
            {

                if (num % 2 == 0)
                {
                    bonus = +1;
                    Console.WriteLine(bonus + 5);
                    Console.WriteLine(bonus + num + 5);
                }
                else if (num % 10 == 5)
                {
                    bonus = +2;
                    Console.WriteLine(bonus + 5);
                    Console.WriteLine(bonus + num + 5);
                }
                else
                {
                    
                    Console.WriteLine(bonus + 5);
                    Console.WriteLine(bonus + num +5);
                }
            }
            else if ((num > 100) && (num < 1000))
            {

                if (num % 2 == 0)
                {
                    bonus = num * 0.2;
                    Console.WriteLine(bonus + 1);
                    Console.WriteLine(bonus + num + 1);
                }
                else if (num % 10 == 5)
                {
                    bonus = num * 0.2;
                    Console.WriteLine(bonus + 2);
                    Console.WriteLine(bonus + num + 2);
                }
                else
                {
                    bonus = num * 0.2;
                    Console.WriteLine(bonus);
                    Console.WriteLine(bonus + num);
                }
            }
            else if (num > 1000)
            {

                if (num % 2 == 0)
                {
                    bonus = num * 0.1;
                    Console.WriteLine(bonus + 1);
                    Console.WriteLine(bonus + num + 1);
                }
                else if (num % 10 == 5)
                {
                    bonus = num * 0.1;
                    Console.WriteLine(bonus + 2);
                    Console.WriteLine(bonus + num +2);
                }
                else
                {
                    bonus = num * 0.1;
                    Console.WriteLine(bonus);
                    Console.WriteLine(bonus + num);
                }
            
                
            }
        }

    }
}