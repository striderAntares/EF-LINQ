using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _09_Model_DBContext_DBSet.Entities
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }

        //Navigation Property
        public Author Author { get; set; }
        public int AuthorID { get; set; }

    }
}
