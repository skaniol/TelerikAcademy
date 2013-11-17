// 02. Write a boolean expression that checks for given integer if it
//     can be divided (without remainder) by 7 and 5 in the same time.

using System;

class E02_DivisableBySevenAndFive
{
    static void Main()
    {
        int n;
        Console.Write("Enter an integer: ");
        while (!Int32.TryParse(Console.ReadLine(), out n))
        {
            Console.Write("Invalid Integer. Try again: ");
        }

        Console.WriteLine("{0} is {1} without remainder by both 7 and 5", n,
            (n % 7 == 0) && (n % 5 == 0) ? "divisable" : "NOT divisable");

        // Using lowest common denominator of 7 and 5 (35) is shorter
        Console.WriteLine("{0} is {1} without remainder by both 7 and 5", n,
            (n % 35 == 0) ? "divisable" : "NOT divisable");
    }
}
