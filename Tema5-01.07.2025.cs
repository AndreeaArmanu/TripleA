using System;

namespace Employee
{
    public enum Status { FullTime, PartTime, Intern, Student }

    public struct EmployeeData
    {
        static string firstNameText = "First Name";
        static string middleNameText = "Middle Name";
        static string familyNameText = "Family Name";
        static string contractHoursPerWeekText = "Contract Hours per Week";
        static string employmentStatusText = "Employment status";
        static string currentlyEmployedText = "Currently Employed";
        static string wagePerYearText = "Wage per Year";
        static string dateOfHireText = "Date of Hire";
        static string dateOfLeaveText = "Date of Leave";
        static string dateOfBirthText = "Date of Birth";


        static string fullNameText = "Full Name";
        static string paymentPerHourText = "Payment per hour";
        static string totalAmountOfMoneyText = "Total Amount of Money";
        static string percentageOfWorkText = "Percentage of worked time";
        static string employeePrompt = "Give data for employee";

        public string FirstName;
        public string? MiddleName;
        public string FamilyName;
        public uint ContractHoursPerWeek;
        public Status Status;
        public bool CurrentlyEmployed;
        public double WagePerYear;
        public DateTime DateOfHire;
        public DateTime? DateOfBirth;
        public DateTime? DateOfLeave;

        public string FullName()
        {
            return (MiddleName != null && MiddleName != " ") ? $"{FirstName} {MiddleName} {FamilyName}" : $"{FirstName} {FamilyName}";
        }
        public double ComputePaymentPerHour()
        {
            return WagePerYear / (ContractHoursPerWeek * 52);
        }
        public int computeDaysWorked()
        {
            DateTime finalDate = CurrentlyEmployed ? DateTime.Now : DateOfLeave.Value;
            TimeSpan timeWorked = finalDate - DateOfHire;
            return timeWorked.Days;
        }
        public double computeTotalAmountOfMoney()
        {
            int daysWorked = computeDaysWorked();
            return daysWorked * WagePerYear / 365;
        }
        public int computeAge()
        {
            if (!DateOfBirth.HasValue)
                return 0;

            DateTime today = DateTime.Today;
            DateTime birthDate = DateOfBirth.Value;

            int age = today.Year - birthDate.Year;

            if (birthDate > today.AddYears(-age))
                age--;

            return age;
        }
        public double computePercentageOfWork()
        {
            int age = computeAge();
            int timeWorked = computeDaysWorked();
            return timeWorked / age;
        }

        public void showInfo()
        {
            Console.WriteLine($"{firstNameText}: {FirstName}");
            if (MiddleName != null)
                Console.WriteLine($"{middleNameText}: {MiddleName}");
            Console.WriteLine($"{familyNameText}: {FamilyName}");
            Console.WriteLine($"{contractHoursPerWeekText}: {ContractHoursPerWeek}");
            Console.WriteLine($"{employmentStatusText}: {Status}");
            Console.WriteLine($"{currentlyEmployedText}: {CurrentlyEmployed}");
            Console.WriteLine($"{wagePerYearText}: {WagePerYear}");
            Console.WriteLine($"{dateOfHireText}: {DateOfHire}");
            if (CurrentlyEmployed)
                Console.WriteLine($"{dateOfBirthText}: {DateOfBirth}");
            else Console.WriteLine($"{dateOfLeaveText}: {DateOfLeave}");
        }
        public void printData()
        {
            string fullName = FullName();
            Console.WriteLine($"{fullNameText}: {fullName}");
            double paymentPerHour = ComputePaymentPerHour();
            Console.WriteLine($"{paymentPerHourText}: {paymentPerHour}");
            double totalAmountOfMoney = computeTotalAmountOfMoney();
            Console.WriteLine($"{totalAmountOfMoneyText}:  {totalAmountOfMoney}");
            if (CurrentlyEmployed)
            {
                double percentageOfWork = computePercentageOfWork();
                Console.WriteLine($"{percentageOfWorkText}: {percentageOfWork.ToString("P")}");
            }
            Console.WriteLine();
        }

