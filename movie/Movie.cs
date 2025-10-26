using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movie
{
    internal class Movie :Base
    {
        public string Director { get; set; }
        public string Genre { get; set; }
        public int AgeLimit { get; set; }
        private int idCounter = 0;
        public Movie(string name, string director, string genre, int ageLimit):base(name)

        {
            Director = director;
            Genre = genre;
            AgeLimit = ageLimit;
            ID = idCounter++;
        }
    }
}
