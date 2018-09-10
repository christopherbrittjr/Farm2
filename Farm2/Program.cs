using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Throwing an exception because I have not implemented the classes.
            //Farm newFarm = new Farm();
            try
            {
                Console.WriteLine("Farm has not been implement yet");

            }
            catch (Exception nogo)
            {
                Console.WriteLine(nogo.Message);
            }
        }
        
    }
 
}    