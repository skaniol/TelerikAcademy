using System;

class T5_GameOfPage
{
    static void Main()
    {
        bool playing = true;
        int boughtCookies = 0;
        ushort[] lines = new ushort[16];
        for (int i = 0; i < 3; i++)
        {
            lines[i] = Convert.ToUInt16(Console.ReadLine(), 2);
        }
        while (playing)
        {
            string question = Console.ReadLine();
            if (question == "what is" || question == "buy")
            {
                byte row = byte.Parse(Console.ReadLine());
                byte column = byte.Parse(Console.ReadLine());
                ushort topCookie = 0;
                if (row >= 1)
                {
                    topCookie = lines[row - 1];
                }
                ushort centerCookie = lines[row];
                ushort bottomCookie = 0;
                if (row < 14)
                {
                    bottomCookie = lines[row + 1];
                }
                if (column > 14)
                {
                    topCookie <<= 1;
                    centerCookie <<= 1;
                    bottomCookie <<= 1;
                    column--;
                }
                if (column < 1)
                {
                    topCookie >>= 1;
                    centerCookie >>= 1;
                    bottomCookie >>= 1;
                    column++;
                }
                //========================== Debug =============================
                //Console.WriteLine(Convert.ToString(
                //    (topCookie >> (14 - column)) & 7, 2).PadLeft(3, '0'));
                //Console.WriteLine(Convert.ToString(
                //    (centerCookie >> (14 - column)) & 7, 2).PadLeft(3, '0'));
                //Console.WriteLine(Convert.ToString(
                //    (bottomCookie >> (14 - column)) & 7, 2).PadLeft(3, '0'));
                //==============================================================
                topCookie = (ushort)(topCookie >> (byte)(14 - column) & 7);
                centerCookie = (ushort)(centerCookie >> (byte)(14 - column) & 7);
                bottomCookie = (ushort)(bottomCookie >> (byte)(14 - column) & 7);
                string target = "";
                if (topCookie == 7 && centerCookie == 7 && bottomCookie == 7)
                {
                    target = "cookie";
                }
                else if ((centerCookie & 2) != 0)
                {
                    if ((centerCookie == 2) && (topCookie == 0) && (bottomCookie == 0))
                    {
                        target = "cookie crumb";
                    }
                    else
                    {
                        target = "broken cookie";
                    }
                }
                if (question == "what is")
                {
                    Console.WriteLine(target);
                }
                if (question == "buy")
                {
                    if (target == "broken cookie" ||
                        target == "cookie crumb")
                    {
                        Console.WriteLine("page");
                    }
                    else if (target == "cookie")
                    {
                        lines[row - 1] &= (ushort)~(7 << (14 - column));
                        lines[row] &= (ushort)~(7 << (14 - column));
                        lines[row + 1] &= (ushort)~(7 << (14 - column));
                        boughtCookies++;
                    }
                    else
                    {
                        Console.WriteLine("smile");
                    }
                }
            }
            if (question == "paypal")
            {
                Console.WriteLine(1.79m * boughtCookies);
                playing = false;
            }
        }
    }
}

// Task 5 - Game of Page
