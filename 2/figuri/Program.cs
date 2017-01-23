using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figuri
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                var numOne = double.Parse(Console.ReadLine());
                var square = Math.Round(numOne * numOne, 3);
                Console.WriteLine(square);
            }
            else if (figure == "rectangle")
            {
                var numOne = double.Parse(Console.ReadLine());
                var numTwo = double.Parse(Console.ReadLine());
                var rectangle = Math.Round(numOne * numTwo, 3);
                Console.WriteLine(rectangle);
            }
            else if (figure == "circle")
            {
                var numOne = double.Parse(Console.ReadLine());

                var circle = Math.Round(Math.PI * numOne * numOne, 3);
                Console.WriteLine(circle);
            }
            else if (figure == "triangle")
            {
                var numOne = double.Parse(Console.ReadLine());
                var numTwo = double.Parse(Console.ReadLine());
                var triangle = Math.Round(numOne * numTwo / 2, 3);
                Console.WriteLine(triangle);
            }

        }
    }
}