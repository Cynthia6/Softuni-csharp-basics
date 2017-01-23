using System;

class sunnies
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        while (n % 2 == 0)
        {
            Console.WriteLine("try again");
            n = int.Parse(Console.ReadLine());
        }
        string lense = "/";
        string frame = "*";
        string bridge = new string('|', n);
        string bridgespace = new string(' ', n);

        Console.WriteLine((frame = new string('*', n * 2)) + bridgespace + (frame = new string('*', n * 2)));



        for (int line = 1; line <= n - 2; line++)
            if (line != (n / 2))
            {
                Console.WriteLine("*" + (lense = new string('/', (n * 2) - 2)) + "*" + bridgespace + "*" +
                    (lense = new string('/', (n * 2) - 2)) + "*");
            }
            else if (line == (n / 2))
            {
                Console.WriteLine("*" + (lense = new string('/', (n * 2) - 2)) + "*" + bridge + "*" +
                    (lense = new string('/', (n * 2) - 2)) + "*");
            }

        Console.WriteLine((frame = new string('*', n * 2)) + bridgespace + (frame = new string('*', n * 2)));

    }
}
