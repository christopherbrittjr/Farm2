using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm2._2
{
    class Horse
    {
        private string name;
        private string speak;
        public Horse(string name, string speak)
        {
            this.name = name;
            this.speak = speak;
        }
        public string saySomething()
        {
            return speak;
        }

      
    }
}
