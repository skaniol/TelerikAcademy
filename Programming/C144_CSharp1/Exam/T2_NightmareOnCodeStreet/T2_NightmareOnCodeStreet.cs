using System;

class T2_NightmareOnCodeStreet
{
    static void Main()
    {
        string text = Console.ReadLine();
        int oddCount = 0;
        ulong oddSum = 0;

        for (int i = 1; i < text.Length; i += 2)
        {
            if (text[i] > 47 && text[i] < 58)
            {
                oddSum += text[i] - 48U;
                oddCount++;
            }
        }
        Console.WriteLine(oddCount + " " + oddSum);
    }
}

// Task 2 - Nightmare On Code Street
