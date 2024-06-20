using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_EFLiveExcersize.Entities
{
    [Table("Okul")]
    internal class School
    {
        public int SchoolId { get; set; }
        [Column("Okul Adi")]
        public string Name { get; set; }
        public ICollection<Department> Departments { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public ICollection<Student> Students { get; set; }
        [ForeignKey("Student")]
        public int StudentNo { get; set; }
    }
}
