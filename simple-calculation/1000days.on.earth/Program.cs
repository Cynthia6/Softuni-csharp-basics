using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1000days.on.earth
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            date = date.AddDays(999);
            Console.WriteLine(date.ToString("dd-MM-yyyy"));

        }
    }
}
