using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _14_DataAnnotationFluentAPI.Model
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string fullName;
        //[NotMapped]
        public string FullName
        {
            get { return fullName = (FirstName + " " + LastName); }
            
        }
        /*[NotMapped]*///databasede oluşmasın kolonu diye bunu kullandık.
        public string FullNamee => $"{FirstName} {LastName}";
        public string Email { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastAccessed { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreationDate { get; set; }
        public AuditLog AuditLog { get; set; }

    }
}
