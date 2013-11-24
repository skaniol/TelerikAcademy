// 10. Write a program to calculate the sum (with accuracy of 0.001):
//     1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;

class E10_SumOfSequence
{
    static void Main()
    {
        double sum = 1.0;
        double oldSum;
        int i = 2;
        sbyte sign = 1;

        do
        {
            oldSum = sum;
            sum += 1.0 / (i * sign);
            sign *= -1;
            i++;
        } while (Math.Abs(sum - oldSum) > 0.001);
        Console.WriteLine("{0:F3}", sum);
    }
}
