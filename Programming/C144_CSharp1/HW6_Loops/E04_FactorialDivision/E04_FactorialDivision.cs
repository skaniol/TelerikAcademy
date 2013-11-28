// 04. Write a program that calculates N!/K! for given N and K (1<K<N).

using System;
using System.Numerics;

class E04_FactorialDivision
{
    static void Main()
    {
        Console.WriteLine("(1 < K < N)");
        uint n;
        Console.Write("Enter N: ");
        while (!uint.TryParse(Console.ReadLine(), out n) || (n < 3))
        {
            Console.Write("Invalid N. Try again: ");
        }

        uint k;
        Console.Write("Enter K: ");
        while (!uint.TryParse(Console.ReadLine(), out k) || (k <= 1) || (k >= n))
        {
            Console.Write("Invalid K. Try again: ");
        }

        BigInteger quotient = 1;
        for (uint i = n; i > k; i--)
        {
            quotient *= i;
        }

        Console.WriteLine("{0}! / {1}! = {2}", n, k, quotient);
    }
}
