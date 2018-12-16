using PhysioApi.Core.Models;

namespace PhysioApi.Services.Interfaces
{
    public interface IGroupVisitService
    {
         void AddGroupVisit(GroupVisit GroupVisit);
         void EditGroupVisit(GroupVisit GroupVisit);
         void DeleteGroupVisit(GroupVisit GroupVisit);
         GroupVisit GetGroupVisit(int id);       
    }
}