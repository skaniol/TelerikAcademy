// 06. Write a program that reads the coefficients a, b and c of a
//     quadratic equation ax2+bx+c=0 and solves it (prints its real roots).

using System;
using System.Numerics;

class E06_SolveQuadraticEquation
{
    static void Main()
    {
        decimal a;
        Console.Write("a = ");
        while (!decimal.TryParse(Console.ReadLine(), out a) || a == 0)
        {
            if (a == 0) Console.WriteLine("a must not be equal to 0");
            Console.Write("Invalid number! Try again!\na = ");
        }

        decimal b;
        Console.Write("b = ");
        while (!decimal.TryParse(Console.ReadLine(), out b))
        {
            Console.Write("Invalid number! Try again!\nb = ");
        }

        decimal c;
        Console.Write("c = ");
        while (!decimal.TryParse(Console.ReadLine(), out c))
        {
            Console.Write("Invalid number! Try again!\nc = ");
        }

        decimal d = b * b - 4 * a * c;
        if (d > 0)
        {
            decimal xOne = (-b + (decimal)Math.Sqrt((double)d)) / (2 * a);
            decimal xTwo = (-b - (decimal)Math.Sqrt((double)d)) / (2 * a);
            Console.WriteLine("\nx1 = {0}\nx2 = {1}", xOne, xTwo);
        }
        else if (d == 0)
        {
            decimal xOne = (-b + (decimal)Math.Sqrt((double)d)) / (2 * a);
            Console.WriteLine("\nx1 = x2 = {0}", xOne);
        }
        else
        {
            Complex xOne =
                (-(Complex)b + Complex.Sqrt((double)d)) / (Complex)(2 * a);
            Complex xTwo =
                (-(Complex)b - Complex.Sqrt((double)d)) / (Complex)(2 * a);
            Console.WriteLine("\nx1 = {0} {1}{2}i\nx2 = {3} {4}{5}i",
                xOne.Real, xOne.Imaginary > 0 ? "+" : "", xOne.Imaginary,
                xTwo.Real, xTwo.Imaginary > 0 ? "+" : "", xTwo.Imaginary);
        }
    }
}
