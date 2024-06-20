using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_DATA
{
    public class ContactInfo
    {
        public int ContactID { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string Adress { get; set; }
        public int PersonnelID { get; set; }
        //navprop
        public virtual Personnel PersonnelOfContact { get; set; }
    }
}
