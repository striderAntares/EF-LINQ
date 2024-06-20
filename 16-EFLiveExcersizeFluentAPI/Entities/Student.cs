using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_EFLiveExcersize.Entities
{
    internal class Student
    {
        //[Key]
        public int StudentNo { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        //[ForeignKey("School")]
        public int SchoolNo { get; set; }
        public School School { get; set; } //navigation property yazmadan data annotation yapsan bile foreign key oluşmaz databasede. önce navigation yazılacak sonra key yazılacak.
        //[ForeignKey("Laptop")]
        //[NotMapped]

        public int Id { get; set; }
        public Laptop Laptop { get; set; }

        //[ForeignKey("StudentDetail")]
        //[NotMapped]
        public int SDId { get; set; }
        public StudentDetail StudentDetail { get; set; }
    }
}
