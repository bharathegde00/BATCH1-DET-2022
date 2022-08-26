using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignments
{
    internal class minmaxno
    {
        public static void Main()
        {
            int[] arr = { 2, 68, 29, 71, 8, 83 };
            int a, max, min, b;         
            b = arr.Length;
            max = arr[0];
            min = arr[0];
            for (a = 1; a < b; a++)
            {
                if (arr[a] > max)
                {
                    max = arr[a];
                }
                if (arr[a] < min)
                {
                    min = arr[a];
                }
            }
            Console.Write("Maximum number = {0}\n", max);
            Console.Write("Minimum number = {0}\n", min);
        }
    }
}
