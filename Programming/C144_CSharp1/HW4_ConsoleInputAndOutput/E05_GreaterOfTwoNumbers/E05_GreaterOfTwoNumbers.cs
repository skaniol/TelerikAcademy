// 05. Write a program that gets two numbers from the console
//     and prints the greater of them. Don’t use if statements.

using System;

class E05_GreaterOfTwoNumbers
{
    static void Main()
    {
        decimal numberOne;
        Console.Write("Enter the 1st number: ");
        while (!decimal.TryParse(Console.ReadLine(), out numberOne))
        {
            Console.Write("Invalid number! Try again: ");
        }

        decimal numberTwo;
        Console.Write("Enter the 2nd number: ");
        while (!decimal.TryParse(Console.ReadLine(), out numberTwo))
        {
            Console.Write("Invalid number! Try again: ");
        }

        Console.WriteLine("{0} is greater than {1}",
            Math.Max(numberOne, numberTwo), Math.Min(numberOne, numberTwo));
    }
}
