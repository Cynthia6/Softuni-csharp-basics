using System;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string dot;
        string star;

        Console.WriteLine((dot = new string('.', N) + (star = new string('*', N) + (dot = new string('.', N)))));

        for (int i = N + 2; i <= ((3 * N) - 2); i += 4)
        {
            Console.WriteLine((dot = new string('.', ((3 * N - i) / 2) - 1)) + "*" + (dot = new string('.', i) + "*" +
                (dot = new string('.', ((3 * N - i) / 2) - 1))));
        }
        Console.WriteLine("*" + (dot = new string('.', N - 2) + "*" + (dot = new string('.', N) + "*" + (dot = new string('.', N - 2) + "*"))));
        for (int i2 = N - 4; i2 >= 1; i2 -= 2)
        {
            Console.WriteLine("*" + (dot = new string('.', i2) + "*" + (dot = new string('.', ((N - i2) - 3)) + "*" +
            (dot = new string('.', N) + "*" + (dot = new string('.', ((N - i2) - 3)) + "*" + (dot = new string('.', i2) + "*"))))));
        }
        for (int i3 = N; i3 < (((N * 3) - 4) + 1); i3 += 2)
        {
            Console.WriteLine((dot = new string('.', (((3 * N) - i3) - 2) / 2)) + "*" + (dot = new string('.', i3) + "*"
                + (dot = new string('.', (((3 * N) - i3) - 2) / 2))));
        }


        Console.WriteLine((star = new string('*', N * 3)));
    }
}