// 10. A marketing firm wants to keep record of its employees.
//     Each record would have the following characteristics –
//     first name, family name, age, gender (m or f), ID number,
//     unique employee number (27560000 to 27569999). 
//     Declare the variables needed to keep the information for a
//     single employee using appropriate data types and descriptive names.

using System;

class E10_EmployeeRecord
{
    static void Main()
    {
        string firstName = "John";
        string lastName = "Doe";
        byte age = 30;
        bool isMale = true;
        ulong id = 8508083065u;
        uint employeeNumber = 27563695u;

        Console.WriteLine(
            "First name: {0}\n Last name: {1}\n       Age: {2}",
            firstName, lastName, age);
        Console.WriteLine("    Gender: {0}", isMale ? "m" : "f");
        Console.WriteLine("      ID \u2116: {0}", id);
        Console.WriteLine("Employee \u2116: {0}", employeeNumber);
    }
}