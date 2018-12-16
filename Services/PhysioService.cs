using PhysioApi.Core;
using PhysioApi.Core.Models;
using PhysioApi.Services.Interfaces;

namespace PhysioApi.Services
{
    public class PhysioService : IPhysioService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PhysioService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public void AddPhysio(Physio physio)
        {
            _unitOfWork.Physios.Add(physio);
            _unitOfWork.Complete();
        }

        public void DeletePhysio(Physio physio)
        {
            _unitOfWork.Physios.Remove(physio);
            _unitOfWork.Complete();
        }

        public void EditPhysio(Physio physio)
        {
            _unitOfWork.Physios.Update(physio);
            _unitOfWork.Complete();
        }

        public Physio GetPhysio(int id)
        {
            return _unitOfWork.Physios.Get(id);
        }
    }
}