using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm newFarm = new Farm();
            Horse ed = new Horse("Ed", "My Name is Ed. I talk like you humans even though I am a horse.","I like to get hay", "I also allow people to ride on me.\n");
            Duck darkwing = new Duck("Darkwing Duck", "I am the terror that flaps in the night, I am the scourge that pecks at your nightmares, I am DARKWING DUCK!",
                                     "As someone who is on the go, I like me a good burger.","I fight crime to keep this city safe!\n");
            Dog lassie = new Dog("Lassie", "WOOF, WOOF.  What's that Lassie? WOOF WOOF.  Timmy's in a well!  WOOF!  Show me girl!",
                                 "When she isn't saving Timmy from that well, Lassie likes to get dry dog food","She provides me companionship all day long.\n");
            Cow betty = new Cow("Betty", "Betty is my jumping cow.  One time, she jump so high, she jumped over the moon.", "I see Betty eating hay and a lot of grass.", "I get fresh milk from her daily.");
            newFarm.HorseSpeak(ed);
            newFarm.DuckSpeak(darkwing);
            newFarm.DogSpeak(lassie);
            newFarm.CowSpeak(betty);
        }
    }
}
