using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_DataAnnotationFluentAPI.Model
{
    /*[NotMapped]*///komple tablonun oluşmasını da engelleyebiliriz böylece.
    public class AuditLog
    {
        public int EntityID { get; set; }
        public int UserID { get; set; }
        public DateTime Modified { get; set; }
    }
}
