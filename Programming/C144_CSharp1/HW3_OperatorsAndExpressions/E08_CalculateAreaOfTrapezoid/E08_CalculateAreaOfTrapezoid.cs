// 08. Write an expression that calculates trapezoid's area by given
//     sides a and b and height h.

using System;

class E08_CalculateAreaOfTrapezoid
{
    static void Main()
    {
        double sideA;
        Console.Write("Side a = ");
        while (!double.TryParse(Console.ReadLine(), out sideA) || sideA < 0)
        {
            Console.Write("Invalid number. Try again: ");
        }

        double sideB;
        Console.Write("Side b = ");
        while (!double.TryParse(Console.ReadLine(), out sideB) || sideB < 0)
        {
            Console.Write("Invalid number. Try again: ");
        }

        double height;
        Console.Write("Enter the Trapezoid's Height: ");
        while (!double.TryParse(Console.ReadLine(), out height) || height < 0)
        {
            Console.Write("Invalid number. Try again: ");
        }

        Console.WriteLine("The trapezoid's Area is: " + 
            (sideA + sideB) / 2.0 * height);
    }
}
