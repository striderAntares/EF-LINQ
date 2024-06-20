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
    public class ContactInfoMapping : IEntityTypeConfiguration<ContactInfo>
    {
        public void Configure(EntityTypeBuilder<ContactInfo> builder)
        {
            builder.ToTable("Iletisim Bilgileri");
            builder.Property(x=>x.Email).IsRequired();
            
            builder.HasOne(x => x.PersonnelOfContact).WithOne(x => x.ContactInfoOfPersonnel).HasForeignKey<ContactInfo>(x => x.PersonnelID);
            builder.HasKey(o=> new { o.PersonnelID, o.ContactID});
        }
    }
}
