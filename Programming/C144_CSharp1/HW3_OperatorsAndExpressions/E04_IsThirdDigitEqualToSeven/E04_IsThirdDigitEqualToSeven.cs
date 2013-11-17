// 04. Write an expression that checks for given integer if its
//     third digit (right-to-left) is 7. E. g. 1732 -> true.

using System;

class E04_IsThirdDigitEqualToSeven
{
    static void Main()
    {
        int n;
        Console.Write("Enter an integer: ");
        while (!Int32.TryParse(Console.ReadLine(), out n))
        {
            Console.Write("Invalid Integer. Try again: ");
        }

        Console.WriteLine("{0} -> {1}", n,
            Math.Abs(n / 100) % 10 == 7);
    }
}
