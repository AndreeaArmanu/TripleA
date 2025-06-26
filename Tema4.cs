using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("An employee:");
        ProcessEmployee();

        Console.WriteLine("A former employee:");
        ProcessEmployee();
    }
    static void ProcessEmployee()
    {
        Console.Write("First Name: ");
        string firstName = Console.ReadLine()!;

        Console.Write("Middle Name: ");
        string? middleName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(middleName))
        {
            middleName = null;
        }

        Console.Write("Family Name: ");
        string familyName = Console.ReadLine()!;

        Console.Write("Contract Hours Per Week (uint): ");
        uint contractHoursPerWeek;
        while (!uint.TryParse(Console.ReadLine(), out contractHoursPerWeek))
        {
            Console.Write("Invalid input.");
        }

        Console.Write("Currently Employed? (true/false): ");
        bool currentlyEmployed;
        while (!bool.TryParse(Console.ReadLine(), out currentlyEmployed))
        {
            Console.Write("Invalid input.");
        }

        Console.Write("Wage Per Year (double): ");
        double wagePerYear;
        while (!double.TryParse(Console.ReadLine(), out wagePerYear))
        {
            Console.Write("Invalid input.");
        }

        Console.Write("Weeks Worked (uint): ");
        uint weeksWorked;
        while (!uint.TryParse(Console.ReadLine(), out weeksWorked))
        {
            Console.Write("Invalid input.");
        }

        uint age = 0;
        if (currentlyEmployed)
        {
            Console.Write("Age (uint): ");
            while (!uint.TryParse(Console.ReadLine(), out age))
            {
                Console.Write("Invalid input.");
            }
        }

     
        string fullName = middleName == null ? $"{firstName} {familyName}" : $"{firstName} {middleName} {familyName}";

        double paymentPerHour = (contractHoursPerWeek > 0) ? wagePerYear / (52 * contractHoursPerWeek): 0;

        double totalEarned = wagePerYear * weeksWorked / 52;

        double? workPercentageOfAge = (currentlyEmployed && age > 0) ? (weeksWorked / 52.0) / age * 100: null;

     
        Console.WriteLine($"Full Name: {fullName}");
        Console.WriteLine($"Contract hours per week: {contractHoursPerWeek}");
        Console.WriteLine($"Is currently employed ? {currentlyEmployed}");
        Console.WriteLine($"Wage per week: {wagePerYear:F2}");
        Console.WriteLine($"Weeks worked: {weeksWorked}");
        if (currentlyEmployed)
            Console.WriteLine($"Age: {age}");

        Console.WriteLine($"Payment per hour: {paymentPerHour:F2}");
        Console.WriteLine($"Total earned: {totalEarned:F2}");

        if (workPercentageOfAge.HasValue)
            Console.WriteLine($"Work percentage of age: {workPercentageOfAge.Value:F2}%");
    }
}

