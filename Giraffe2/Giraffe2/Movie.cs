using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2
{
    class Movie
    {
        public string title;
        public string director;
        private string rating;
        //static atributes
        public static int movieCount = 0;

        public Movie(string aTitle, string aDir, string aRat)
        {
            title = aTitle;
            director = aDir;
            //set the rating through the bellow Rating method; calling the setter
            Rating = aRat;
            movieCount++;
        }

        //getters and setters;
        public string Rating
        {
            get { return rating; }
            set 
            {
                //value represents anything that got passed through
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }

        public int getMovieCount()
        {
            return movieCount;
        }
    }
}
