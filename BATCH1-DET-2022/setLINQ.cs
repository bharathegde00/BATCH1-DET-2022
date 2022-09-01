using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class setLINQ
    {
        static void Sample_Distinct_Lambda()
        {
            int[] numbers = { 1, 2, 2, 3, 5, 6, 6, 6, 8, 9 };

            var result = numbers.Distinct();

            Debug.WriteLine("Distinct removes duplicate elements:");
            foreach (int number in result)
                Debug.WriteLine(number);
        }

        static void Sample_Except_Lambda()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            var result = numbers1.Except(numbers2);

            Debug.WriteLine("Except creates a single sequence from numbers1 and removes the duplicates found in numbers2:");
            foreach (int number in result)
                Debug.WriteLine(number);
        }

        static void Sample_Intersect_Lambda()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            var result = numbers1.Intersect(numbers2);

            Debug.WriteLine("Intersect creates a single sequence with only the duplicates:");
            foreach (int number in result)
                Debug.WriteLine(number);
        }

        static void Sample_Union_Lambda()
        {
            int[] numbers1 = { 1, 2, 3 };
            int[] numbers2 = { 3, 4, 5 };

            var result = numbers1.Union(numbers2);

            Debug.WriteLine("Union creates a single sequence and eliminates the duplicates:");
            foreach (int number in result)
                Debug.WriteLine(number);
        }
    }
}
