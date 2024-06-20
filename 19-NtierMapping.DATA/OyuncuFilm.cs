using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_NtierMapping.DATA
{
    public class OyuncuFilm : BaseClass
    {
        public int OyuncuID { get; set; }
        public int FilmID { get; set; }
        public int CalismaGunu { get; set; }
        //Navigation prop bu ikisi birlikte composite olacak ondan sanırım liste yapmadık. bilemiyorum her şey olabilir.
        public virtual Film OyuncununFilmi { get; set; }
        public virtual Oyuncu FilminOyuncusu { get; set; }
    }
}
