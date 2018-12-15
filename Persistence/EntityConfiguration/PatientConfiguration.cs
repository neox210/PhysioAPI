using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhysioApi.Core.Models;

namespace PhysioApi.Persistence.EntityConfiguration
{
    public class PatientConfiguration : IEntityTypeConfiguration<Patient>
    {
        public void Configure(EntityTypeBuilder<Patient> builder)
        {
            //Properties options 
            builder.HasKey(p => p.Id);
            builder.Property(p => p.MobilePhone).HasMaxLength(20);
            builder.Property(p => p.HomePhone).HasMaxLength(20);
            builder.Property(p => p.PostalCode).HasMaxLength(10);
            builder.Property(p => p.Street).HasMaxLength(50);
            builder.Property(p => p.Name).HasMaxLength(50);
            builder.Property(p => p.Surname).HasMaxLength(50);
            builder.Property(p => p.City).HasMaxLength(50);

            //Relations
            builder.HasMany(p => p.Visits);
            builder.HasMany(p => p.GroupVisits);
        }
    }
}