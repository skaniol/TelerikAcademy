using System;

class T1_2_4_8
{
    static void Main()
    {
        ulong a = ulong.Parse(Console.ReadLine());
        ulong b = ulong.Parse(Console.ReadLine());
        ulong c = ulong.Parse(Console.ReadLine());
        ulong r = 0;

        switch (b)
        {
            case 2:
                r = a % c;
                break;
            case 4:
                r = a + c;
                break;
            case 8:
                r = a * c;
                break;
            default:
                break;
        }
        if (r % 4 == 0)
        {
            Console.WriteLine(r / 4);
        }
        else
        {
            Console.WriteLine(r % 4);
        }
        Console.WriteLine(r);
    }
}

// Task 1 - 2-4-8
