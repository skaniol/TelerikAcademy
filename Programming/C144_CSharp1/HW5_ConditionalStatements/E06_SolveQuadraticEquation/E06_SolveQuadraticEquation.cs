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
            Console.Write("Invalid number! Try again! a = ");
        }

        decimal b;
        Console.Write("b = ");
        while (!decimal.TryParse(Console.ReadLine(), out b))
        {
            Console.Write("Invalid number! Try again! b = ");
        }

        decimal c;
        Console.Write("c = ");
        while (!decimal.TryParse(Console.ReadLine(), out c))
        {
            Console.Write("Invalid number! Try again! c = ");
        }

        double d = (double)(b * b - 4 * a * c);
        if (d > 0)
        {
            decimal xOne = (-b + (decimal)Math.Sqrt(d)) / (2 * a);
            decimal xTwo = (-b - (decimal)Math.Sqrt(d)) / (2 * a);
            Console.WriteLine();
            Console.WriteLine("x1 = " + xOne);
            Console.WriteLine("x2 = " + xTwo);
        }
        else if (d == 0)
        {
            decimal xOne = -b / (2 * a);
            Console.WriteLine();
            Console.WriteLine("x1 = x2 = " + xOne);
        }
        else
        {
            Complex xOne =
                (-(Complex)b + Complex.Sqrt(d)) / (Complex)(2 * a);
            Complex xTwo =
                (-(Complex)b - Complex.Sqrt(d)) / (Complex)(2 * a);
            Console.WriteLine();
            Console.WriteLine("No real roots. Imaginary roots:");
            Console.WriteLine("x1 = {0} {1}{2}i",
                xOne.Real, xOne.Imaginary > 0 ? "+" : "", xOne.Imaginary);
            Console.WriteLine("x2 = {0} {1}{2}i",
                xTwo.Real, xTwo.Imaginary > 0 ? "+" : "", xTwo.Imaginary);
        }
    }
}
