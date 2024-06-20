using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_UrunEklemeOtomasyon.Entities
{
    public class AppUser : BaseEntity
    {
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
        public virtual string LastName { get; set; }
        [NotMapped]
        public virtual string FullName => $"{Name} {LastName}";
        public virtual bool Gender { get; set; }
        public virtual DateTime? Birthdate { get; set; }
    }
}
