using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignments
{
    internal class swap
    {
        public static void Swap(ref int a, ref int b)
        {
            a = a * b;
            b = a / b;
            a = a / b;
        }

        public static void Main1(string[] args)
        {
            int a = 5, b = 10;
            Console.WriteLine($"Before swap a= {a} b= {b}");
            Swap(ref a, ref b);

            Console.WriteLine($"Before swap a= {a} b= {b}");
        }
    }
}
