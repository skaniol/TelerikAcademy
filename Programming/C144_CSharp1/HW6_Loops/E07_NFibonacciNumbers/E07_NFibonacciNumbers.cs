// 07. Write a program that reads a number N and calculates the sum
//     of the first N members of the sequence of Fibonacci:
//     0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
//     Each member of the Fibonacci sequence (except the first two)
//     is a sum of the previous two members.


using System;
using System.Numerics;

class E07_NFibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter N: ");
        uint n = uint.Parse(Console.ReadLine());

        BigInteger previous = 0;
        BigInteger current = 1;
        BigInteger sum = 1;

        for (int i = 2; i < n; i++)
        {
            current += previous;
            sum += current;
            previous = current - previous;
        }

        if (n < 2)
        {
            sum = 0;
        }
        Console.WriteLine("Sum = " + sum);
    }
}
