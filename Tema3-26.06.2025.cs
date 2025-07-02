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
        string firstName = ReadString("First Name: ");
        string? middleName = ReadString("Middle Name: ");
        string familyName = ReadString("Family Name: ");
        uint contractHoursPerWeek = ReadUInt("Contract Hours Per Week: ");
        bool currentlyEmployed = ReadBool("Currently Employed? (true/false): ");
        double wagePerYear = ReadDouble("Wage Per Year: ");
        uint weeksWorked = ReadUInt("Weeks Worked : ");
        uint age = currentlyEmployed ? ReadUInt("Age: ") : 0;

        string fullName = GetFullName(firstName, middleName, familyName);
        double paymentPerHour = CalculatePaymentPerHour(wagePerYear, contractHoursPerWeek);
        double totalEarned = CalculateTotalEarned(wagePerYear, weeksWorked);
        double? workPercentageOfAge = CalculateWorkPercentageOfAge(weeksWorked, currentlyEmployed, age);

        DisplayEmployeeInfo(fullName, contractHoursPerWeek, currentlyEmployed, wagePerYear, weeksWorked, age, paymentPerHour, totalEarned, workPercentageOfAge);
    }

   static string ReadString(string s)
    {
        string? result = null;
        do
        {
            Console.WriteLine(s);
            result = Console.ReadLine();
        }
        while (result == null);
        return result;
    }

    static uint ReadUInt(string s)
    {
        uint value;
        Console.Write(s);
        while (!uint.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("Invalid input. " + s);
        }
        return value;
    }
    static double ReadDouble(string s)
    {
        double value;
        Console.Write(s);
        while (!double.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("Invalid input. " + s);
        }
        return value;
    }

    static bool ReadBool(string s)
    {
        bool value;
        Console.Write(s);
        while (!bool.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("Invalid input. " + s);
        }
        return value;
    }

    static string GetFullName(string firstName, string? middleName, string familyName)
    {
        return middleName == null ? $"{firstName} {familyName}" : $"{firstName} {middleName} {familyName}";
    }

    static double CalculatePaymentPerHour(double wagePerYear, uint contractHoursPerWeek)
    {
        return contractHoursPerWeek > 0 ? wagePerYear / (52 * contractHoursPerWeek) : 0;
    }

    static double CalculateTotalEarned(double wagePerYear, uint weeksWorked)
    {
        return wagePerYear * weeksWorked / 52;
    }

    static double? CalculateWorkPercentageOfAge(uint weeksWorked, bool currentlyEmployed, uint age)
    {
        return (currentlyEmployed && age > 0) ? (weeksWorked / 52.0) / age * 100 : null;
    }

    static void DisplayEmployeeInfo(string fullName, uint contractHoursPerWeek, bool currentlyEmployed, double wagePerYear, uint weeksWorked, uint age, double paymentPerHour, double totalEarned, double? workPercentageOfAge)
    {
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
