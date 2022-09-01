using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class PrtitioningLINQ
    {
        private static void Main()
        {
          //  string[] words = { "one", "two", "three", "four", "five", "six" };

           // var result = words.Skip(4);

            //Console.WriteLine("Skips the first 4 words:");
            //foreach (string word in result)
               // Console.WriteLine(word);



           //string[] words = { "one", "two", "three", "four", "five","six"};
           //var result = words.SkipWhile(w => w.Length == 3);

            //Console.WriteLine("Skips words while the condition is met:");
            //foreach (string word in result)
              // Console.WriteLine(word);




            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

           // var result = numbers.Take(5);

           // Console.WriteLine("Takes the first 5 numbers only:");
           // foreach (int number in result)
             //  Console.WriteLine(number);



            int[] numbers = { 1, 3, 4, 5, 6, 7, 8, 9, 10, 2 };

           var result = numbers.TakeWhile(n => n < 5);

           Console.WriteLine("Takes numbers one by one, and stops when condition is no longer met:");
            foreach (int number in result)
               Console.WriteLine(number);

        }
    }
}
