using System;

class T3_Enigmanation
{
    static void Main()
    {
        char readChar;
        decimal[] result = new decimal[2];
        ushort[] buffer = new ushort[2];
        byte[] buffedBits = new byte[2];
        byte priority = 0;

        // Starting result: (0 + INPUT) or (-1 * INPUT)
        buffer[priority] = 43;
        buffedBits[priority] = 8;
        readChar = (char)Console.Read();
        if (readChar == '-')
        {
            buffer[priority] = 42;
            result[priority] = -1;
            readChar = (char)Console.Read();
        }

        while (readChar != '=')
        {
            if (readChar == ')')
            {
                priority--;
                result[priority] = Calculate(
                        result[priority],
                        (byte)buffer[priority],
                        result[priority + 1]);
                buffer[priority] = 0;
                buffedBits[priority] = 0;
            }
            else
            {
                buffer[priority] |= (ushort)(readChar << buffedBits[priority]);
                buffedBits[priority] += 8;
            }

            if (buffedBits[priority] >= 16)
            {
                byte firstChar = (byte)buffer[priority];
                byte secondChar = (byte)(buffer[priority] >> 8);

                if (secondChar == 40)
                {
                    buffer[priority] = firstChar;
                    buffedBits[priority] -= 8;
                    priority++;
                    result[priority] = 0;
                    buffer[priority] = 43;
                    buffedBits[priority] = 8;
                }
                else
                {
                    result[priority] = Calculate(
                        result[priority], firstChar, secondChar - (byte)48);
                    buffer[priority] = 0;
                    buffedBits[priority] -= 16;
                }
            }
            readChar = (char)Console.Read();
        }
        Console.WriteLine("{0:F3}", result[0]);
    }

    static decimal Calculate(decimal leftNum, byte operation, decimal rightNum)
    {
        decimal result = 0;
        switch (operation)
        {
            case 37:
                result = leftNum % rightNum;
                break;
            case 42:
                result = leftNum * rightNum;
                break;
            case 43:
                result = leftNum + rightNum;
                break;
            case 45:
                result = leftNum - rightNum;
                break;
            default:
                break;
        }
        return result;
    }
}

// Task 3 - Enigmanation
