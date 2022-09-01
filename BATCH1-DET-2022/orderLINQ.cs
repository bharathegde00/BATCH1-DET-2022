using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class orderLINQ
    {
        private static void Main()
        {




            //  int[] numbers = { 23, 45, 56, 12, 9 };

            // var result = numbers.OrderBy(x => x);

            /// Console.WriteLine("Ordered List of Numbers");

            //  foreach (int i in result)
            //      Console.WriteLine("{0} ", i);

            //   string[] names = { "Bharath", "Jeevan","Yash"};

            // var result = names.OrderByDescending(x => x);

            // Console.WriteLine("Descending List of Names");

            //foreach (string i in result)
            //    Console.WriteLine("{0} ", i);


            /// char[] alphab = { 'b','d','w','a','i','p','f'};

            // var result = alphab.Reverse();

            // Console.WriteLine("Reversed List of characters");

            // foreach (char i in result)
            // Console.WriteLine("{0} ", i);


           // string[] caps = { "Delhi","Tokyo","Dublin","Kathmandu","Beijing" };

         //   var result = caps.OrderBy(x => x.Length).ThenBy(x => x);

           // Console.WriteLine("First Orderedby Length, ThenBy alphabets ");

          //  foreach (string i in result)
             //   Console.WriteLine("{0} ", i);

            var dates = new DateTime[] {
        new DateTime(2021, 4, 1),
        new DateTime(2014, 7, 1),
        new DateTime(2013, 5, 1),
        new DateTime(2015, 1, 1),
        new DateTime(2015, 7, 1)
          };

            var result = dates.OrderByDescending(d => d.Year).ThenByDescending(d => d.Month);

            Console.WriteLine("List of dates first ordered by year descending, and then by month descending:");
            foreach (DateTime dt in result)
                Console.WriteLine(dt.ToString("yyyy/MM/dd"));

        }


    }
}
