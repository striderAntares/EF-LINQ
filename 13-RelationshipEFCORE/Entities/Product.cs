using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_RelationshipEFCORE.Entities
{
    public class Product
    {
        public Product()
        {
            Date = DateTime.Now;
        }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryRefID { get; set; }
        
        public DateTime Date { get; set; }
        //navigation property
        public virtual Category Category { get; set; } //kategorilere ulaşmak için. why virtual?you say. lazy loading demands it.
        public virtual ProductDetail ProductDetail { get; set; }
    }
}
