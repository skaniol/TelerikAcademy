using System;

class T5_GameOfPage
{
    static void Main()
    {
        int boughtCookies = 0;
        ushort[] lines = new ushort[18];
        for (int i = 1; i < 17; i++)
        {
            lines[i] = Convert.ToUInt16(Console.ReadLine(), 2);
        }
        string question = Console.ReadLine();
        while (question != "paypal")
        {
            //============================= Debug ==============================
            //Console.WriteLine("________________");
            //for (int i = 1; i < 17; i++)
            //{
            //    Console.WriteLine(
            //        Convert.ToString(lines[i], 2).PadLeft(16, '0') + " " +
            //        (i - 1) % 10);
            //}
            //Console.WriteLine(Environment.NewLine + "0123456789012345");
            //==================================================================
            byte row = byte.Parse(Console.ReadLine());
            sbyte column = sbyte.Parse(Console.ReadLine());
            column = (sbyte)(14 - column);
            ushort area;
            if (column == -1)
            {
                area = (ushort)((lines[row++] << 7 |
                    lines[row++] << 4 | lines[row] << 1) & 438);
            }
            else
            {
                area = (ushort)((lines[row++] >> column << 6 |
                    lines[row++] >> column << 3 | lines[row] >> column) & 511);
            }
            //============================= Debug ==============================
            //Console.WriteLine();
            //Console.WriteLine("{0} {1} {2}", question, row - 2, 14 - column);
            //Console.WriteLine(Convert.ToString(area >> 6, 2).PadLeft(3, '0'));
            //Console.WriteLine(Convert.ToString((area >> 3) & 7, 2).PadLeft(3, '0'));
            //Console.WriteLine(Convert.ToString(area & 7, 2).PadLeft(3, '0'));
            //==================================================================
            string answer = "smile";
            bool buy = (question == "buy");
            if ((area & 16) != 0)
            {
                switch (area)
                {
                    case 16:
                        answer = buy ? "page" : "cookie crumb";
                        break;
                    case 511:
                        answer = "cookie";
                        break;
                    default:
                        answer = buy ? "page" : "broken cookie";
                        break;
                }
            }
            if (buy && answer == "cookie")
            {
                lines[row--] &= (ushort)~(7 << column);
                lines[row--] &= (ushort)~(7 << column);
                lines[row] &= (ushort)~(7 << column);
                boughtCookies++;
            }
            else
            {
                Console.WriteLine(answer);
            }
            question = Console.ReadLine();
        }
        Console.WriteLine(1.79m * boughtCookies);
    }
}

// Task 5 - Game of Page
