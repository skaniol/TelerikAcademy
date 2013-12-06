// http://bgcoder.com/Contest/Practice/5

using System;
using System.Threading;
using System.Globalization;

class CartesianCoordinateSystem
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture =
        CultureInfo.InvariantCulture;

        decimal x = decimal.Parse(Console.ReadLine());
        decimal y = decimal.Parse(Console.ReadLine());
        if (x == 0 | y == 0)
        {
            Console.WriteLine(x != y ? x == 0 ? 5 : 6 : 0);
        }
        else if (y > 0)
        {
            Console.WriteLine(x > 0 ? 1 : 2);
        }
        else
        {
            Console.WriteLine(x < 0 ? 3 : 4);
        }
    }
}
