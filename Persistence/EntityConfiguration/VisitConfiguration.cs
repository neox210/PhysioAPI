using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhysioApi.Core.Models;

namespace PhysioApi.Persistence.EntityConfiguration
{
    public class VisitConfiguration : IEntityTypeConfiguration<Visit>
    {
        public void Configure(EntityTypeBuilder<Visit> builder)
        {
            //Properties options 
            builder.HasKey(v => v.Id);
            builder.Property(v => v.Patient).IsRequired();
            builder.Property(v => v.Physio).IsRequired();
            builder.Property(v => v.Subject).HasMaxLength(255).IsRequired();
            builder.Property(v => v.Comment).HasMaxLength(1000).IsRequired();
            builder.Property(v => v.Date).IsRequired();

            //Relations
            builder.HasOne(v => v.Physio);
            builder.HasOne(v => v.Patient);
        }
    }
}