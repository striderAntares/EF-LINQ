using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_NtierMapping.DATA
{
    public class Kategori : BaseClass
    {
        public string KategoriAdi { get; set; }
        //Navigation
        public virtual List<Film> KategorininFilmleri { get; set; } = new List<Film>();
    }
}
