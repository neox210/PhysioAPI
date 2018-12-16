using PhysioApi.Core.Models;

namespace PhysioApi.Services.Interfaces
{
    public interface IGroupVisitService
    {
         void AddGroupVisit(GroupVisit groupVisit);
         void EditGroupVisit(GroupVisit groupVisit);
         void DeleteGroupVisit(GroupVisit groupVisit);
         GroupVisit GetGroupVisit(int id);       
    }
}