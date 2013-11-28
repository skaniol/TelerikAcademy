// 03. Write a program that reads from the console a sequence of N
//     integer numbers and returns the minimal and maximal of them.

using System;

class E03_MinAndMax
{
    static void Main()
    {
        int n;
        Console.Write("Enter N: ");
        while (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.Write("Invalid integer. Try again: ");
        }

        int min = int.MaxValue;
        int max = int.MinValue;
        int number;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Invalid number. Try again: ");
            }
            if (number < min)
            {
                min = number;
            }
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Min = " + min);
        Console.WriteLine("Max = " + max);
    }
}
