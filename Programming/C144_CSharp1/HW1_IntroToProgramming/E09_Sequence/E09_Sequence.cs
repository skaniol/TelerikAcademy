// 09. Write a program that prints the first 10 members of the sequence:
//     2, -3, 4, -5, 6, -7, ...

using System;

class E09_Sequence
{
    static void Main()
    {
        bool isNegative = false;
        int member = 2;
        while (member < 11)
        {
            Console.Write((isNegative ? -member : member) + ", ");
            isNegative = !isNegative;
            member++;
        }
        Console.WriteLine(isNegative ? -member : member);
    }
}