using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {

            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double pipe1 = H * P1;
            double pipe2 = H * P2;
            
            double total= pipe1 + pipe2;

            int totalpercent = (int)((total / V) * 100);
         //   int totalINT = (int)(totalpercent);
           double diference = total - V;
            int pipe11 = (int)(pipe1 / total * 100);
            
            int pipe22 = (int)(pipe2 / total * 100 );
           
            if (total > V)
            {
               
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", H, diference);
            }
            else
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", totalpercent, pipe11, pipe22);
            }
            

        }
    }
}
