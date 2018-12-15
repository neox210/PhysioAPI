using Microsoft.EntityFrameworkCore;
using PhysioApi.Core.Models;
using PhysioApi.Core.Repositories;

namespace PhysioApi.Persistence.Repositories
{
    public class GroupVisitRepository : Repository<GroupVisit>, IGroupVisitRepository
    {
        public PhysioDbContext PhysioDbContext => Context as PhysioDbContext;
        
        public GroupVisitRepository(PhysioDbContext context) : base(context)
        {
        }

    }
}