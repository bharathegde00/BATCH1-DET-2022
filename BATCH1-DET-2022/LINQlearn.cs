using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class LINQlearn
    {
        private static void Main()
        {
            //The Three

           List<int> numbers = new List<int>();
           numbers.Add(100);
           numbers.Add(101);
            numbers.Add(102);
            numbers.Add(103);

            //sql type linq
            //deferred execution
            //  var numbquerry = from num in numbers
            //                  select num;

            //var numbquerry = from num in numbers
            //                where num>103
            //                select num;

            //Lambda type linq 
            // var numbquerry = numbers.Select(x => x);

            var numbquerry = numbers.Where(x => x > 103);

            numbers.Add(104);
            numbers.Add(105);
            numbers.Add(106);
            numbers.Remove(101);

            foreach (int num in numbquerry)
            {
                Console.Write("{0} ",num);

            }
            Console.ReadLine();


        }
    }
}
