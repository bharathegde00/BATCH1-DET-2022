using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class AggregationLINQ
    {
         static void aggrmult()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };

            var result = numbers.Aggregate((a, b) => a * b);

            Console.WriteLine("Aggregated numbers by multiplication:");
            Console.WriteLine(result);
        }

        static void avg()
        {
            int[] numbers = { 10, 10, 11, 11 };

            var result = numbers.Average();

            Console.WriteLine("Average is:");
            Console.WriteLine(result);
        }

        static void count()
        {
            string[] names = { "Peter", "John", "Kathlyn", "Allen", "Tim" };

            var result = names.Count();

            Console.WriteLine("Counting names gives:");
            Console.WriteLine(result);
        }

        static void max()
        {
            int[] numbers = { 2, 8, 5, 6, 1 };

            var result = numbers.Max();

            Console.WriteLine("Highest number is:");
            Console.WriteLine(result);
        }

        static void min()
        {
            int[] numbers = { 6, 9, 3, 7, 5 };

            var result = numbers.Min();

            Console.WriteLine("Lowest number is:");
            Console.WriteLine(result);
        }

        static void sum()
        {
            int[] numbers = { 2, 5, 10 };

            var result = numbers.Sum();

            Console.WriteLine("Summing the numbers yields:");
            Console.WriteLine(result);
        }

        private static void Main()
        {
            //aggrmult();
            //avg();
            //count();
            //max();
            //min();
           sum();

        }


    }
}
