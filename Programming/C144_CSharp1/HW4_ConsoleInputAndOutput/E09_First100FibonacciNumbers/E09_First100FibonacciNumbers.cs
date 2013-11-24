// 09. Write a program to print the first 100 members of the sequence of 
//     Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

using System;

class E09_First100FibonacciNumbers
{
    static void Main()
    {
        decimal previous = 0;
        decimal current = 1;

        Console.Write("0, 1");
        for (int i = 1; i < 100; i++)
        {
            current += previous;
            Console.Write(", " + current);
            previous = current - previous;
        }
        Console.WriteLine();
    }
}
