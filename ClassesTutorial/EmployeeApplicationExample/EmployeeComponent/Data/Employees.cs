using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComponent.Data
{
    public class Employees
    {
        ArrayList _employeeList = null;

        public Employees(){
            _employeeList = new ArrayList();
            SeedData();
        }

        public void SeedData()
        {
            this.Add(EmployeeObjectFactory.CreateNewEmployeeObject("Devin", "Smith", 60000, 'm', false));
            this.Add(EmployeeObjectFactory.CreateNewEmployeeObject("Emanuel", "Ann", 70000, 'm', false));
            this.Add(EmployeeObjectFactory.CreateNewEmployeeObject("Carol", "MacSmith", 80000, 'm', false));
            this.Add(EmployeeObjectFactory.CreateNewEmployeeObject("Ana", "Smith", 90000, 'm', false));
            this.Add(EmployeeObjectFactory.CreateNewEmployeeObject("Levin", "MacDonald", 75000, 'f', false));
            this.Add(EmployeeObjectFactory.CreateNewEmployeeObject("Devin", "MacDon", 60000, 'm', false));
        }

        public void Add(Employee employee)
        {
            _employeeList.Add(employee);
        }

    }
}
