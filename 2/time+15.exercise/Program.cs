using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time_15.exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int Hresult = 0;
            int Mresult = 0;

            if (minutes >= 45 && minutes <=54 )
            {
                Mresult = minutes + 15;
                Mresult = Mresult - 60;
                if (hours == 23) hours = 0;
                else if (hours < 23) hours += 1;

                Console.WriteLine(hours + ":0" + Mresult);
                
            }
            if (minutes > 54)
            {
                Mresult = minutes + 15;
                Mresult = Mresult - 60;
                if (hours == 23) hours = 0;
                else if (hours < 23) hours += 1;
                Console.WriteLine(hours + ":" + Mresult);

            }
            if (minutes < 45)
            {
                Mresult = minutes + 15;
               // if (hours < 23) hours += 1;
                Console.WriteLine(hours + ":" + Mresult);
            }


        }
    }
}
