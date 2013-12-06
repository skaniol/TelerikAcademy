using System;

class T2_NightmareOnCodeStreet
{
    static void Main()
    {
        string text = Console.ReadLine();
        int oddCount = 0;
        int oddSum = 0;

        for (int i = 1; i < text.Length; i += 2)
        {
            oddSum += text[i] - 48;
            oddCount++;
        }
        Console.WriteLine(oddCount + " " + oddSum);
    }
}

// Task 2 - Nightmare On Code Street
