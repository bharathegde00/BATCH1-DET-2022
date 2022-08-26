using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignments
{
    internal class negnos
    {
        public static void Main()
        {
            int[] arr = { 88, -67, 8, 56, -99, -23 };
            int i, n;
            n = arr.Length;
            for (i = 1; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    Console.Write($"{arr[i]}");
                }

            }
        }
    }
}
