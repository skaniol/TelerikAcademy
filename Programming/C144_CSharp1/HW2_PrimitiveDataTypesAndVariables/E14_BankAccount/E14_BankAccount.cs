// 14. A bank account has a holder name (first name, middle name and last name),
//     available amount of money (balance), bank name, IBAN, BIC code and
//     3 credit card numbers associated with the account. Declare the variables
//     needed to keep the information for a single bank account using the
//     appropriate data types and descriptive names.

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
        ulong[] creditCard = {
              4000080706200002u, 3722316742600000u, 2937816292739723u };
    }
}