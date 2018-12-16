using PhysioApi.Core;
using PhysioApi.Core.Models;
using PhysioApi.Services.Interfaces;

namespace PhysioApi.Services
{
    public class PatientService : IPatientService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PatientService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public void AddPatient(Patient patient)
        {
            _unitOfWork.Patients.Add(patient);
            _unitOfWork.Complete();
        }

        public void DeletePatient(Patient patient)
        {
            _unitOfWork.Patients.Remove(patient);
            _unitOfWork.Complete();
        }

        public void EditPatient(Patient patient)
        {
            _unitOfWork.Patients.Update(patient);
            _unitOfWork.Complete();
        }

        public Patient GetPatient(int id)
        {
            return _unitOfWork.Patients.Get(id);
        }
    }
}