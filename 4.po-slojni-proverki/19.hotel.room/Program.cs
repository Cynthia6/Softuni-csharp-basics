using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.hotel.room
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int days = int.Parse(Console.ReadLine());
            double price = 0.00;
            double appartment = 0.00;
            if (month == "may" || month =="october")
            {
                if (days > 14) appartment = ((65.0 - (65.0 * 0.10)) * days);
               else appartment = 65.0 * days;
                if (days > 7 && days < 15) price = ((50.0 - (50.0 * 0.05)) * days);
                else if (days > 14) price = ((50.0 - (50.0 * 0.30)) * days);
                else price = 50.0 * days;
                
            }
            if (month == "june" || month == "september")
            {
                if (days > 14) appartment = ((68.70 - (68.70 * 0.10)) * days);
                else appartment = 68.70 * days;
                if (days > 14) price = ((75.20 - (75.20 * 0.20)) * days);
                else price = 75.20 * days;
            }
            if (month == "july" || month == "august")
            {
                price = (76.0 * days);
                if (days > 14) appartment = ((77.0 - (77.0 * 0.10)) * days);
                else appartment = 77.0 * days;
                
                
            }

                        Console.WriteLine("Apartment: {0:f2} lv.", appartment);
                        Console.WriteLine("Studio: {0:f2} lv.", price);
        }
    }
}
