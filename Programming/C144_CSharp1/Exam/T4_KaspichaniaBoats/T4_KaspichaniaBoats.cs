using System;

class T4_KaspichaniaBoats
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        int width = n * 2 + 1;
        int sideLength = (width - 2) / 2;
        int baseHeight = (n + 1) / 2;

        Console.WriteLine("{0}*{0}", new string('.', sideLength + 1));
        for (int i = n - 1; i > 0; i--)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}",
            new string('.', i), new string('.', sideLength - i));
        }
        Console.WriteLine(new string('*', width));
        for (int i = 1; i < baseHeight; i++)
        {
            Console.WriteLine("{0}*{1}*{1}*{0}",
            new string('.', i), new string('.', sideLength - i));
        }
        n = (n & 1) == 1 ? n : ++n;
        Console.WriteLine("{0}{1}{0}",
            new string('.', baseHeight), new string('*', n));
    }
}

// Task 4 - Kaspichania Boats
