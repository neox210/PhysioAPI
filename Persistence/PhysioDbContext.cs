using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using PhysioApi.Core.Models;

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

    }
}