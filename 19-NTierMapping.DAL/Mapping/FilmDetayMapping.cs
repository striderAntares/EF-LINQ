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
    public class FilmDetayMapping : IEntityTypeConfiguration<FilmDetay> //maplemek istediğin şeyin doğru tipini vermek zorundasın.
    {
        public void Configure(EntityTypeBuilder<FilmDetay> builder)
        {
            throw new NotImplementedException();
        }
    }
}
