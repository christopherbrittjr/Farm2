using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm2._3
{
    class Farm
    {
        public Farm()
        {
            Console.WriteLine("What you doing on my farm? Coming to see the my animals I suppose.\n");
        }
        public void AnimalSpeak(Horse horse)
        {
            Console.WriteLine(horse.saySomething());
        }
        public void AnimalSpeak2(Duck duck)
        {
            Console.WriteLine(duck.speech());
        }
        public void AnimalSpeak3(Dog dog)
        {
            Console.WriteLine(dog.speech());
        }
        public void AnimalSpeak4(Cow cow)
        {
            Console.WriteLine(cow.speech());
        }
    }
}
