// 06. Write an expression that checks if given point (x,  y)
//     is within a circle K(O, 5)

using System;

class E06_IsPointWithinCircle
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

        Console.WriteLine("The Point is {0} circle K(0,0) R = 5",
            x*x + y*y <= 25 ? "within" : "OUT of");
    }
}
