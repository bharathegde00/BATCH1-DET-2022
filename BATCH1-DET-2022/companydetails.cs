using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class companydetails
    {
        
       public string name;
        public string address;
        public string phonenumber;
        public string faxnumber;
        public string website;
        public CompanyManager Manager { get; set; }


        //constructor - is a function used to init object data
        //has the same name as classname, no ret type
        public string Print()
        {
            return $"Name={name},Address={address},Phone={phonenumber},Fax={faxnumber},Website={website},ManagerName={Manager.print()}";
        }

    }
}