        public void IncreaseWage(uint amount)
        {
            WagePerYear += amount;
        }
        public void IncreaseWagePercent(double percentage)
        {
            WagePerYear += WagePerYear * percentage / 100;
        }



        public static string ReadString(string s)
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
        public static uint ReadUInt(string s, bool nonZero)
        {
            string? result = null;
            uint number;
            do
            {
                Console.WriteLine(s);
                result = Console.ReadLine();
            }
            while (!uint.TryParse(result, out number) || (nonZero && number == 0));
            return number;
        }
        public static double ReadDouble(string s)
        {
            string? result = null;
            double number;
            do
            {
                Console.WriteLine(s);
                result = Console.ReadLine();
            }
            while (!double.TryParse(result, out number));
            return number;
        }
        public static bool ReadBool(string s)
        {
            string? result = null;
            bool option;
            do
            {
                Console.WriteLine(s);
                result = Console.ReadLine();
            }
            while (!bool.TryParse(result, out option));
            return option;
        }
        public static Status readStatus(string s)
        {
            string? result = null;
            Status status;
            do
            {
                Console.WriteLine(s);
                result = Console.ReadLine();
            }
            while (!Status.TryParse(result, out status));
            return status;
        }
        public static DateTime readDateTime(string s)
        {
            string? result = null;
            DateTime date;
            do
            {
                Console.WriteLine(s);
                result = Console.ReadLine();
            }
            while (!DateTime.TryParse(result, out date));
            return date;
        }

        public EmployeeData ReadEmployee()
        {
            EmployeeData emp = new EmployeeData();
            emp.FirstName = ReadString("First Name: ");
            emp.MiddleName = ReadString("Middle Name: ");
            emp.FamilyName = ReadString("Family Name: ");
            emp.ContractHoursPerWeek = ReadUInt("Contract Hours/Week:", true);
            emp.Status = readStatus("Employment Status (FullTime,PartTime, Intern, Student):");
            emp.CurrentlyEmployed = ReadBool("Is currently employed?");
            emp.WagePerYear = ReadDouble("Wage per Year: ");
            emp.DateOfHire = readDateTime("Date of Hire:");

            if (emp.CurrentlyEmployed)
                emp.DateOfBirth = readDateTime("Date of Birth: ");
            else
                emp.DateOfLeave = readDateTime("Date of Leave: ");

            return emp;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string introduceEmployeeMessage = "Do you want to introduce an employee? (True/False)";
            string increaseWageMessage = "Do you want to increase an employee's wage? (True/False)";
            string increaseBySumMessage = "Increase wage by a specific sum? (True/False)";
            string sumMessage = "Enter the sum:";
            string percentageMessage = "Enter the percentage:";
            string employeeNumberMessage = "Which employee number?";
            string continueMessage = "Do you want to perform another wage update? (True/False)";

            EmployeeData[] employees = new EmployeeData[50];
            int employeeCount = 0;

            while (employeeCount < employees.Length)
            {
                bool addEmployee = EmployeeData.ReadBool(introduceEmployeeMessage);
                if (!addEmployee)
                    break;

                employees[employeeCount] = new EmployeeData().ReadEmployee();
                employees[employeeCount].showInfo();
                employees[employeeCount].printData();
                employeeCount++;
            }

            bool continueUpdating = true;
            while (continueUpdating)
            {
                bool wantToIncrease = EmployeeData.ReadBool(increaseWageMessage);
                if (!wantToIncrease)
                    break;

                uint index = EmployeeData.ReadUInt(employeeNumberMessage, false);

                if (index >= employeeCount)
                {
                    Console.WriteLine("Invalid employee number.");
                    continue;
                }

                bool bySum = EmployeeData.ReadBool(increaseBySumMessage);
                if (bySum)
                {
                    uint sum = EmployeeData.ReadUInt(sumMessage, false);
                    employees[index].IncreaseWage(sum);
                }
                else
                {
                    double percent = EmployeeData.ReadDouble(percentageMessage);
                    employees[index].IncreaseWagePercent(percent);
                }

                employees[index].showInfo();
                employees[index].printData();

                continueUpdating = EmployeeData.ReadBool(continueMessage);
            }
        }
    }


}
