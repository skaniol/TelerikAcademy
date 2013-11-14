// 09. Write a program that prints an isosceles triangle of 9 copyright symbols ©.
//     Use Windows Character Map to find the Unicode code of the © symbol.
//     Note: the © symbol may be displayed incorrectly.

using System;
using System.Text;

class E09_IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        for (int spaces = 2, ch = 1; spaces >= 0; spaces--, ch += 2)
        {
            Console.WriteLine(new string(' ', spaces) + new string('\u00A9', ch)); 
        }
    }
}
