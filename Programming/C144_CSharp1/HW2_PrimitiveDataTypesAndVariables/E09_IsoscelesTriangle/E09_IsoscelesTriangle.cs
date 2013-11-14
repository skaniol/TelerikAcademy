﻿// 09. Write a program that prints an isosceles triangle of 9 copyright symbols ©.
//     Use Windows Character Map to find the Unicode code of the © symbol.
//     Note: the © symbol may be displayed incorrectly.

class E09_IsoscelesTriangle
{
    static void Main()
    {
        for (int spaces = 2, ch = 1; spaces >= 0; spaces--, ch += 2)
        {
            System.Console.WriteLine(new string(' ', spaces) + new string('\u00A9', ch)); 
        }
    }
}
