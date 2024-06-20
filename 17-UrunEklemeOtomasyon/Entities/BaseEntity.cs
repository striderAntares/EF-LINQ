using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_UrunEklemeOtomasyon.Entities
{
    public class BaseEntity
    {
        [Key]//kolonu primary key yapar
        [Column(Order = 1)]//bütün tablolarda 1. kolon olarak gelsin.
        public virtual int ID { get; set; }
        [Required]//non nullable
        [Column(Order = 2)]//tüm tablolarda 2. kolon olarak gelsin
        public virtual string Name { get; set; }
        public virtual bool IsActive { get; set; }
        [Column(TypeName = "datetime2")]//kolonun veri tipi datetime2 olarak atansın bu yapılmazsa default detatime dır.
        public virtual DateTime? AddedDate { get; set; } //? koyarak o kolon nullable eylenir.
    }
}
