﻿// 05. Declare a character variable and assign it with the symbol that has Unicode code 72.
//     Hint: first use the Windows Calculator to find the hexadecimal representation of 72.


class E05_AssignChar
{
    static void Main()
    {
        char symbol = '\u0048';
        System.Console.WriteLine(symbol + " == " + ((char)72 == symbol));
    }
}