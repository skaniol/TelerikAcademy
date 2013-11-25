// 03. Write a program that finds the biggest of three integers
//     using nested if statements.

using System;

class E03_MaxOfThreeIntegers
{
    static void Main()
    {
        int firstInt;
        Console.Write("Enter the 1st integer: ");
        while (!int.TryParse(Console.ReadLine(), out firstInt))
        {
            Console.Write("Invalid integer. Try again: ");
        }

        int secondInt;
        Console.Write("Enter the 2nd integer: ");
        while (!int.TryParse(Console.ReadLine(), out secondInt))
        {
            Console.Write("Invalid integer. Try again: ");
        }

        int thirdInt;
        Console.Write("Enter the 3rd integer: ");
        while (!int.TryParse(Console.ReadLine(), out thirdInt))
        {
            Console.Write("Invalid integer. Try again: ");
        }

        int biggest;
        // 'IF' Solution 1: Single assignment + nested ifs
        if ((firstInt < secondInt) || (firstInt < thirdInt))
        {
            if (secondInt < thirdInt)
            {
                biggest = thirdInt;
            }
            else
            {
                biggest = secondInt;
            }
        }
        else
        {
            biggest = firstInt;
        }

        Console.WriteLine("MaxSolution1({0}; {1}; {2}) == {3}",
            firstInt, secondInt, thirdInt, biggest);

        // 'IF' Solution 2: Multiple assignments without nested ifs
        biggest = firstInt;
        if (secondInt > biggest)
        {
            biggest = secondInt;
        }
        if (thirdInt > biggest)
        {
            biggest = thirdInt;
        }

        Console.WriteLine("MaxSolution2({0}; {1}; {2}) == {3}",
            firstInt, secondInt, thirdInt, biggest);
    }
}
