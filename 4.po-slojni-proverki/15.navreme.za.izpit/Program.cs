using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.navreme.za.izpit
{
    class Program
    {
        static void Main(string[] args)
        {
            int examH = int.Parse(Console.ReadLine());
            int examM = int.Parse(Console.ReadLine());
            int arriveH = int.Parse(Console.ReadLine());
            int arriveM = int.Parse(Console.ReadLine());
            int minutesExam = examM +(examH * 60);
            int minutesArrive = arriveM + (arriveH*60);
            int minutes = Math.Abs(minutesArrive - minutesExam);
            int hours = minutes / 60;
            int minmodule = minutes % 60;
           
            if (minutes == 0)
            {
                Console.WriteLine("On time");
            }
            if ( minutesExam < minutesArrive)
            {
                Console.WriteLine("Late");
                if (minutes <= 59)
                {
                    Console.WriteLine("{0} minutes after the start", minutes);
                }
               
                else if (minutes > 59)
                {
                    if (minmodule <=9) Console.WriteLine("{0}:0{1} hours after the start", hours, minmodule);


                    else if (minmodule > 9)
                    {
                        Console.WriteLine("{0}:{1} hours after the start", hours, minmodule);
                    }
                }
            }
            if (minutesExam > minutesArrive)
            {
                if (minutes <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine("{0} minutes before the start", minutes);
                }

                else if (minutes <= 59 && minutes > 30)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0} minutes before the start", minutes);
                }

                else if (minutes > 59)
                {
                    Console.WriteLine("Early");
                    if (minmodule <= 9) Console.WriteLine("{0}:0{1} hours before the start", hours, minmodule);
                    else if (minmodule > 9)
                    {
                        Console.WriteLine("{0}:{1} hours before the start", hours, minmodule);
                    }
                }
            }
        

        }
    }
}
