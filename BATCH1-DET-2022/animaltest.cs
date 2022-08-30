using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class animaltest
    {
        public static void Main()
        {

            List<animal> Animals = new List<animal>();
            Animals.Add(new Cat());
            Animals.Add(new Dog());
            Animals.Add(new Frog());

            foreach (animal a in Animals)  
                Console.WriteLine(a.ToString());
        }
    }
}
