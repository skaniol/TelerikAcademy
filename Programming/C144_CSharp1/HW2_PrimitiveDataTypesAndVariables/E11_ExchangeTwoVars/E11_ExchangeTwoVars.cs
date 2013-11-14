// 11. Declare  two integer variables and assign them with 5 and 10
//     and after that exchange their values.

class E11_ExchangeTwoVars
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c = a;

        System.Console.WriteLine("a == {0}; b == {1}", a, b);
        a = b;
        b = c;
        // XOR method a ^= b; b ^= a; a ^= b;
        
        System.Console.WriteLine("a == {0}; b == {1}", a, b);
    }
}