using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_EFLiveExcersize.Entities
{
    internal class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        public ICollection<School> Schools { get; set; }

        public ICollection<Lesson> Lessons { get; set; }
    }
}
