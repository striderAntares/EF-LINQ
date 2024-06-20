using _19_DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_DAL_DataAccessLayer.Mapping
{
    public class PersonnelMapping : IEntityTypeConfiguration<Personnel>
    {
        public void Configure(EntityTypeBuilder<Personnel> builder)
        {
            builder.Property(x => x.PersonnelName).IsRequired();
            builder.ToTable("Personeller");
            
        }
    }
}
