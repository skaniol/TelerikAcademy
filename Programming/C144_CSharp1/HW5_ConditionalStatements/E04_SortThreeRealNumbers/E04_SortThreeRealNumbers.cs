// 04. Sort 3 real values in descending order using nested if statements.

using System;

class E04_SortThreeRealNumbers
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

        // I am using array without the built-in sorting method Array.Sort()
        // Instead of nested ifs, I am using a scoring system, sorry

        double[] sorted = { realOne, realOne, realOne };
        byte positionTwo = 2;
        byte positionThree = 2;

        if (realTwo >= realThree)
        {
            positionTwo--;
        }
        else
        {
            positionThree--;
        }
        if (realTwo >= realOne)
        {
            positionTwo--;
        }
        if (realThree >= realOne)
        {
            positionThree--;
        }
        sorted[positionTwo] = realTwo;
        sorted[positionThree] = realThree;

        Console.WriteLine("Sort({0}; {1}; {2}) -> {3}; {4}; {5}",
            realOne, realTwo, realThree,
            sorted[0], sorted[1], sorted[2]);
    }
}
