// 04. Write a program that reads two positive integer numbers and prints
//     how many numbers p exist between them such that the reminder of the
//     division by 5 is 0 (inclusive). Example: p(17,25) = 2.

using System;

class E04_NumbersDivisableByFive
{
    static void Main()
    {
        uint firstNum;
        Console.Write("Enter the 1st positive integer: ");
        while (!UInt32.TryParse(Console.ReadLine(), out firstNum))
        {
            Console.Write("Invalid integer! Try again: ");
        }

        uint secondNum;
        Console.Write("Enter the 2nd positive integer: ");
        while (!UInt32.TryParse(Console.ReadLine(), out secondNum))
        {
            Console.Write("Invalid integer! Try again: ");
        }

        uint tempVar;
        if (firstNum > secondNum)
        {
            tempVar = firstNum;
            firstNum = secondNum;
            secondNum = tempVar;
        }

        int p = 0;
        for (uint i = firstNum; i <= secondNum; i++)
        {
            if (i % 5 == 0)
            {
                p++;
            }
        }

        Console.WriteLine("p ({0}, {1}) = {2}", firstNum, secondNum, p);
    }
}
