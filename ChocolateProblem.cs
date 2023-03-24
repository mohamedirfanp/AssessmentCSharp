using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityOnClassInCSharp
{
    internal class ChocolateProblem
    {
        // The front side indicates top and back side indicates bottom.
        SortedList<string, int> dispenser = new SortedList<string,int>();

        public void addChocolates(string color, int count)
        {
            dispenser.Add(color, count);
        }
        public void removeChocolates(int NumberToRemove)
        {
            try
            {
               
            }
            catch(Exception e)
            {
                Console.WriteLine("ERROR : "+ e.Message);
            }
        }
    }
}
