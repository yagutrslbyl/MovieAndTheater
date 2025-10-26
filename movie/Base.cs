using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movie
{
    abstract class Base
    {
        public int ID { get; protected set; }
        public string Name { get; protected set; }
        public int IdCounter = 0;
        protected Base(string name)
        {
            Name = name;
            IdCounter++;
            ID = IdCounter;
            
        }
    }
}
