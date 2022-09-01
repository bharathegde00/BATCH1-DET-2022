using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class earlyexeclinq
    {
        private static void Main()
        {
            //The Three

            List<int> numbers = new List<int>();
            numbers.Add(100);
            numbers.Add(101);
            numbers.Add(102);
            numbers.Add(103);

            //early execution
            var numbquerry = (from num in numbers
                             select num).ToList();

            numbers.Add(104);
            numbers.Add(105);
            numbers.Add(106);
            numbers.Remove(101);

            foreach (int num in numbquerry)
            {
                Console.Write("{0} ", num);

            }
            Console.ReadLine();


        }
    }
}
