using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PhysioApi.Core.Models;

namespace PhysioApi.Persistence.EntityConfiguration
{
    public class GroupVisitConfiguration : IEntityTypeConfiguration<GroupVisit>
    {
        public void Configure(EntityTypeBuilder<GroupVisit> builder)
        {
            //Properties options 
            builder.HasKey(gv => gv.Id);
            builder.Property(gv => gv.Patients).IsRequired();
            builder.Property(gv => gv.Physios).IsRequired();
            builder.Property(gv => gv.Subject).HasMaxLength(255).IsRequired();
            builder.Property(gv => gv.Comment).HasMaxLength(1000).IsRequired();
            builder.Property(gv => gv.Date).IsRequired();

            //Relations
            builder.HasMany(gv => gv.Physios);
            builder.HasMany(gv => gv.Patients);
        }
    }
}