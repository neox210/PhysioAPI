using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using PhysioApi.Core.Models;
using PhysioApi.Persistence.EntityConfiguration;

namespace PhysioApi.Persistence
{
    public class PhysioDbContext : DbContext
    {
        public PhysioDbContext(DbContextOptions<PhysioDbContext> options) : base(options)
        {
            
        }

        public virtual DbSet<Physio> Physios {get; set;}
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Visit> Visits { get; set; }
        public virtual DbSet<GroupVisit> GroupVisits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new PhysioConfiguration());
            modelBuilder.ApplyConfiguration(new VisitConfiguration());
            modelBuilder.ApplyConfiguration(new GroupVisitConfiguration());
        }
    }
}