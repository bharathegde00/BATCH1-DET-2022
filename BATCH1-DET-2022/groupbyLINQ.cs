using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class groupbyLINQ
    {
        private static void groupbystring()
        {
            List<string> words = new List<string> { "basket", "blueberry", "choco", "ant", "ball", "alter", "check" };


            // var wordgroups = from w in words
            //   group w by w[0] into g
            //   select new { Startlet = g.Key, words = g };
            var wordgroups = words.GroupBy(x => x[0]).Select(y => new { Startlet = y.Key, words = y });

            foreach (var item in wordgroups)
            {
                Console.WriteLine("Words that starts with the"+"letter '{0} :",item.Startlet);

                foreach(var w in item.words)
                {
                    Console.WriteLine(w);

                }
            }

        }

        static void groupbychar()
        {
            List<string> words = new List<string> { "basket", "blueberry", "choco", "ant", "ball", "alter", "check" };
            var wordgroups = words.GroupBy(x => x.Length).Select(y => new { Startlet = y.Key, words = y });

            foreach (var item in wordgroups)
            {
                Console.WriteLine("Words that starts with the" + "letter '{0} :", item.Startlet);

                foreach (var w in item.words)
                {
                    Console.WriteLine(w);

                }
            }
        }

        private static void Main()
        {
            //groupbystring();
            groupbychar();

        }
    }
}
