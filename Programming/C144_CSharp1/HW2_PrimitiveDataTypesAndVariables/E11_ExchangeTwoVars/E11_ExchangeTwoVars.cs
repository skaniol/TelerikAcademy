// 11. Declare  two integer variables and assign them with 5 and 10
//     and after that exchange their values.

class E11_ExchangeTwoVars
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c = a; // Temp Var method

        System.Console.WriteLine("a == {0}; b == {1}", a, b);
        a = b;
        b = c;
        // a ^= b; b ^= a; a ^= b; // XOR method
        // a = a + b; b = a - b; a = a - b; // addition method
        
        System.Console.WriteLine("a == {0}; b == {1}", a, b);
    }
}