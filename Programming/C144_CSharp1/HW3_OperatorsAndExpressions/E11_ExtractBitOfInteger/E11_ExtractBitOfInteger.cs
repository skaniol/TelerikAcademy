// 11. Write an expression that extracts from a given
//     integer i the value of a given bit number b.
//     Example: i=5; b=2 -> value=1.

using System;

class E11_ExtractBitOfInteger
{
    static void Main()
    {
        int i;
        Console.Write("Enter an integer: ");
        while (!Int32.TryParse(Console.ReadLine(), out i))
        {
            Console.Write("Invalid Integer. Try again: ");
        }

        byte b;
        Console.Write("Enter bit position: ");
        while (!Byte.TryParse(Console.ReadLine(), out b) | b > 31)
        {
            Console.Write("Invalid Position. Try again: ");
        }

        int value = (i >> b) & 1;
        Console.WriteLine("i = {0}; b = {1} -> value = {2}", i, b, value);
    }
}
