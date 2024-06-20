using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_EFLiveExcersize.Entities
{
    internal class StudentDetail
    {
        //[Key]
        public int SDId { get; set; }
        public string Detail { get; set; }
        //[ForeignKey("Student")]
        public int StudentNo { get; set; }
        public Student Student { get; set; }
    }
}
