// 13. Create a program that assigns null values to an integer and to double
//     variables. Try to print them on the console, try to add some values or
//     the null literal to them and see the result.

using System;

class E13_NullValues
{
    static void Main()
    {
        int? intVar = null;
        double? doubleVar = null;
        Console.WriteLine("int = {0}, double = {1}", intVar, doubleVar);
        intVar += 5;
        doubleVar += 1.5;
        Console.WriteLine("int = {0}, double = {1}", intVar, doubleVar);
    }
}