using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_NtierMapping.DATA
{
    public class BaseClass
    {
        public int ID { get; set; }
        public bool IsActive { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }

    /* Ntier:
     * Data - Entity
     * DAL - Data Access Layer - Context. entityleri alacak connection stringler migrationlar hep burada oluşacak. CRUD metotları burada olacak.
     * UI - User Interface (Console,Web,Windows Form App olabilir.) -DAL katmanı buraya gelecek. DALın dll dosyasını bunun dependancylerine eklenecek. -Entity (DATA) katmanları da eklenecek. DAL kütüphanesi diyebiliriz.
     */
}
