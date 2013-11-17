// 03. Write an expression that calculates
//     rectangle’s area by given width and height.

using System;

class E03_CalculateAreaOfRectangle
{
    static void Main()
    {
        double width;
        Console.Write("Enter the Rectangle's Width: ");
        while (!double.TryParse(Console.ReadLine(), out width) || width < 0)
        {
            Console.Write("Invalid number. Try again: ");
        }

        double height;
        Console.Write("Enter the Rectangle's Height: ");
        while (!double.TryParse(Console.ReadLine(), out height) || height < 0)
        {
            Console.Write("Invalid number. Try again: ");
        }

        Console.WriteLine("The rectangle's Area is: " + (width * height));
    }
}
