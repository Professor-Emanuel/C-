using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComponent.Data
{
    public class Employee
    {
        private static int _nextid = 0;
        private int _id = 0;

        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private decimal _annualSalary = 0;
        private char _gender = '\0';
        private bool _isManager = false;

        //read only = ommiting the "set" - section
        public int Id
        {
            get
            {
                return _id;
            }
        }

        //auto-implemented properties
        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public decimal AnnualSalary
        {
            get;
            set;
        }

        public char Gender
        {
            get;
            set;
        }

        public bool IsManager
        {
            get;
            set;
        }

        public Employee()
        {
            _nextid++;
            _id = _nextid;
        }

        //:this() is to call first the parameterized-less constructor and then the parameterized one.
        /*
         * removed!
         * public Employee(string firstName, string lastname, decimal annualSalary, char gender, bool isManager):this()
        {
            _firstName = firstName;
            _lastName = lastname;
            _annualSalary = annualSalary;
            _gender = gender;
            _isManager = isManager;
        }*/

        public string GetEmployeeInformation()
        {
            string employeeInformation = $"{Id.ToString().PadRight(6)}\t{FirstName.PadRight(15)}\t{LastName.PadRight(15)}\t{AnnualSalary.ToString().PadRight(15)}\t{Gender.ToString().PadRight(6)}\t{IsManager.ToString().PadRight(7)}{Environment.NewLine}";
            return employeeInformation;
        }
    }
}
