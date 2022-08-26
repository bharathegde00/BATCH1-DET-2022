using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class circle
    {

        //data declared inside class are known as "fields"
        double radius;
        //constructor - is a function used to init object data
        //has the same name as classname, no ret type
        public circle(double rad)
        {
           this.radius = rad;
        }

        //function written inside a class is known as method
        public double circlearea()
        {
            return Math.PI * radius * radius;
        }

    }
}
