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
        //arraylist is not strongly typed
        ArrayList _employeeList = null;

        public Employees(){
            _employeeList = new ArrayList();
            SeedData();
        }

        public Employee this[int index]
        {
            //return the employee object from employee collection based on the unique index
            get
            {
                return (Employee)_employeeList[index];
            }
            //used to update a collection item at a specific index
            //we don't need it, so we will comment it
            /*set
            {
                _employeeList[index] = value;
            }*/
        }

        private void SeedData()
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

        public void Update(Employee employee, string firstName, string lastName, decimal annualSalary, char gender, bool isManager)
        {
            employee.FirstName = firstName;
            employee.LastName = lastName;
            employee.AnnualSalary = annualSalary;
            employee.Gender = gender;
            employee.IsManager = isManager;
        }

        public void Delete(int index)
        {
            _employeeList.RemoveAt(index);
        }

        public int Find(int id)
        {
            int count = 0;
            foreach(Employee employee in _employeeList)
            {
                if(employee.Id == id)
                {
                    return count;
                }
                count++;
            }
            return -1;
        }

        //returns number of employees stored in the list
        public int Count()
        {
            return _employeeList.Count;
        }

        //allows client code to traverse the item stored in the employees collection, through a foreach loop
        public IEnumerator GetEnumerator()
        {
            return _employeeList.GetEnumerator();
        }
    }
}
