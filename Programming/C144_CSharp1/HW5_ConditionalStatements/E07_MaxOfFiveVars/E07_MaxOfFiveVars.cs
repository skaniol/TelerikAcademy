// 07. Write a program that finds the greatest of given 5 variables.

using System;
using System.Linq;

class E07_MaxOfFiveVars
{
    static void Main()
    {
        double[] numbers = new double[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            while (!double.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.Write("Invalid number. Try again: ");
            }
        }

        double max = numbers[0];
        for (int i = 1; i < 5; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        Console.WriteLine();
        Console.WriteLine("Max({0}; {1}; {2}; {3}; {4}) == {5}",
            numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], max);

        // Alternative solution -> using the Max() method
        max = numbers.Max();
        Console.WriteLine("Max({0}; {1}; {2}; {3}; {4}) == {5}",
            numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], max);
    }
}
