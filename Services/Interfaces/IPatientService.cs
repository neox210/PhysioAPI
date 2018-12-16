using PhysioApi.Core.Models;

namespace PhysioApi.Services.Interfaces
{
    public interface IPatientService
    {
         void AddPatient(Patient patient);
         void EditPatient(Patient patient);
         void DeletePatient(Patient patient);
         Patient GetPatient(int id);
    }
}