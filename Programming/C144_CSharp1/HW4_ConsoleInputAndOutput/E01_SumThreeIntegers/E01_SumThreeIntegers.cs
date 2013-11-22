// 01. Write a program that reads 3 integer numbers
//     from the console and prints their sum.

using System;

class E01_SumThreeIntegers
{
    static void Main()
    {
        int intOne;
        Console.Write("Enter the 1st integer: ");
        while (!Int32.TryParse(Console.ReadLine(), out intOne))
        {
            Console.Write("Invalid integer! Try again: ");
        }

        int intTwo;
        Console.Write("Enter the 2nd integer: ");
        while (!Int32.TryParse(Console.ReadLine(), out intTwo))
        {
            Console.Write("Invalid integer! Try again: ");
        }

        int intThree;
        Console.Write("Enter the 3rd integer: ");
        while (!Int32.TryParse(Console.ReadLine(), out intThree))
        {
            Console.Write("Invalid integer! Try again: ");
        }

        Console.WriteLine("The sum of {0}, {1} and {2} is {3}",
            intOne, intTwo, intThree, (long)intOne + intTwo + intThree);
    }
}
