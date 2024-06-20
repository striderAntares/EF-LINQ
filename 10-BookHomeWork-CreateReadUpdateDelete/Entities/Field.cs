using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_StudentsHomeWork_CreateReadUpdateDelete.Entities
{
    public class Field
    {
        public int FieldID { get; set; }
        public string FieldName { get; set; }

        List<Student> Students { get; set; } //öğrencilere ulaşmak üçün
    }
}
