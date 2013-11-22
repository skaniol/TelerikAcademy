// 07. Write a program that gets a number n and after that gets
//     more n numbers and calculates and prints their sum. 

using System;

class E07_SumOfXNumbers
{
    static void Main()
    {
        decimal sum = 0;
        decimal n;
        decimal totalNums;

        Console.Write("n = ");
        while (!decimal.TryParse(Console.ReadLine(), out totalNums))
        {
            Console.Write("Invalid number! Try again!\nn = ");
        }
        Console.WriteLine();

        for (decimal i = 1; i <= totalNums; i++)
        {
            Console.Write("n{0:00} = ", i);
            while (!decimal.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Invalid number! Try again!\nn{0:00} = ", i);
            }
            sum += n;
        }

        Console.WriteLine("\nsum = " + sum);
    }
}