using Microsoft.EntityFrameworkCore;
using PhysioApi.Core.Models;
using PhysioApi.Core.Repositories;

namespace PhysioApi.Persistence.Repositories
{
    public class VisitRepository : Repository<Visit>, IVisitRepository
    {
        public PhysioDbContext PhysioDbContext => Context as PhysioDbContext;
        
        public VisitRepository(PhysioDbContext context) : base(context)
        {
        }

    }
}