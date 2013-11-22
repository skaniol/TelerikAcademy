// 03. A company has name, address, phone number, fax number, web site and
//     manager. The manager has first name, last name, age and a phone number.
//     Write a program that reads the information about a company and
//     its manager and prints them on the console.

using System;

class E03_CompanyInfo
{
    static void Main()
    {
        Console.WriteLine("Enter Company Data\n{0}", new string('-', 60));
        Console.Write("Name         = ");
        string companyName = Console.ReadLine();
        Console.Write("Address      = ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number = ");
        string companyPhoneNum = Console.ReadLine();
        Console.Write("Fax number   = ");
        string companyFaxNum = Console.ReadLine();
        Console.Write("Web site     = ");
        string companyWebSite = Console.ReadLine();
        Console.WriteLine("\nEnter Manager Data\n{0}", new string('-', 60));
        Console.Write("First name   = ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Last name    = ");
        string managerLastName = Console.ReadLine();
        Console.Write("Age          = ");
        float managerAge = float.Parse(Console.ReadLine());
        Console.Write("Phone number = ");
        string managerPhoneNum = Console.ReadLine();

        // Center align the Title
        string title = "-> Info About Company \"" + companyName + "\" <-";
        if (title.Length < 60)
        {
            string dashes = new string('-', (60 - title.Length) / 2);
            title = dashes + title + dashes;
        }

        Console.WriteLine("\n");
        Console.WriteLine(title);
        Console.WriteLine();
        Console.WriteLine("{0,-12} : {1}", "Address", companyAddress);
        Console.WriteLine("{0,-12} : {1}", "Phone number", companyPhoneNum);
        Console.WriteLine("{0,-12} : {1}", "Fax number", companyFaxNum);
        Console.WriteLine("{0,-12} : {1}", "Web site", companyWebSite);
        Console.WriteLine();
        Console.WriteLine("{0,-12} : {1} {2}",
            "Manager", managerFirstName, managerLastName);
        Console.WriteLine("{0,20} {1,-12} : {2}",
            ">", "Age", managerAge);
        Console.WriteLine("{0,20} {1,-12} : {2}",
            ">", "Phone number", managerPhoneNum);
    }
}
