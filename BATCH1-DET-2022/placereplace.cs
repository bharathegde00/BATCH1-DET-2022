using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignments
{
    internal class placereplace
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int num1 = (n / 1000) % 10;
            int num2 = (n / 100) % 10;
            int num3 = (n / 10) % 10;
            int num4 = (n % 10);
            int sum = num1 + num2 + num3 + num4;
            Console.WriteLine(sum);
            Console.WriteLine($"The reversed order is: {num4}{num3}{num2}{num1}");
            Console.WriteLine($"Last digit upfront: {num4}{num1}{num2}{num3}");
            Console.WriteLine($"Exchanges the second and the third digits: {num1}{num3}{num2}{num4}");
        }
    }
}
