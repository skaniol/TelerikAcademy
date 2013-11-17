// 09. Write an expression that checks for given point (x, y) if it is
//     within the circle K( (1,1), 3) and
//     out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class E09_IsInCircleAndOutRectangle
{
    static void Main()
    {
        double x;
        Console.Write("Enter the X coordinate: ");
        while (!double.TryParse(Console.ReadLine(), out x))
        {
            Console.Write("Invalid number. Try again: ");
        }

        double y;
        Console.Write("Enter the Y coordinate: ");
        while (!double.TryParse(Console.ReadLine(), out y))
        {
            Console.Write("Invalid number. Try again: ");
        }

        Console.WriteLine("The Point is {0} the circle and {1} the rectangle.",
            (Math.Pow(x-1, 2) + Math.Pow(y-1, 2)) <= 9 ? "within" : "OUT of",
            (x < -1) || (x > 5) || (y > 1) || (y < -1) ? "OUT of" : "within");
    }
}
