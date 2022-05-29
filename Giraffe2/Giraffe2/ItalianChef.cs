using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2
{
    class ItalianChef : Chef
    {
       public void ItalianDish()
        {
            Console.WriteLine("The Chef makes italian dish.");
        }
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes pasta.");
        }

    }
}
