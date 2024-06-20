using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_NtierMapping.DATA
{
    public class Film : BaseClass
    {
        public string FilmAdi { get; set; }
        public DateTime SonYayinTarihi { get; set; }
        public int IzlenmeSayisi { get; set; }
        public int KategoriID { get; set; }
        public int FilmDetayID { get; set; }
        //Navigation prop
        public virtual Kategori FilminKategorisi { get; set; }
        public virtual FilmDetay FilminDetayi { get; set; }
        //film ve oyuncu arasındaki n-n ilişkisi için navprop
        public virtual List<OyuncuFilm> FilminOyuncuları { get; set; }


    }
}
