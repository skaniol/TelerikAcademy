using System;

class ForestRoad
{
    static void Main()
    {
        byte width = byte.Parse(Console.ReadLine());
        byte height = (byte)(2 * width - 1);
        sbyte direction = 1;
        byte position = 0;
        width--;
        while (height-- > 0)
        {
            Console.WriteLine(new string('.', position)
                + "*" + new string('.', width - position));
            if (position == width)
            {
                direction *= -1;    
            }
            position += (byte)direction;
        }
    }
}

// Task 3 - Forest Road
