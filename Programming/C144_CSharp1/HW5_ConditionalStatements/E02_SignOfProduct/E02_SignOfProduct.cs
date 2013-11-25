// 02. Write a program that shows the sign (+ or -) of the product of three
//     real numbers without calculating it. Use a sequence of if statements.

using System;

class E02_SignOfProduct
{
    static void Main()
    {
        double realOne;
        Console.Write("Enter the 1st real number: ");
        while (!double.TryParse(Console.ReadLine(), out realOne))
        {
            Console.Write("Invalid number. Try again: ");
        }

        double realTwo;
        Console.Write("Enter the 2nd real number: ");
        while (!double.TryParse(Console.ReadLine(), out realTwo))
        {
            Console.Write("Invalid number. Try again: ");
        }

        double realThree;
        Console.Write("Enter the 3rd real number: ");
        while (!double.TryParse(Console.ReadLine(), out realThree))
        {
            Console.Write("Invalid number. Try again: ");
        }

        char sign = '+';
        if ((realOne == 0) | (realTwo == 0) | (realThree == 0))
        {
            sign = '0';
        }
        else if ((realOne < 0) ^ (realTwo < 0) ^ (realThree < 0))
        {
            sign = '-';
        }

        Console.WriteLine("The sign of the product is \"{0}\"", sign);
    }
}
