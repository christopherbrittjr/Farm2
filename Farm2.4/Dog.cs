using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm2._4
{
    class Dog
    {
        private string name, speak, food, companion;
        public Dog(string name, string speak, string food, string companion)
        {
            this.name = name;
            this.speak = speak;
            this.food = food;
            this.companion = companion;
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
        public string Companion()
        {
            return companion;
        }
    }
}
