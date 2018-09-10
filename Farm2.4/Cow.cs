using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm2._4
{
    class Cow
    {
        private string name, speak, food, milk;
      
        public Cow(string name, string speak, string food, string milk)
        {
            this.name = name;
            this.speak = speak;
            this.food = food;
            this.milk = milk;
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
        public string Milk()
        {
            return milk;
        }
    }
}
