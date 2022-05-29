using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2
{
    class Book
    {
        //class attributes
        public string title;
        public string author;
        public int pages;

        //class methods, constructors
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
            //Console.WriteLine("Constructor called!\n{0} {1} {2}.", aTitle, aAuthor, aPages);
        }

    }
}
