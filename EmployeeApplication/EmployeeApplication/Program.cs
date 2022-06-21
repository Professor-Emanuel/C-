using System;

namespace EmployeeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeeId = 0;
            string firstName = String.Empty;
            string lastName = String.Empty;
            decimal annualSalary = 0;
            char gender = '\0';
            bool isManager = false;

            Console.WriteLine("Enter a unique Id:");
            employeeId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter F.Name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter L.Name:");
            lastName = Console.ReadLine();

            Console.WriteLine("Enter annualSalary:");
            annualSalary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter gender:");
            gender = Convert.ToChar(Console.ReadLine());


            Console.WriteLine("Enter manager, true/false:");
            isManager = Convert.ToBoolean(Console.ReadLine());

            string genderTerm = (gender == 'f') ? "female" : "male";
            string managerNarrative = (isManager) ? "a manager" : "not a manager";

            string narrative = $"Employee with an Id of {employeeId}";
            narrative += $" who's full name is {firstName} {lastName}{Environment.NewLine}";
            narrative += $"is a {genderTerm} employee who is {managerNarrative}{Environment.NewLine}";
            narrative += $"Has annual salary {annualSalary} pounds.";

            Console.Clear();
            Console.WriteLine(narrative);
            Console.ReadKey();
        }
    }
}
