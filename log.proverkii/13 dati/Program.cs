using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace _13_dati
{
    class Program
    {
        static void Main(string[] args)
        {

            var lala = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
           var  lala1 = lala.AddDays(999);
            Console.WriteLine(lala1.ToString("dd-MM-yyyy"));
        }
    }
}
