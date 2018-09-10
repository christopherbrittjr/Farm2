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
            Console.WriteLine($"{horse.Name()} {horse.Speech()} {horse.Food()} {horse.Ride()}");
        }
        public void DuckSpeak(Duck duck)
        {
            Console.WriteLine($"{duck.Name()} {duck.Speech()} {duck.meal()} {duck.Crime()}");
        }
        public void DogSpeak(Dog dog)
        {
            Console.WriteLine($"{dog.Name()} {dog.Speech()} {dog.Food()} {dog.Companion()}");
        }
        public void CowSpeak(Cow cow)
        {
            Console.WriteLine($"{cow.Name()} {cow.Speech()} {cow.Food()} {cow.Milk()}");
        }
    }
}
