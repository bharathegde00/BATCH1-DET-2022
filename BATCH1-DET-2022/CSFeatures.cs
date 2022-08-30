using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class CSFeatures
    {
        public static void Main()
        {
            Action<string> action = (string name) => { Console.WriteLine($"Hi,{name}"); };
            Action<string, string> action1 = (string s1, string s2) => { Console.WriteLine($"Hi,{s1}," + $"I am saying {s2}"); };
            Action<string> action3 = (string s3) => { Console.WriteLine($"Hi,{s3}"); };
            action.Invoke("Bharath");
            action1.Invoke("Bharath", "I am in Bengaluru");
                action3.Invoke( "I cannot come now");
        }
    }
}
