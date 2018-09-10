using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm newFarm = new Farm();
            Horse ed = new Horse("Ed","My Name is Ed. I talk like you humans even though I am a horse.");
            newFarm.AnimalSpeak(ed);
        }
    }
}
