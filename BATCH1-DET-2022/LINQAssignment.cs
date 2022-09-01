using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class LINQAssignment
    {
        static void charcontain()
        {
            string[] names = { "Bharath","Ronaldo","Ponting","Kohli","Anonymous" };

            var result = names.Where(n => n.Contains("o"));
           
            
            Console.WriteLine("Names which contatins o are:");
            foreach (string i in result)
              Console.WriteLine("{0} ", i);

        }

      //  static void maxnamelen()
        //{
          //  string[] names = { "john","peter","jacob","harry","jackson"};
          //  var name = names.Length();
            

           // foreach (string i in result)
            //    Console.WriteLine(result);

       //}



        private static void Main()
        {
            charcontain();
           // maxnamelen();

        }

    }
}
