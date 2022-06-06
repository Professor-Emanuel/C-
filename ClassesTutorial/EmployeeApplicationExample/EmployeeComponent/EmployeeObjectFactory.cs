using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeComponent.Data;

namespace EmployeeComponent
{
    public static class EmployeeObjectFactory
    {
        public static Employee CreateNewEmployeeObject(string firstName, string lastName, decimal annualSalary, char gender, bool isManager)
        {
            return new Employee(firstName, lastName, annualSalary, gender, isManager);
        }
    }
}
