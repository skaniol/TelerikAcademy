// 01. Write a program that prints all the numbers from 1 to N.

using System;

class E01_CountToN
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}
