using System;

class MissCat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] cats = new int[11];
        // store the max value as 1st element
        for (int i = 0; i < n; i++)
        {
            cats[int.Parse(Console.ReadLine())]++;
        }
        byte winner = 1;
        for (byte i = 1; i <= 10; i++)
        {
            if (cats[i] > cats[0])
            {
                cats[0] = cats[i];
                winner = i;
            }
        }
        Console.WriteLine(winner);
    }
}

// Task 2 - Miss Cat 2011