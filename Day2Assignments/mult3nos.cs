using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignments
{
    internal class mult3nos
    {
        public static int mulnum(int a, int b, int c)
        {
            return a * b * c;
        }
        public static void Main()
        {
            int a, b, c;

            Console.Write("Input the first number to multiply: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            c = int.Parse(Console.ReadLine());

            int result = mulnum(a, b, c);
            Console.WriteLine($"the output is {result}");

        }
    }
}
