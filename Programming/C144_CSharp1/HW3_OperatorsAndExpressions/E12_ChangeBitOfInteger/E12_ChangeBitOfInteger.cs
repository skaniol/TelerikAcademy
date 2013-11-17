// 12. We are given integer number n, value v (v=0 or 1) and a position p.
//     Write a sequence of operators that modifies n to hold the value v
//     at the position p from the binary representation of n.
//     Example1: n = 5 (00000101), p=3, v=1 -> 13 (00001101)
//     Example2: n = 5 (00000101), p=2, v=0 -> 1 (00000001)

using System;

class E12_ChangeBitOfInteger
{
    static void Main()
    {
        int n;
        Console.Write("Enter an integer: ");
        while (!Int32.TryParse(Console.ReadLine(), out n))
        {
            Console.Write("Invalid Integer. Try again: ");
        }

        int p;
        Console.Write("Enter bit position: ");
        while (!Int32.TryParse(Console.ReadLine(), out p))
        {
            Console.Write("Invalid Integer. Try again: ");
        }

        byte v;
        Console.Write("Enter bit value (v=0 or 1): ");
        while (!Byte.TryParse(Console.ReadLine(), out v) || (v > 1))
        {
            Console.Write("Invalid value. Try again: ");
        }

        int nModified = n & ~(1 << p);
        nModified |= (v << p);

        Console.WriteLine("n = {0,4} ({1}); p={2}, v={3}\n -> {4,4} ({5})", n,
            Convert.ToString(n, 2).PadLeft(32, '0'),
            p, v, nModified, Convert.ToString(nModified, 2).PadLeft(32, '0'));
    }
}
