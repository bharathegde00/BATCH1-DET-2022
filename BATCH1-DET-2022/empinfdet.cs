using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class empinfdet
    {
        public static void Main()
        {
            EmployeeInformation emp = new EmployeeInformation(22773,"Bharath","Bengaluru",560059,65437892,8000);
            Console.WriteLine($"Netsalary is ={emp.netsalary()}");
            Console.WriteLine($"Grade is = {emp.grade()}");
        }
    }
}
