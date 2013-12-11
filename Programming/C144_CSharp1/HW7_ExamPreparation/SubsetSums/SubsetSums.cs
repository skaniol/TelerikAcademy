using System;

class SubsetSums
{
    static void Main()
    {
        long s = long.Parse(Console.ReadLine());
        byte n = byte.Parse(Console.ReadLine());
        long[] numbers = new long[n];
        for (byte i = 0; i < n; i++)
        {
            numbers[i] = long.Parse(Console.ReadLine());
        }
        int totalCount = 0;

        for (long i = 1; i < (1 << n); i++)
        {
            long subsetSum = 0;
            for (int j = 0; j < n; j++)
            {
                if (((i >> j) & 1) == 1)
                {
                    subsetSum += numbers[j];
                }
            }
            if (subsetSum == s)
            {
                totalCount++;
            }
        }
        Console.WriteLine(totalCount);
    }
}

// Task 5 - Subset Sums
