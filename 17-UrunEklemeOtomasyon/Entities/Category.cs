using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_UrunEklemeOtomasyon.Entities
{
    public class Category : BaseEntity //base entityden aldık
    {
        [MaxLength(255)]
        public virtual string Description { get; set; }

        //Navigation Property
        public virtual ICollection<Product> Products { get; set;}
        // 1 kategorinin 1den fazla ürünü olabilir.
    }
}
