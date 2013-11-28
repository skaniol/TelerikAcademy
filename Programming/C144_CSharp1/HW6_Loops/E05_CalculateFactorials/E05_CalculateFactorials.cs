// 05. Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics;

class E05_CalculateFactorials
{
    static void Main()
    {
        Console.WriteLine("(1 < N < K)");
        uint k;
        Console.Write("Enter K: ");
        while (!uint.TryParse(Console.ReadLine(), out k) || (k < 3))
        {
            Console.Write("Invalid K. Try again: ");
        }

        uint n;
        Console.Write("Enter N: ");
        while (!uint.TryParse(Console.ReadLine(), out n) || (n <= 1) || (n >= k))
        {
            Console.Write("Invalid N. Try again: ");
        }

        BigInteger result = 1;
        for (uint i = k; i > k - n; i--)
        {
            result *= i;
        }

        BigInteger factN = 1;
        for (uint i = n; i > 1; i--)
        {
            factN *= i;
        }

       result *= factN;
        Console.WriteLine("{1}! * {0}! / ({0} - {1})! = {2}", k, n, result);
    }
}
