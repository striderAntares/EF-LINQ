using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_DataAnnotationFluentAPI.Model
{
    public class Book
    {
        public int BookID { get; set; }
        //[Required]//bunu doldurmak zorunlu alan haline geldi.
        //[MaxLength(150)]//en fazla 150 karakter olabilsin dedik
        //[Column("Description",Order = 2, TypeName = "nvarchar(100)")]
        public string Title { get; set; }
        
        //[ForeignKey("Author")]
        public int AuthorFk { get; set; }//AuthorID deseydik otomatik anlayacaktı. öyle demedik o yüzden foreign key atamasını burda data annotationla yaptık.
        public Author Author { get; set; }
    }
}
