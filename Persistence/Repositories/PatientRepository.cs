using Microsoft.EntityFrameworkCore;
using PhysioApi.Core.Models;
using PhysioApi.Core.Repositories;

namespace PhysioApi.Persistence.Repositories
{
    public class PatientRepository : Repository<Patient>, IPatientRepository
    {
        public PhysioDbContext PhysioDbContext => Context as PhysioDbContext;
        
        public PatientRepository(PhysioDbContext context) : base(context)
        {
        }
    }
}