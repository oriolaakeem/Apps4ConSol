using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ConSolHWeb.Data.Models.Mapping
{
    public class VxTelephoneMap : EntityTypeConfiguration<VxTelephone>
    {
        public VxTelephoneMap()
        {
            // Primary Key
            this.HasKey(t => t.PhoneNo);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.PhoneNo)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.TPhoneNumber)
                .HasMaxLength(15);

            this.Property(t => t.PrefixNo)
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("VxTelephones");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.PhoneNo).HasColumnName("PhoneNo");
            this.Property(t => t.TPhoneNumber).HasColumnName("TPhoneNumber");
            this.Property(t => t.PrefixNo).HasColumnName("PrefixNo");
            this.Property(t => t.DbSourceString).HasColumnName("DbSourceString");
        }
    }
}
