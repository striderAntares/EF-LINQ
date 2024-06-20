using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InheritanceEFCore.Entities
{
    //Data Annotations
    //[Table("Musteriler")]
    internal class Customer : BasePerson
    {
        public  DateTime LastPurchaseDate { get; set; }
        public int TotalVisits { get; set; }
    }
}
