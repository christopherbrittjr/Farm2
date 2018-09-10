using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm2._4
{
    class Horse
    {
        string name, speak, food, ride;
        
        public Horse(string name, string speak, string food, string ride)
        {
            this.name = name;
            this.speak = speak;
            this.food = food;
            this.ride = ride;
        }
        public string Name()
        {
            return name;
        }
        public string Speech()
        {
            return speak;
        }
        public string Food()
        {
            return food;
        }
        public string Ride()
        {
            return ride;
        }
    }
}
