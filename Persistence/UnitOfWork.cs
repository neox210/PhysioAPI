using PhysioApi.Core;
using PhysioApi.Core.Repositories;
using PhysioApi.Persistence.Repositories;

namespace PhysioApi.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        public IPhysioRepository Physios {get; private set;}
        public IPatientRepository Patients {get; private set;}
        public IVisitRepository Visits {get; private set;}
        public IGroupVisitRepository GroupVisits {get; private set;}

        private readonly PhysioDbContext _context;

        public UnitOfWork(PhysioDbContext context)
        {
            this._context = context;
            Physios = new PhysioRepository(context);
            Patients = new PatientRepository(context);
            Visits = new VisitRepository(context);
            GroupVisits = new GroupVisitRepository(context);
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}