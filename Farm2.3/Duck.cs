﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm2._3
{
    class Duck
    {
        private string name;
        private string speak;
        public Duck(string name, string speak)
        {
            this.name = name;
            this.speak = speak;
        }
        public string speech()
        {
            return speak;
        }
    }
}
