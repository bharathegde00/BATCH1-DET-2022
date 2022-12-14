using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class Emp1
    {
         //data declared inside class are known as "fields"
            int id;
            string name;
            string dept;
            double sal;
            DateOnly doj;

            //constructor - is a function used to init object data
            //has the same name as classname, no ret type
            public Emp1(int eid, string ename, DateOnly doj)
            {
                id = eid; name = ename; this.doj = doj;
            }

            //function written inside a class is known as method
            public int GetYearsofExp()
            {
                return DateTime.Now.Year - doj.Year;
            }
        

    }
}
