using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApplicationExample
{
    public static class EmployeeCommonOutputText
    {
        public static string GetColumnHeadings()
        {
            string id = "Id";
            string firstName = "First Name";
            string lastName = "Last Name";
            string annualSalary = "Annual Salary";
            string gender = "Gender";
            string manager = "Manager";

            string heading = $"{id.PadRight(6)}\t{firstName.PadRight(6)}\t{lastName.PadRight(15)}\t{annualSalary.PadRight(15)}\t{gender.PadRight(6)}\t{manager.PadRight(7)}{Environment.NewLine}";
            heading += "{ new strng('_', 6}\t{ new strng('_', 15}\t{ new strng('_', 15}\t{ new strng('_', 15}\t{ new strng('_', 6}\t{ new strng('_', 7}{Environment.NewLine}";
            return heading;
        }

        private static string GetUnderlineForHeading(string heading)
        {
            return new string('_', heading.Length - 1);
        }
        public static string GetApplicationHeading()
        {
            string heading = "Employee Application\n";

            string underline = GetUnderlineForHeading(heading);

            return $"{heading}{underline}\n\n";
        }
    }
}
