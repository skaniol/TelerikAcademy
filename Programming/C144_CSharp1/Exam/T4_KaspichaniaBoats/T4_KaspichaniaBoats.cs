using System;

class T4_KaspichaniaBoats
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());
        int width = n * 2 + 1;
        int sideLength = (width - 1) / 2;
        decimal height = 6 + ((n - 3) / 2m) * 3;
        decimal sailsHeight = (2m / 3) * height;
        decimal baseHeight = height / 3m;

        Console.WriteLine(
            new string('.', sideLength) + "*" + new string('.', sideLength));
        for (int i = (int)sailsHeight - 2; i > 0; i--)
        {
            string left = new string('.', i) + "*";
            left += new string('.', sideLength - left.Length);
            string right = "";
            for (int j = 0; j < left.Length; j++)
            {
                right += left[left.Length - j - 1].ToString();
            }
            Console.WriteLine(left + '*' + right);
        }
        Console.WriteLine(new string('*', width));
        for (int i = 1; i < (int)baseHeight; i++)
        {
            string left = new string('.', i) + "*";
            left += new string('.', sideLength - left.Length);
            string right = "";
            for (int j = 0; j < left.Length; j++)
            {
                right += left[left.Length - j - 1].ToString();
            }
            Console.WriteLine(left + '*' + right);
        }
        Console.WriteLine(
            new string('.', (int)baseHeight) + new string('*', n) +
            new string('.', (int)baseHeight));
    }
}

// Task 4 - Kaspichania Boats
