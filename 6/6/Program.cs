using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse (Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n-row; col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                
                for (var col = 1; col < row; col++)
                   Console.Write(" *");
                Console.WriteLine();
            }          
            
            for (int rows = 2; rows <= n; rows++)
            {
                for (int col = 1; col <= rows - 1; col++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int col = 1; col <= n - rows; col++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();


            }
        }
    }
}
