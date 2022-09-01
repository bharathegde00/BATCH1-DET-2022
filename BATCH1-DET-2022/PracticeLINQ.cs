using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class PracticeLINQ
    {
        private static void Main()
        {
            List<int> prac=new List<int>();
            prac.Add(1);
            prac.Add(2);    
            prac.Add(3);    
            prac.Add(4);    
            prac.Add(5);
            prac.Add(6);

            var num = prac.Select(x => x + 1);

            foreach (int i in num)
            {
                Console.WriteLine("{0} " , i );
            }

            Console.ReadLine(); 
        }
    }
}
