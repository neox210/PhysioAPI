using PhysioApi.Core;
using PhysioApi.Core.Models;
using PhysioApi.Services.Interfaces;

namespace PhysioApi.Services
{
    public class VisitService : IVisitService
    {
        private readonly IUnitOfWork _unitOfWork;

        public VisitService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public void AddVisit(Visit visit)
        {
            _unitOfWork.Visits.Add(visit);
            _unitOfWork.Complete();
        }

        public void DeleteVisit(Visit visit)
        {
            _unitOfWork.Visits.Remove(visit);
            _unitOfWork.Complete();
        }

        public void EditVisit(Visit visit)
        {
            _unitOfWork.Visits.Update(visit);
            _unitOfWork.Complete();
        }

        public Visit GetVisit(int id)
        {
            return _unitOfWork.Visits.Get(id);
        }
    }
}