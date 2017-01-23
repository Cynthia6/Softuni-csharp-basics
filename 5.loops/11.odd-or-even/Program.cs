using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.odd_or_even
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double nums = 0;
            double sumE = 0;
            double sumO = 0;
            double minO = int.MaxValue;
            double maxO = int.MinValue;
            double minE = int.MaxValue;
            double maxE = int.MinValue;
            for (int i = 1; i <= n; i++)
            {
                nums = double.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    sumO += nums;
                    if (nums > maxO) maxO = nums;
                    if (nums < minO) minO = nums;

                }
                if (i % 2 == 0)
                {
                    sumE += nums;
                    if (nums > maxE) maxE = nums;
                    if (nums < minE) minE = nums;

                }


            }
            if (sumO == 0 && sumE != 0)
            {
                Console.WriteLine("OddSum={0},", sumO);
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine("EvenSum={0},", sumE);
                Console.WriteLine("EvenMin={0},", minE);
                Console.WriteLine("EvenMax={0}", maxE);

            }
            else if (sumE == 0 && sumO != 0)
            {
                Console.WriteLine("OddSum={0},", sumO);
                Console.WriteLine("OddMin={0},", minO);
                Console.WriteLine("OddMax={0},", maxO);
                Console.WriteLine("EvenSum={0},", sumE);
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");

            }
            else if (sumE == 0 && sumO == 0)
            {
                Console.WriteLine("OddSum={0},", sumO);
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine("EvenSum={0},", sumE);
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");

            }
            else if (sumE != 0 && sumO != 0)
            {
                Console.WriteLine("OddSum=" + sumO);
                Console.WriteLine("OddMin=" + minO);
                Console.WriteLine("OddMax=" + maxO);
                Console.WriteLine("EvenSum=" + sumE);
                Console.WriteLine("EvenMin=" + minE);
                Console.WriteLine("EvenMax=" + maxE);
            }
            //double n = double.Parse(Console.ReadLine());
            //double nums = 0;
            //double sumE = 0;
            //double sumO = 0;
            //double minO = int.MaxValue;
            //double maxO = int.MinValue;
            //double minE = int.MaxValue;
            //double maxE = int.MinValue;
            //for (int i = 1; i <= n; i++) 
            //{
            //    nums = double.Parse(Console.ReadLine());

            //    if (nums % 2 != 0)
            //    {
            //         sumO += nums;
            //        if (nums > maxO) maxO = nums;
            //        if (nums < minO) minO = nums;

            //    }
            //    if (nums % 2 == 0)
            //    {
            //        sumE += nums;
            //        if (nums > maxE) maxE = nums;
            //        if (nums < minE) minE = nums;

            //    }
                

            //}
            //if (sumO == 0 && sumE!=0)
            //{
            //    Console.WriteLine("OddSum={0},", sumO);
            //    Console.WriteLine("OddMin=No," );
            //    Console.WriteLine("OddMax=No,");
            //    Console.WriteLine("EvenSum={0},", sumE);
            //    Console.WriteLine("EvenMin={0},", minE);
            //    Console.WriteLine("EvenMax={0}", maxE);
                
            //}
            //else if (sumE == 0 && sumO !=0)
            //{
            //    Console.WriteLine("OddSum={0},", sumO);
            //    Console.WriteLine("OddMin={0},", minO);
            //    Console.WriteLine("OddMax={0},", maxO);
            //    Console.WriteLine("EvenSum={0},", sumE);
            //    Console.WriteLine("EvenMin=No");
            //    Console.WriteLine("EvenMax=No");

            //}
            //else if (sumE == 0 && sumO==0)
            //{
            //    Console.WriteLine("OddSum={0},", sumO);
            //    Console.WriteLine("OddMin=No,");
            //    Console.WriteLine("OddMax=No,");
            //    Console.WriteLine("EvenSum={0},", sumE);
            //    Console.WriteLine("EvenMin=No");
            //    Console.WriteLine("EvenMax=No");

            //}
            //else if (sumE != 0 && sumO != 0)
            //{
            //    Console.WriteLine("OddSum=" + sumO);
            //    Console.WriteLine("OddMin=" + minO);
            //    Console.WriteLine("OddMax" + maxO);
            //    Console.WriteLine("EvenSum=" + sumE);
            //    Console.WriteLine("EvenMin=" + minE);
            //    Console.WriteLine("EvenMax=" + maxE);
            //}
        }
    }
}
