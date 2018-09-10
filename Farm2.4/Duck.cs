using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm2._4
{
    class Duck
    {
        string name, speak, food, crime;
     
        public Duck(string name, string speak, string food, string crime)
        {
            this.name = name;
            this.speak = speak;
            this.food = food;
            this.crime = crime;
        }
        public string Name()
        {
            return name;
        }
        public string Speech()
        {
            return speak;
        }
        public string meal()
        {
            return food;
        }
        public string Crime()
        {
            return crime;
        }
    }
}
