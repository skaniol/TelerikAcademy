using System;

class T1_2_4_8
{
    static void Main()
    {
        ulong a = uint.Parse(Console.ReadLine());
        ulong b = uint.Parse(Console.ReadLine());
        ulong c = uint.Parse(Console.ReadLine());
        ulong r = 0;
        ulong answer;

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
            answer = r / 4;
        }
        else
        {
            answer = r % 4;
        }
        Console.WriteLine(answer);
        Console.WriteLine(r);
    }
}

// Task 1 - 2-4-8
