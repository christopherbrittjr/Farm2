using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm newFarm = new Farm();
            Horse ed = new Horse("Ed", "My Name is Ed. I talk like you humans even though I am a horse.\n");
            Duck darkwing = new Duck("Darkwing Duck", "I am the terror that flaps in the night, I am the scourge that pecks at your nightmares, I am DARKWING DUCK!\n");
            Dog lassie = new Dog("Lassie", "WOOF, WOOF.  What's that Lassie? WOOF WOOF.  Timmy's in a well!  WOOF!  Show me girl!\n");
            Cow betty = new Cow("Betty", "Betty is a jumping cow.  One time, she jump so high, she jumped over the moon.\n");
            newFarm.AnimalSpeak(ed);
            newFarm.AnimalSpeak2(darkwing);
            newFarm.AnimalSpeak3(lassie);
            newFarm.AnimalSpeak4(betty);
        }
    }
}
