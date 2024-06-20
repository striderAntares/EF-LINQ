using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_EFLiveExcersize.Entities
{
    internal class Lesson
    {
        //[Key]
        public int LessonNo { get; set; }
        public string Name { get; set; }
        //[ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
