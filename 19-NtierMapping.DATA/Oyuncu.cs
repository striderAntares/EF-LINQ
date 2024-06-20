using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_NtierMapping.DATA
{
    public class Oyuncu : BaseClass
    {
        public string OyuncuAdi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Hayati { get; set; }
        //Navigation property
        public virtual List<OyuncuFilm> OyuncununFilmleri { get; set; }
    }
}
