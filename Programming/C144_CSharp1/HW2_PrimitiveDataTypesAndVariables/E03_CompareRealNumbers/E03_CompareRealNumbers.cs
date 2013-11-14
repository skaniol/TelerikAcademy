// 03. Write a program that safely compares floating-point numbers
//     with precision of 0.000001. Examples:
//     (5.3 ; 6.01) -> false;  (5.00000001 ; 5.00000003) -> true

using System;
using System.Globalization;

class E03_CompareRealNumbers
{
    static void Main()
    {
        double a;
        double b;

        Console.Write("Enter 1st real number: ");
        while (!double.TryParse(Console.ReadLine(), out a))
        {
            Console.Write("Invalid number. Try a '{0}' for decimal separator: ",
                          NumberFormatInfo.CurrentInfo.NumberDecimalSeparator);
        }

        Console.Write("Enter 2nd real number: ");
        while (!double.TryParse(Console.ReadLine(), out b))
        {
            Console.Write("Invalid number. Try a '{0}' for decimal separator: ",
                          NumberFormatInfo.CurrentInfo.NumberDecimalSeparator);
        }

        Console.WriteLine("({0} ; {1}) -> {2}", a, b, Math.Abs(a - b) < 0.000001);
    }
}