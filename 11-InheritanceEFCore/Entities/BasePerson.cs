using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_InheritanceEFCore.Entities
{
    internal class BasePerson
    {
        public  int ID { get; set; }
        public string Name { get; set; }

        public DateTime Birthdate { get; set; }
    }
}
