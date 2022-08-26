using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class Empdet
    {

        public static void Main()
        {
            Emp e = new Emp(22773, "Bharath", new DateOnly(2014, 08, 20));
            Console.WriteLine($"Years of Experience is {e.GetYearsofExp()}");
        }
    }
}
