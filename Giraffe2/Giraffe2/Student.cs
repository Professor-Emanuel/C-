using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;
        public Student(string aName, string aMajor, double aGpa)
        {
            Console.WriteLine("Constructor called!");
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        //method
        public bool HasHonors()
        {
            if(gpa >= 3.5)
            {
                return true;
            }
            return false;
        }
    }
}
