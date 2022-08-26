using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class EmployeeInformation
    {

        //data declared inside class are known as "fields"
        int rollno;
        string name;
        string address;
        int pincode;
        int phoneno;
        int grosssal;
       
       
        

        //constructor - is a function used to init object data
        //has the same name as classname, no ret type
        public EmployeeInformation(int erollno, string ename, string eaddress, int epin,int ephone,int gsal)
        {
            rollno = erollno; name = ename; address = eaddress;pincode = epin;phoneno = ephone; grosssal = gsal;
        }

        //function written inside a class is known as method
        public double netsalary()
        {
            int pf = (12 * grosssal) / 100;
            double netsal = grosssal - pf;
            return netsal;
        }

        public  char grade()
        {
            double netsal = netsalary();
        
            if(netsal>10000)
            
               return 'A';

            
            else if(netsal>5000)
            
                return 'B';
            
            else
            
                return 'C';
            
        }

    }
}

    

