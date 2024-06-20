using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_RelationshipEFCORE.Entities
{
    public class ProductDetail
    {
        public int ProductDetailID { get; set; }
        public string Colour { get; set; }

        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public int ProductRefID { get; set; }
        public virtual Product Product { get; set; }
        
        
        
    }
}
