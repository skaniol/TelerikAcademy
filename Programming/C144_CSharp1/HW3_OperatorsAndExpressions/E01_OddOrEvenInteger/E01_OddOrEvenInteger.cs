// 01. Write an expression that checks if given integer is odd or even

using System;

class E01_OddOrEvenInteger
{
    static void Main()
    {
        int n;
        Console.Write("Enter an integer: ");
        while (!Int32.TryParse(Console.ReadLine(), out n))
        {
            Console.Write("Invalid Integer. Try again: ");
        }

        // using modulo %
        Console.WriteLine("{0} is {1}", n, (n % 2) != 0 ? "odd" : "even");
        // using & to check the first bit (every odd number's 1st bit is 1)
        Console.WriteLine("{0} is {1}", n, (n & 1) != 0 ? "odd" : "even");
    }
}
