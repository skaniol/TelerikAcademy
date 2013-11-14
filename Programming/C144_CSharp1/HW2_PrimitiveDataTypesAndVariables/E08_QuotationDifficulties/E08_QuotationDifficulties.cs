// 08. Declare two string variables and assign them with following value:
//              The "use" of quotations causes difficulties.
//     Do the above in two different ways: with and without using quoted strings

class E08_QuotationDifficulties
{
    static void Main()
    {
        string escapedString = "The \"use\" of quotations causes difficulties.";
        string quotedString = @"The ""use"" of quotations causes difficulties.";
        System.Console.WriteLine(escapedString);
        System.Console.WriteLine(quotedString);
    }
}