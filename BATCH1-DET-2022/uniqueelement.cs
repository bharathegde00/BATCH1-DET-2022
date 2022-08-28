using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignments
{
    internal class uniqueelement
    {
        public static void Main()


        {
            int[] items = { 54,62,12,5,38,57,88,14,9,77 };
            int n = items.Length;

            Console.WriteLine("Unique array elements are: ");

            for (int i = 0; i < n; i++)
            {
                bool Same = false;
                for (int j = 0; j < i; j++)
                {
                    if (items[i] == items[j])
                    {
                        Same = true;
                        break;
                    }
                }

                if (!Same)
                {
                    Console.WriteLine(items[i]);

                }
            }

            Console.ReadLine();
        }
    }
}
