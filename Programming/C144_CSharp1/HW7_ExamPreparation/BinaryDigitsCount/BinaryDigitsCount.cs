// You are given a sequence of N positive integers and one binary digit B
// (0 or 1). Your task is to write a program that finds the number of binary
// digits (B) in each of the N numbers in binary numeral system.

// Example: 20 in the binary numeral system looks like this: 10100.
// The number of binary digits 0 of the number 20 in the bin num system is 3

using System;

class BinaryDigitsCount
{
    static void Main()
    {
        byte b = byte.Parse(Console.ReadLine());
        ushort n = ushort.Parse(Console.ReadLine());
        while (n-- > 0)
        {
            uint number = uint.Parse(Console.ReadLine());
            byte totalCount = 0;
            while (number != 0)
            {
                if ((number & 1) == b)
                {
                    totalCount++;
                }
                number >>= 1;
            }
            Console.WriteLine(totalCount);
        }
    }
}
