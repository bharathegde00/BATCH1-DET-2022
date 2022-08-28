using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignments
{
    internal class copyelements
    {
        public static void Main()
        {
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int i, n;
            Console.Write("Number of elements to be stored in the array:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter elements in the present array :\n ");
            for (i = 0; i < n; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                arr2[i] = arr1[i];
            }
            Console.Write("The elements stored in the present array are :");
            for (i = 0; i < n; i++)
            {
                Console.Write($"{arr1[i]} ");
            }
            Console.Write("\nThe elements to be copied to a new array are:");
            for (i = 0; i < n; i++)
            {
                Console.Write($"{arr2[i]} ");
            }
        }
    }
}
