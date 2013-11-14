// 14. A bank account has a holder name (first name, middle name and last name),
//     available amount of money (balance), bank name, IBAN, BIC code and
//     3 credit card numbers associated with the account. Declare the variables
//     needed to keep the information for a single bank account using the
//     appropriate data types and descriptive names.

using System;

class E14_BankAccount
{
    static void Main()
    {
        string firstName = "John";
        string middleName = "Laquisha";
        string lastName = "Smith";
        decimal accountBalance = 512595012.50250m;
        string bankName = "AXA Banque";
        string iban = "FR7612548029980000000150086";
        string bic = "AXABFRPP";
        ulong[] creditCards = {
              4000080706200002u, 3722316742600000u, 2937816292739723u };

        Console.WriteLine("Account holder: {0} {1} {2}",
            firstName, middleName, lastName);
        Console.WriteLine("Balance = {0}", accountBalance);
        Console.WriteLine("Bank: {0}\tBIC: {1}\tIBAN: {2}",
            bankName, bic, iban);
        Console.WriteLine("Credit Cards: {0}\t{1}\t{2}",
            creditCards[0], creditCards[1], creditCards[2]);

    }
}