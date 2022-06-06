using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplicationExample
{
    public class Employee
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public decimal AnnualSalary;
        public char Gender;
        public bool IsManager;
    }
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee();
            employee.Id = 1;
            employee.FirstName = "Emanuel";
            employee.LastName = "Smith";
            employee.AnnualSalary = 10000;
            employee.Gender = 'M';
            employee.IsManager = false;

            Console.WriteLine($"Annual Salary before update: {employee.AnnualSalary}");

            UpdateAnnualSalary(employee);

            Console.WriteLine($"Annual Salary after update: {employee.AnnualSalary}");

            Console.ReadKey();
        }

        public static void UpdateAnnualSalary(Employee employee)
        {
            employee.AnnualSalary = 19000;
        }
    }
}
