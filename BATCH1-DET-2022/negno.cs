using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignments
{
    internal class negno
    {
        public static void Main()
        {
            int[] arr = { 76, -32, 97, -43, 75, -9 };
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
