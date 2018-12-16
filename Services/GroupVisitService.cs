using PhysioApi.Core;
using PhysioApi.Core.Models;
using PhysioApi.Services.Interfaces;

namespace PhysioApi.Services
{
    public class GroupVisitService : IGroupVisitService
    {
        
        private readonly IUnitOfWork _unitOfWork;

        public GroupVisitService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public void AddGroupVisit(GroupVisit GroupVisit)
        {
            _unitOfWork.GroupVisits.Add(GroupVisit);
            _unitOfWork.Complete();
        }

        public void DeleteGroupVisit(GroupVisit GroupVisit)
        {
            _unitOfWork.GroupVisits.Remove(GroupVisit);
            _unitOfWork.Complete();
        }

        public void EditGroupVisit(GroupVisit GroupVisit)
        {
            _unitOfWork.GroupVisits.Update(GroupVisit);
            _unitOfWork.Complete();
        }

        public GroupVisit GetGroupVisit(int id)
        {
            return _unitOfWork.GroupVisits.Get(id);
        }
    }
}