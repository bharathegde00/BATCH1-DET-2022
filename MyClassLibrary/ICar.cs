using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    internal interface ICar
    {
        int GetPrice(String name);
    }
    class Hyundai : ICar
    {
        public int GetPrice(String name)
        {
            if (name == "i10")
            {
                return 2000000;
            }
            else if (name == "i20")
            {
                return 2500000;
            }
            else
                return 1500000;
        }

    }
    class BMW : ICar
    {
        public int GetPrice(String name)
        {
            if (name == "M3")
            {
                return 1300000;
            }
            else if (name == "X7")
            {
                return 9600000;
            }
            else
                return 1000000;
        }
    }
    class Toyoto : ICar
    {
        public int GetPrice(String name)
        {
            if (name == "Innova")
            {
                return 1700000;
            }
            else if (name == "Fortuner")
            {
                return 3200000;
            }
            else
                return 650000;
        }
    }
}

