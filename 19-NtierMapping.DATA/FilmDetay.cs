using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_NtierMapping.DATA
{
    public class FilmDetay : BaseClass
    {
        public string FilmDetayi { get; set; }
        public int FilmID { get; set; }

        //Navigation
        public virtual Film DetayinFilmi { get; set; }
    }
}
