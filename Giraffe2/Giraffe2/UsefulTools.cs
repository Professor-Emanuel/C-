using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2
{
    //static keyword to the class prevents the user from creating objects of type UsefulTools
    static class UsefulTools
    {
        public static void SayHi(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
