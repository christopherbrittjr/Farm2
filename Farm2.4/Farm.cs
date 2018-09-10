using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm2._4
{
    class Farm
    {
        public Farm()
        {
            Console.WriteLine("What you doing on my farm? Coming to see the my animals I suppose.\n");
        }
        public void HorseSpeak(Horse horse)
        {
            Console.WriteLine(horse.Speech());
        }
        public void DuckSpeak(Duck duck)
        {
            Console.WriteLine(duck.Speech());
        }
        public void DogSpeak(Dog dog)
        {
            Console.WriteLine(dog.Speech());
        }
        public void CowSpeak(Cow cow)
        {
            Console.WriteLine(cow.Speech());
        }
    }
}
