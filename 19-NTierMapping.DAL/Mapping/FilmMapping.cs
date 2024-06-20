using _18_NtierMapping.DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_NTierMapping.DAL.Mapping
{
    public class FilmMapping : IEntityTypeConfiguration<Film>
    {
        public void Configure(EntityTypeBuilder<Film> builder) //appdbcontextte onmodelcreating override edip ulaştığımız özelliği burda ientitytypeconfigurationdan miras alarak sağlıyoruz. ama hala appdbcontext ile bunun arasında bir bağ mevcut değil onu sonradan yazacağız. //maplemek istediğin şeyin doğru tipini vermek zorundasın.
        {
            //Konfigurasyon çalışmalarını Context sınıfı yerine burada yapacağım.

            builder.Property(x => x.FilmAdi).IsRequired();
            builder.ToTable("Filmler");
            builder.HasOne(x => x.FilminKategorisi).WithMany(fk => fk.KategorininFilmleri).HasForeignKey(x => x.KategoriID);
        }
    }
}
