using _18_NtierMapping.DATA;
using _18_NTierMapping.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_NTierMapping.UI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            AppDbContext db = new AppDbContext();
            db.Filmler.Add(new Film());//gerekli class libraryleri ekledikten sonra public yapıp buradan ulaşabiliyoruz.
            Console.WriteLine("Bu arada UIın direk contextte ulaşmaması gerekiyor. mimari hakkında gerekli bilgileri n-tier architecture başlığı altında ulaşabilirsin. biz burada 3 katman koyduk.");
        }

    }
}
