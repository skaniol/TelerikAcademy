// 02. Write a program that reads the radius r of a circle
//     and prints its perimeter and area.

using System;

class E02_PerimeterAndAreaOfCircle
{
    static void Main()
    {
        decimal r;

        Console.Write("Enter the radius r: ");
        while (!decimal.TryParse(Console.ReadLine(), out r) || r < 0)
        {
            Console.Write("Invalid number. Try again: ");
        }

        decimal perimeter = 2m * r * (decimal)Math.PI;
        decimal area = r * r * (decimal)Math.PI;

        Console.WriteLine("perimeter = " + perimeter);
        Console.WriteLine("area = " + area);
    }
}
