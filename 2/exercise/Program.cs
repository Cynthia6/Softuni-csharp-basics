using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            double bonus = 0;

            if (number % 2 ==0)
            {
                bonus +=1;
            }
            if (number % 10 == 5)
            {
                bonus +=2;
            }
            if (number >= 0 && number <=100)
            {
                bonus +=5;
            }
            if (number > 100 && number <= 1000)
            {
                bonus += number * 0.2;
            }
            if (number > 1000)
            {
                bonus += number * 0.1;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(number + bonus);

        }
    }
}
