using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_StudentsHomeWork_CreateReadUpdateDelete.Entities
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string TCKNO { get; set; }
        public string Sex { get; set; }
        //navigation
        public Field Field { get; set; } //fieldlara ulaşmak üçün.
        public int FieldID { get; set; } //foreign key.
    }
}
