// 10. Write a boolean expression that returns if the bit at position p
//     (counting from 0) in a given integer number v has value of 1.
//     Example: v=5; p=1 -> false.

using System;

class E10_IsGivenBitSet
{
    static void Main()
    {
        int v;
        Console.Write("Enter an integer: ");
        while (!Int32.TryParse(Console.ReadLine(), out v))
        {
            Console.Write("Invalid Integer. Try again: ");
        }

        int p;
        Console.Write("Enter bit position: ");
        while (!Int32.TryParse(Console.ReadLine(), out p))
        {
            Console.Write("Invalid Integer. Try again: ");
        }

        Console.WriteLine("v={0}; p={1} -> {2} ({3})", v, p,
            ((v >> p) & 1) == 1,
            Convert.ToString(v, 2).PadLeft(32, '0'));
    }
}
