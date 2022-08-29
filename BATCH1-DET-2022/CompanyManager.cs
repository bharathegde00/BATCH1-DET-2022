using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class CompanyManager
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }   

        public string print()
        {

            return $"{Name}, Surname={Surname},Phone={Phone}";
        }
    }
}
