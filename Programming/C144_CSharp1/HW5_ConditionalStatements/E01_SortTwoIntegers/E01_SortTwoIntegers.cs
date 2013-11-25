// 01. Write an if statement that examines two integer variables and exchanges
//     their values if the first one is greater than the second one.

using System;

class E01_SortTwoIntegers
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

        if (firstInt > secondInt)
        {
            var tempInt = firstInt;
            firstInt = secondInt;
            secondInt = tempInt;
            Console.WriteLine("exchange");
        }

        Console.WriteLine("1st int = {0}; 2nd int = {1}", firstInt, secondInt);
    }
}
