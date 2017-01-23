using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uchebna_zala
{
    class Program
    {
        static void Main(string[] args)
        {

            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            int hallLength = (int)((length * 100) / 120);
            int hallWidth = (int)(((width * 100) - 100) / 70);

             Console.WriteLine (( hallLength * hallWidth) - 3);

        }
    }
}
