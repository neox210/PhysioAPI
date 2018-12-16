using PhysioApi.Core.Models;

namespace PhysioApi.Services.Interfaces
{
    public interface IPhysioService
    {
         void AddPhysio(Physio physio);
         void EditPhysio(Physio physio);
         void DeletePhysio(Physio physio);
         Physio GetPhysio(int id);
    }
}