using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_EFLiveExcersize.Entities
{
    internal class Laptop
    {
        //[Key]
        public int Id { get; set; }
        public string Name { get; set; }
        //[ForeignKey("Student")]
        
        public int StudentNo { get; set; }
        
        public Student Student { get; set; }
    }
}
