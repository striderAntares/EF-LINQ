using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _19_DATA
{
    public class Personnel
    {
        public int PersonnelID { get; set; }
        public string PersonnelName { get; set; }
        public string PersonnelSurname { get; set; }
        public string TCIDNo { get; set; }
        public DateTime Birthdate { get; set; }
        public bool Sex { get; set; }
        public string Department { get; set; }
        
        
        //navprop
        public virtual ContactInfo ContactInfoOfPersonnel { get; set; }
    }
}
