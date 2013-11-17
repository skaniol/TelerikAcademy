// 07. Write an expression that checks if given positive integer number
//     n (n ≤ 100) is prime. E.g. 37 is prime.

using System;

class E07_CheckForPrime
{
    static void Main()
    {
        byte n;
        bool isPrime = true;

        Console.Write("Enter an integer (n <= 100): ");
        while (!Byte.TryParse(Console.ReadLine(), out n) || n > 100)
        {
            Console.Write("Invalid Integer. Try again: ");
        }

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            isPrime = true;
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        if (n < 2) isPrime = false;

        Console.WriteLine("{0} is {1}", n, isPrime ? "prime" : "NOT prime");
    }
}
