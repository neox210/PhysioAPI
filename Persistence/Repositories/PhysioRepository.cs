using Microsoft.EntityFrameworkCore;
using PhysioApi.Core.Models;
using PhysioApi.Core.Repositories;

namespace PhysioApi.Persistence.Repositories
{
    public class PhysioRepository : Repository<Physio>, IPhysioRepository
    {
        public PhysioDbContext PhysioDbContext => Context as PhysioDbContext;

        public PhysioRepository(PhysioDbContext context) : base(context)
        {
            
        }        
    }
}