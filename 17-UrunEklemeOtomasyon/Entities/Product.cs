using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_UrunEklemeOtomasyon.Entities
{
    public class Product : BaseEntity
    {
        public  virtual decimal? UnitPrice { get; set; } //? nullable eyler. boş geçebiliriz. harezmi in da house

        public virtual short? Stock { get; set; }

        //foreign key
        [ForeignKey("Category")]//yazmak zorunlu değildi.
        public virtual int CategoryId { get; set; }
        //NavigationProperty
        //1 ürünün 1 kategorisi vardır.
        public virtual Category Category { get; set; }
    }
}
