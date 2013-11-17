// 05. Write a boolean expression for finding if the bit 3
//     (counting from 0) of a given integer is 1 or 0.

using System;

class E05_FindFourthBitOfInteger
{
    static void Main()
    {
        int n;
        Console.Write("Enter an integer: ");
        while (!Int32.TryParse(Console.ReadLine(), out n))
        {
            Console.Write("Invalid Integer. Try again: ");
        }

        Console.WriteLine("{0} -> {1} -> Fourth bit is {2}",
            Convert.ToString(n, 2).PadLeft(32, '0'),
            (n >> 3) & 1,
            (n & 8) != 0 ? "set" : "unset");
    }
}
