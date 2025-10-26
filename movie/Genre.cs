using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movie
{
    internal class Genre:Base
    {
        private int idCounter = 0;
        public Genre(string name):base(name)
        {
            ID = idCounter++;
        }
    }
}
