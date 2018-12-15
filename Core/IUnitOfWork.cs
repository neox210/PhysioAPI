using System;
using PhysioApi.Core.Repositories;

namespace PhysioApi.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IPhysioRepository Physios { get; } 
        IPatientRepository Patients { get; } 
        IVisitRepository Visits { get; } 
        IGroupVisitRepository GroupVisits { get; } 
        int Complete();
    }
}