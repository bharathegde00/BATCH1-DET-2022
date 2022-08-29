using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
     class companytest
    {
        public static void Main()
        {
           CompanyManager mgr=new CompanyManager { Name = "Bharath", Surname = "Hegde", Phone = "9876543210" };
           companydetails comp= new companydetails { name = "SSL", address = "Global City", phonenumber = "665453", faxnumber = "7654", website = "sonata-software.com", Manager = mgr };


            Console.WriteLine(comp.ToString());



        }
    }
}
