﻿// 01. Declare five variables choosing for each of them the most appropriate
//     of the types byte, sbyte, short, ushort, int, uint, long, ulong
//     to represent the following values: 52130, -115, 4825932, 97, -10000.

class E01_AppropriateVars
{
    static void Main()
    {
        ushort a = 52130;
        sbyte b = -115;
        int c = 4825932;
        byte d = 97;
        short e = -10000;

        System.Console.WriteLine("{0}, {1}, {2}, {3}, {4}",
            a, b, c, d, e);
    }
}