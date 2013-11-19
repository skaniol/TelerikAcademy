// 13. Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26
//     of given 32-bit unsigned integer.

using System;

class E13_ExchangeBits
{
    static void Main()
    {
        uint n;
        Console.Write("Enter 32-bit unsigned integer: ");
        while (!UInt32.TryParse(Console.ReadLine(), out n))
        {
            Console.Write("Invalid Integer. Try again: ");
        }

        // Eye-candy stuff
        string nToString = Convert.ToString(n, 2).PadLeft(32, '0');
        Console.WriteLine("n    = {0} bin == {1,10} dec\nswitch {2,8}{3,21}",
            nToString, n, nToString.Substring(5,3), nToString.Substring(26,3));

        // Exchange the bits (56 == 111000b; & 4177526727 resets all positions)
        n = ((n >> 21) & 56) | ((n & 56) << 21) | (n & 4177526727);
        
        // Show the result
        nToString = Convert.ToString(n, 2).PadLeft(32, '0');
        Console.WriteLine("nNew = {0} bin == {1,10} dec", nToString, n);
    }
}
