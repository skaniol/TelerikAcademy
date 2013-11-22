// 08. Write a program that reads an integer number n from the console and
//     prints all the numbers in the interval [1..n], each on a single line.

using System;

class E08_PrintNumbersFromOneToN
{
    static void Main()
    {
        int n;
        Console.Write("n = ");
        while (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.Write("Invalid number! Try again!\nn = ");
        }
        Console.WriteLine("Print 1.." + n + Environment.NewLine);

        if (n < 1)
        {
            for (int i = 1; i >= n; i--)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
