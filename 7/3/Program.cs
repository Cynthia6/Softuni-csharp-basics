using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {

             int num = 1;
            int n = int.Parse(Console.ReadLine());
           
            
                for (var i = 0; i <= n; i += 2)
                {
                    Console.WriteLine(num);
                    num = num * 4;
                }

                
                }
        }
    }

