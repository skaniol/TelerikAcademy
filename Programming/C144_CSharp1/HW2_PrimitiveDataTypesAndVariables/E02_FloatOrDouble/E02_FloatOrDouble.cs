// 02. Which of the following values can be assigned to a variable
//     of type float and which to a variable of type double:
//     34.567839023, 12.345, 8923.1234857, 3456.091?

using System;

class E02_FloatOrDouble
{
    static void Main()
    {
        double a = 34.567839023;
        float b = 12.345f;
        double c = 8923.1234857;
        float d = 3456.091f;

        Console.WriteLine("34.567839023 -> {0}", a);
        Console.WriteLine("12.345 -> {0}", b);
        Console.WriteLine("8923.1234857 -> {0}", c);
        Console.WriteLine("3456.091 -> {0}", d);
    }
}