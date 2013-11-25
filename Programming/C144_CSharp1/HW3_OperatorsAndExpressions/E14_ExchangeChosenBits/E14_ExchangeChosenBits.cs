// 14. * Write a program that exchanges bits {p, p+1, …, p+k-1)
//       with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.

using System;

class E14_ExchangeChosenBits
{
    static void Main()
    {
        uint n;
        Console.Write("Enter 32-bit unsigned integer: ");
        while (!UInt32.TryParse(Console.ReadLine(), out n))
        {
            Console.Write("Invalid Integer. Try again: ");
        }

        byte p;
        Console.Write("Enter starting bit position of the 1st sequence (p): ");
        while (!Byte.TryParse(Console.ReadLine(), out p) | p > 31)
        {
            Console.Write("Invalid Position. Try again: ");
        }

        byte q;
        Console.Write("Enter starting bit position of the 2nd sequence (q): ");
        while (!Byte.TryParse(Console.ReadLine(), out q) | q > 31 | q == p)
        {
            Console.Write("Invalid Position. Try again: ");
        }

        byte k;
        Console.Write("How many bits to exchange? (k): ");
        while (!Byte.TryParse(Console.ReadLine(), out k) | k > Math.Abs(q - p))
        {
            Console.Write("Overlapping Sequences! Try a smaller number: ");
        }

        // Make a sequence of Ones (k bits long) then generate a mask from it
        uint nMaskSequence = ~(uint.MaxValue << k);
        uint nMask = (nMaskSequence << p) | (nMaskSequence << q);

        // Eye-candy stuff
        string nToString = Convert.ToString(n, 2).PadLeft(32, '0');
        string nMaskToString = Convert.ToString(nMask, 2).PadLeft(32, '0');
        char[] sequences = nToString.ToCharArray();
        for (int i = 0; i < sequences.Length; i++)
        {
            if (nMaskToString[i] == '0')
            {
                sequences[i] = ' ';
            }
        }
        Console.WriteLine("n    = {0} bin == {1,10} dec\nswitch {2}",
            nToString, n, new string(sequences));

        // Exchange the bits
        n = ((n >> p) & nMaskSequence) << q |
            ((n >> q) & nMaskSequence) << p |
            (n & ~nMask);

        // Show the result
        nToString = Convert.ToString(n, 2).PadLeft(32, '0');
        Console.WriteLine("nNew = {0} bin == {1,10} dec", nToString, n);
    }
}
