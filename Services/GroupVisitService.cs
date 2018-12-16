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

        public void AddGroupVisit(GroupVisit groupVisit)
        {
            _unitOfWork.GroupVisits.Add(groupVisit);
            _unitOfWork.Complete();
        }

        public void DeleteGroupVisit(GroupVisit groupVisit)
        {
            _unitOfWork.GroupVisits.Remove(groupVisit);
            _unitOfWork.Complete();
        }

        public void EditGroupVisit(GroupVisit groupVisit)
        {
            _unitOfWork.GroupVisits.Update(groupVisit);
            _unitOfWork.Complete();
        }

        public GroupVisit GetGroupVisit(int id)
        {
            return _unitOfWork.GroupVisits.Get(id);
        }
    }
}