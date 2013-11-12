// Write a program to read your age from the console
// and print how old you will be after 10 years.

using System;

class E12_TenYearsOlder
{
    static void Main()
    {
        byte age;
        Console.Write("Enter your age in years: ");
        while (!Byte.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("Lying about your age? Enter your true age, please!");
        }
        Console.WriteLine("If you are still alive after 10 years, you'll be {0} years old.", age + 10);
    }
}