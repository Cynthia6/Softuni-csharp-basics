using System;
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            while ((n < 3) || (n >101) || (n%2==0 ))
            {
                Console.WriteLine("try again");
                n = int.Parse(Console.ReadLine());
            }
            string asterisk;
            string dash;
            for (int line = 1; line <= n; line+=2)
            {
                Console.WriteLine((dash = new string ('-',((n-line)/2)) + (asterisk = new string ('*', line)) +
                    (dash = new string ('-',((n-line)/2)))));
            }

            for (int line2 =0; line2 <n; line2++)
            {
                Console.WriteLine("|" + (asterisk = new string('*', n-2) +"|"));
            }

        }
    }
