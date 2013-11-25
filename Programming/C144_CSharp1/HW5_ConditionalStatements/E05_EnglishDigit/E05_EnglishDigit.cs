// 05. Write program that asks for a digit and depending on the input shows
//     the name of that digit (in English) using a switch statement.

using System;

class E05_EnglishDigit
{
    static void Main()
    {
        char digit;
        Console.WriteLine("Gimme a digit!");
        do
        {
            ConsoleKeyInfo key = Console.ReadKey();
            digit = key.KeyChar;
            if ((digit < 48) || (digit > 57))
            {
                Console.WriteLine(" -> You call that a digit? Try again!");
            }
            else
            {
                Console.Write(" -> Thanks{}! ");
                break;
            }
        } while (true);
        string digitName;
        switch (digit)
        {
            case '0':
                digitName = "Zero";
                break;
            case '1':
                digitName = "One";
                break;
            case '2':
                digitName = "Two";
                break;
            case '3':
                digitName = "Three";
                break;
            case '4':
                digitName = "Four";
                break;
            case '5':
                digitName = "Five";
                break;
            case '6':
                digitName = "Six";
                break;
            case '7':
                digitName = "Seven";
                break;
            case '8':
                digitName = "Eight";
                break;
            case '9':
                digitName = "Nine";
                break;
            default:
                digitName = "... Oops?";
                break;
        }
        Console.WriteLine("I love \"" + digitName + "\"!");
    }
}
