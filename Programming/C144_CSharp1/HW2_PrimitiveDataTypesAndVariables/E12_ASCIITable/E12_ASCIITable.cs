// 12. Find online more information about ASCII (American Standard Code for
//     Information Interchange) and write a program that prints the entire
//     ASCII table of characters on the console.

using System;

class E12_ASCIITable
{
    static void Main()
    {
        string[] controlCodes =
        {
            "\\0", "SOH", "STX", "ETX", "EOT", "ENQ", "ACK", "\\a",
            "\\b", "\\t", "\\n", "\\v", "\\f", "\\r", "SO", "SI",
            "DLE", "DC1", "DC2", "DC3", "DC4", "NAK", "SYN", "ETB",
            "CAN", "EM", "SUB", "ESC", "FS", "GS", "RS", "US", "DEL"
        };

        // Print the first row of the hexadecimal address guide
        Console.Write("HEX ");
        for (int column = 0; column < 16; column++)
        {
            Console.Write("{0,4:X2}", column);
        }
        Console.WriteLine("\n   +" + new string('-', 64));

        // Print the Control Codes (ASCII codes 0 to 31)
        for (int row = 0; row < 0x20; row += 0x10)
        {
            Console.Write("{0:X2} |", row);
            for (int column = 0; column < 16; column++)
            {
                Console.Write("{0,4}", controlCodes[column + row]);
            }
            Console.WriteLine();
        }

        // Print the rest of the ASCII table (printable characters)
        for (int row = 0x20; row < 0x80; row += 0x10)
        {
            Console.Write("{0:X2} |", row);
            for (int column = 0; column < 16; column++)
            {
                Console.Write("{0,4}", (char)(column + row));
            }
            Console.WriteLine();
        }
        // Fix the last ASCII char, which is the DEL control code
        Console.SetCursorPosition(64, Console.CursorTop - 1);
        Console.WriteLine("{0,4}", controlCodes[32]);
    }
}
