using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InheritanceEFCore.Entities
{
    internal class Employee : BasePerson
    {
        public DateTime AdmissionDate { get; set; }

        public string JobDescription { get; set; }
    }
}
