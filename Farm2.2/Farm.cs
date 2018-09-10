using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm2._2
{
    class Farm
    {
        public Farm()
        {
            Console.WriteLine("What you doing on my farm? Coming to see the talking horse I suppose");
        }
        public void AnimalSpeak(Horse horse)
        {
            Console.WriteLine(horse.saySomething());
        }
    }
}
